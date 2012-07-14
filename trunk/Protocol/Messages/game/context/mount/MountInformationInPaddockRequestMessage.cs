// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'MountInformationInPaddockRequestMessage.xml' the '27/06/2012 15:55:01'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class MountInformationInPaddockRequestMessage : NetworkMessage
	{
		public const uint Id = 5975;
		public override uint MessageId
		{
			get
			{
				return 5975;
			}
		}
		
		public int mapRideId;
		
		public MountInformationInPaddockRequestMessage()
		{
		}
		
		public MountInformationInPaddockRequestMessage(int mapRideId)
		{
			this.mapRideId = mapRideId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(mapRideId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			mapRideId = reader.ReadInt();
		}
	}
}
