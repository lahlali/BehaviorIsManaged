// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'InventoryPresetDeleteMessage.xml' the '27/06/2012 15:55:12'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class InventoryPresetDeleteMessage : NetworkMessage
	{
		public const uint Id = 6169;
		public override uint MessageId
		{
			get
			{
				return 6169;
			}
		}
		
		public sbyte presetId;
		
		public InventoryPresetDeleteMessage()
		{
		}
		
		public InventoryPresetDeleteMessage(sbyte presetId)
		{
			this.presetId = presetId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(presetId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			presetId = reader.ReadSByte();
			if ( presetId < 0 )
			{
				throw new Exception("Forbidden value on presetId = " + presetId + ", it doesn't respect the following condition : presetId < 0");
			}
		}
	}
}