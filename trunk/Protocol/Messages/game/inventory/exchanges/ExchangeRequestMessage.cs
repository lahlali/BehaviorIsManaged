// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeRequestMessage.xml' the '27/06/2012 15:55:10'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ExchangeRequestMessage : NetworkMessage
	{
		public const uint Id = 5505;
		public override uint MessageId
		{
			get
			{
				return 5505;
			}
		}
		
		public sbyte exchangeType;
		
		public ExchangeRequestMessage()
		{
		}
		
		public ExchangeRequestMessage(sbyte exchangeType)
		{
			this.exchangeType = exchangeType;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(exchangeType);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			exchangeType = reader.ReadSByte();
		}
	}
}
