// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'QuestListRequestMessage.xml' the '27/06/2012 15:55:05'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class QuestListRequestMessage : NetworkMessage
	{
		public const uint Id = 5623;
		public override uint MessageId
		{
			get
			{
				return 5623;
			}
		}
		
		
		public override void Serialize(IDataWriter writer)
		{
		}
		
		public override void Deserialize(IDataReader reader)
		{
		}
	}
}
