// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'NumericWhoIsRequestMessage.xml' the '27/06/2012 15:54:58'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class NumericWhoIsRequestMessage : NetworkMessage
	{
		public const uint Id = 6298;
		public override uint MessageId
		{
			get
			{
				return 6298;
			}
		}
		
		public int playerId;
		
		public NumericWhoIsRequestMessage()
		{
		}
		
		public NumericWhoIsRequestMessage(int playerId)
		{
			this.playerId = playerId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(playerId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			playerId = reader.ReadInt();
			if ( playerId < 0 )
			{
				throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
			}
		}
	}
}
