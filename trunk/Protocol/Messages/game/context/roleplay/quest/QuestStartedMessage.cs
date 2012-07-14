// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'QuestStartedMessage.xml' the '27/06/2012 15:55:06'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class QuestStartedMessage : NetworkMessage
	{
		public const uint Id = 6091;
		public override uint MessageId
		{
			get
			{
				return 6091;
			}
		}
		
		public ushort questId;
		
		public QuestStartedMessage()
		{
		}
		
		public QuestStartedMessage(ushort questId)
		{
			this.questId = questId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort(questId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			questId = reader.ReadUShort();
			if ( questId < 0 || questId > 65535 )
			{
				throw new Exception("Forbidden value on questId = " + questId + ", it doesn't respect the following condition : questId < 0 || questId > 65535");
			}
		}
	}
}
