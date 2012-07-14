// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GuildModificationValidMessage.xml' the '27/06/2012 15:55:07'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class GuildModificationValidMessage : NetworkMessage
	{
		public const uint Id = 6323;
		public override uint MessageId
		{
			get
			{
				return 6323;
			}
		}
		
		public string guildName;
		public Types.GuildEmblem guildEmblem;
		
		public GuildModificationValidMessage()
		{
		}
		
		public GuildModificationValidMessage(string guildName, Types.GuildEmblem guildEmblem)
		{
			this.guildName = guildName;
			this.guildEmblem = guildEmblem;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(guildName);
			guildEmblem.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			guildName = reader.ReadUTF();
			guildEmblem = new Types.GuildEmblem();
			guildEmblem.Deserialize(reader);
		}
	}
}
