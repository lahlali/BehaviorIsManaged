// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeMountPaddockRemoveMessage.xml' the '27/06/2012 15:55:09'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ExchangeMountPaddockRemoveMessage : NetworkMessage
	{
		public const uint Id = 6050;
		public override uint MessageId
		{
			get
			{
				return 6050;
			}
		}
		
		public double mountId;
		
		public ExchangeMountPaddockRemoveMessage()
		{
		}
		
		public ExchangeMountPaddockRemoveMessage(double mountId)
		{
			this.mountId = mountId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(mountId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			mountId = reader.ReadDouble();
		}
	}
}
