// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GuildKickRequestMessage.xml' the '27/06/2012 15:55:07'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class GuildKickRequestMessage : NetworkMessage
	{
		public const uint Id = 5887;
		public override uint MessageId
		{
			get
			{
				return 5887;
			}
		}
		
		public int kickedId;
		
		public GuildKickRequestMessage()
		{
		}
		
		public GuildKickRequestMessage(int kickedId)
		{
			this.kickedId = kickedId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(kickedId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			kickedId = reader.ReadInt();
			if ( kickedId < 0 )
			{
				throw new Exception("Forbidden value on kickedId = " + kickedId + ", it doesn't respect the following condition : kickedId < 0");
			}
		}
	}
}
