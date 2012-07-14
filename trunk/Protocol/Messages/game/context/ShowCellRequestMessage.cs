// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ShowCellRequestMessage.xml' the '27/06/2012 15:55:00'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ShowCellRequestMessage : NetworkMessage
	{
		public const uint Id = 5611;
		public override uint MessageId
		{
			get
			{
				return 5611;
			}
		}
		
		public short cellId;
		
		public ShowCellRequestMessage()
		{
		}
		
		public ShowCellRequestMessage(short cellId)
		{
			this.cellId = cellId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(cellId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			cellId = reader.ReadShort();
			if ( cellId < 0 || cellId > 559 )
			{
				throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < 0 || cellId > 559");
			}
		}
	}
}
