﻿#region License GNU GPL
// NetworkMessageDispatcher.cs
// 
// Copyright (C) 2012 - BehaviorIsManaged
// 
// This program is free software; you can redistribute it and/or modify it 
// under the terms of the GNU General Public License as published by the Free Software Foundation;
// either version 2 of the License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
// without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. 
// See the GNU General Public License for more details. 
// You should have received a copy of the GNU General Public License along with this program; 
// if not, write to the Free Software Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using BiM.Behaviors;
using BiM.Core.Messages;
using BiM.Core.Network;
using NLog;

namespace BiM.MITM.Network
{
    public class NetworkMessageDispatcher : MessageDispatcher
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly List<Message> m_logs = new List<Message>();

        public NetworkMessageDispatcher()
        {
        }

        public IClient Client
        {
            get;
            set;
        }

        public IClient Server
        {
            get;
            set;
        }

        protected override void Dispatch(Message message, object token)
        {
#if DEBUG
            m_logs.Add(message);
#endif

            if (message == null) throw new ArgumentNullException("message");
            if (message is NetworkMessage)
                Dispatch(message as NetworkMessage, token);
            else
                base.Dispatch(message, token);
        }

        protected void Dispatch(NetworkMessage message, object token)
        {
            if (message == null) throw new ArgumentNullException("message");

            try
            {
                if (message.Destinations.HasFlag(ListenerEntry.Local))
                {
                    InternalDispatch(message, token);
                }

                if (Client != null && message.Destinations.HasFlag(ListenerEntry.Client))
                {
                    Client.Send(message);
                }

                if (Server != null && message.Destinations.HasFlag(ListenerEntry.Server))
                {
                    Server.Send(message);
                }

                message.OnDispatched();
                OnMessageDispatched(message);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Cannot dispatch {0}", message), ex);
            }
        }

        private void InternalDispatch(NetworkMessage message, object token)
        {
            if (message == null) throw new ArgumentNullException("message");
            var handlers = GetHandlers(message.GetType(), token).ToArray(); // have to transform it into a collection if we want to add/remove handler
            

            foreach (var handler in handlers)
            {
                if (handler.Attribute.DestinationFilter != ListenerEntry.Undefined &&
                    handler.Attribute.DestinationFilter != message.Destinations && 
                    (handler.Attribute.DestinationFilter & message.Destinations) == ListenerEntry.Undefined)
                    continue;

                if (handler.Attribute.FromFilter != ListenerEntry.Undefined && 
                    handler.Attribute.FromFilter != message.From &&
                    (handler.Attribute.FromFilter & message.From) == ListenerEntry.Undefined)
                    continue;

                handler.Action(handler.Container, token, message);

                if (message.Canceled)
                    break;
            }
        }
    }
}