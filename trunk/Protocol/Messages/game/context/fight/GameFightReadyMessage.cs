// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameFightReadyMessage.xml' the '27/06/2012 15:55:00'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class GameFightReadyMessage : NetworkMessage
	{
		public const uint Id = 708;
		public override uint MessageId
		{
			get
			{
				return 708;
			}
		}
		
		public bool isReady;
		
		public GameFightReadyMessage()
		{
		}
		
		public GameFightReadyMessage(bool isReady)
		{
			this.isReady = isReady;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(isReady);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			isReady = reader.ReadBoolean();
		}
	}
}
