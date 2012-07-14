// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeMountStableRemoveMessage.xml' the '27/06/2012 15:55:09'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ExchangeMountStableRemoveMessage : NetworkMessage
	{
		public const uint Id = 5964;
		public override uint MessageId
		{
			get
			{
				return 5964;
			}
		}
		
		public double mountId;
		
		public ExchangeMountStableRemoveMessage()
		{
		}
		
		public ExchangeMountStableRemoveMessage(double mountId)
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
