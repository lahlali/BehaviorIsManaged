// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameActionAcknowledgementMessage.xml' the '27/06/2012 15:54:56'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class GameActionAcknowledgementMessage : NetworkMessage
	{
		public const uint Id = 957;
		public override uint MessageId
		{
			get
			{
				return 957;
			}
		}
		
		public bool valid;
		public sbyte actionId;
		
		public GameActionAcknowledgementMessage()
		{
		}
		
		public GameActionAcknowledgementMessage(bool valid, sbyte actionId)
		{
			this.valid = valid;
			this.actionId = actionId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(valid);
			writer.WriteSByte(actionId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			valid = reader.ReadBoolean();
			actionId = reader.ReadSByte();
		}
	}
}
