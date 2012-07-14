// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'FriendAddFailureMessage.xml' the '27/06/2012 15:55:06'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class FriendAddFailureMessage : NetworkMessage
	{
		public const uint Id = 5600;
		public override uint MessageId
		{
			get
			{
				return 5600;
			}
		}
		
		public sbyte reason;
		
		public FriendAddFailureMessage()
		{
		}
		
		public FriendAddFailureMessage(sbyte reason)
		{
			this.reason = reason;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(reason);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			reason = reader.ReadSByte();
			if ( reason < 0 )
			{
				throw new Exception("Forbidden value on reason = " + reason + ", it doesn't respect the following condition : reason < 0");
			}
		}
	}
}
