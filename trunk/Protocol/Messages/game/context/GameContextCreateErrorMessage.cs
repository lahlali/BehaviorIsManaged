// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameContextCreateErrorMessage.xml' the '27/06/2012 15:55:00'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class GameContextCreateErrorMessage : NetworkMessage
	{
		public const uint Id = 6024;
		public override uint MessageId
		{
			get
			{
				return 6024;
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
