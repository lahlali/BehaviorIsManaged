// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'CharactersListErrorMessage.xml' the '27/06/2012 15:54:58'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class CharactersListErrorMessage : NetworkMessage
	{
		public const uint Id = 5545;
		public override uint MessageId
		{
			get
			{
				return 5545;
			}
		}
		
		
		public override void Serialize(IDataWriter writer)
		{
		}
		
		public override void Deserialize(IDataReader reader)
		{
		}
	}
}
