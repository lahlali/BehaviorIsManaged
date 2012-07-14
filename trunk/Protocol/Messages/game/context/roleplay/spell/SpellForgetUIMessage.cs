// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'SpellForgetUIMessage.xml' the '27/06/2012 15:55:06'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class SpellForgetUIMessage : NetworkMessage
	{
		public const uint Id = 5565;
		public override uint MessageId
		{
			get
			{
				return 5565;
			}
		}
		
		public bool open;
		
		public SpellForgetUIMessage()
		{
		}
		
		public SpellForgetUIMessage(bool open)
		{
			this.open = open;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(open);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			open = reader.ReadBoolean();
		}
	}
}
