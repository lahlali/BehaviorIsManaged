// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ShortcutBarContentMessage.xml' the '27/06/2012 15:55:13'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ShortcutBarContentMessage : NetworkMessage
	{
		public const uint Id = 6231;
		public override uint MessageId
		{
			get
			{
				return 6231;
			}
		}
		
		public sbyte barType;
		public IEnumerable<Types.Shortcut> shortcuts;
		
		public ShortcutBarContentMessage()
		{
		}
		
		public ShortcutBarContentMessage(sbyte barType, IEnumerable<Types.Shortcut> shortcuts)
		{
			this.barType = barType;
			this.shortcuts = shortcuts;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(barType);
			writer.WriteUShort((ushort)shortcuts.Count());
			foreach (var entry in shortcuts)
			{
				writer.WriteShort(entry.TypeId);
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			barType = reader.ReadSByte();
			if ( barType < 0 )
			{
				throw new Exception("Forbidden value on barType = " + barType + ", it doesn't respect the following condition : barType < 0");
			}
			int limit = reader.ReadUShort();
			shortcuts = new Types.Shortcut[limit];
			for (int i = 0; i < limit; i++)
			{
				(shortcuts as Types.Shortcut[])[i] = Types.ProtocolTypeManager.GetInstance<Types.Shortcut>(reader.ReadShort());
				(shortcuts as Types.Shortcut[])[i].Deserialize(reader);
			}
		}
	}
}
