// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'FriendDeleteRequestMessage.xml' the '27/06/2012 15:55:06'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class FriendDeleteRequestMessage : NetworkMessage
	{
		public const uint Id = 5603;
		public override uint MessageId
		{
			get
			{
				return 5603;
			}
		}
		
		public string name;
		
		public FriendDeleteRequestMessage()
		{
		}
		
		public FriendDeleteRequestMessage(string name)
		{
			this.name = name;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(name);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			name = reader.ReadUTF();
		}
	}
}
