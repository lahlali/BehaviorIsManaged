// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeStartOkMulticraftCrafterMessage.xml' the '27/06/2012 15:55:11'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ExchangeStartOkMulticraftCrafterMessage : NetworkMessage
	{
		public const uint Id = 5818;
		public override uint MessageId
		{
			get
			{
				return 5818;
			}
		}
		
		public sbyte maxCase;
		public int skillId;
		
		public ExchangeStartOkMulticraftCrafterMessage()
		{
		}
		
		public ExchangeStartOkMulticraftCrafterMessage(sbyte maxCase, int skillId)
		{
			this.maxCase = maxCase;
			this.skillId = skillId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(maxCase);
			writer.WriteInt(skillId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			maxCase = reader.ReadSByte();
			if ( maxCase < 0 )
			{
				throw new Exception("Forbidden value on maxCase = " + maxCase + ", it doesn't respect the following condition : maxCase < 0");
			}
			skillId = reader.ReadInt();
			if ( skillId < 0 )
			{
				throw new Exception("Forbidden value on skillId = " + skillId + ", it doesn't respect the following condition : skillId < 0");
			}
		}
	}
}
