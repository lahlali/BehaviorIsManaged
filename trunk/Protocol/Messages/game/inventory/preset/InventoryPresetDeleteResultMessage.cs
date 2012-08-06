// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'InventoryPresetDeleteResultMessage.xml' the '27/06/2012 15:55:12'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class InventoryPresetDeleteResultMessage : NetworkMessage
	{
		public const uint Id = 6173;
		public override uint MessageId
		{
			get
			{
				return 6173;
			}
		}
		
		public sbyte presetId;
		public sbyte code;
		
		public InventoryPresetDeleteResultMessage()
		{
		}
		
		public InventoryPresetDeleteResultMessage(sbyte presetId, sbyte code)
		{
			this.presetId = presetId;
			this.code = code;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(presetId);
			writer.WriteSByte(code);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			presetId = reader.ReadSByte();
			if ( presetId < 0 )
			{
				throw new Exception("Forbidden value on presetId = " + presetId + ", it doesn't respect the following condition : presetId < 0");
			}
			code = reader.ReadSByte();
			if ( code < 0 )
			{
				throw new Exception("Forbidden value on code = " + code + ", it doesn't respect the following condition : code < 0");
			}
		}
	}
}