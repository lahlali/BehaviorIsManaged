

// Generated on 04/17/2013 22:29:51
using System;
using System.Collections.Generic;
using System.Linq;
using BiM.Protocol.Types;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
    public class PartyRefuseInvitationMessage : AbstractPartyMessage
    {
        public const uint Id = 5582;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public PartyRefuseInvitationMessage()
        {
        }
        
        public PartyRefuseInvitationMessage(int partyId)
         : base(partyId)
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}