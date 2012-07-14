// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeMultiCraftCrafterCanUseHisRessourcesMessage.xml' the '27/06/2012 15:55:11'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ExchangeMultiCraftCrafterCanUseHisRessourcesMessage : NetworkMessage
	{
		public const uint Id = 6020;
		public override uint MessageId
		{
			get
			{
				return 6020;
			}
		}
		
		public bool allowed;
		
		public ExchangeMultiCraftCrafterCanUseHisRessourcesMessage()
		{
		}
		
		public ExchangeMultiCraftCrafterCanUseHisRessourcesMessage(bool allowed)
		{
			this.allowed = allowed;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(allowed);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			allowed = reader.ReadBoolean();
		}
	}
}
