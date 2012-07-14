// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'AccountHouseMessage.xml' the '27/06/2012 15:55:02'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class AccountHouseMessage : NetworkMessage
	{
		public const uint Id = 6315;
		public override uint MessageId
		{
			get
			{
				return 6315;
			}
		}
		
		public IEnumerable<Types.AccountHouseInformations> houses;
		
		public AccountHouseMessage()
		{
		}
		
		public AccountHouseMessage(IEnumerable<Types.AccountHouseInformations> houses)
		{
			this.houses = houses;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort((ushort)houses.Count());
			foreach (var entry in houses)
			{
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			int limit = reader.ReadUShort();
			houses = new Types.AccountHouseInformations[limit];
			for (int i = 0; i < limit; i++)
			{
				(houses as Types.AccountHouseInformations[])[i] = new Types.AccountHouseInformations();
				(houses as Types.AccountHouseInformations[])[i].Deserialize(reader);
			}
		}
	}
}
