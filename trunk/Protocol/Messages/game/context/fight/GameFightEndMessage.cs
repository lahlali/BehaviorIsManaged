// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameFightEndMessage.xml' the '27/06/2012 15:55:00'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class GameFightEndMessage : NetworkMessage
	{
		public const uint Id = 720;
		public override uint MessageId
		{
			get
			{
				return 720;
			}
		}
		
		public int duration;
		public short ageBonus;
		public short lootShareLimitMalus;
		public IEnumerable<Types.FightResultListEntry> results;
		
		public GameFightEndMessage()
		{
		}
		
		public GameFightEndMessage(int duration, short ageBonus, short lootShareLimitMalus, IEnumerable<Types.FightResultListEntry> results)
		{
			this.duration = duration;
			this.ageBonus = ageBonus;
			this.lootShareLimitMalus = lootShareLimitMalus;
			this.results = results;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(duration);
			writer.WriteShort(ageBonus);
			writer.WriteShort(lootShareLimitMalus);
			writer.WriteUShort((ushort)results.Count());
			foreach (var entry in results)
			{
				writer.WriteShort(entry.TypeId);
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			duration = reader.ReadInt();
			if ( duration < 0 )
			{
				throw new Exception("Forbidden value on duration = " + duration + ", it doesn't respect the following condition : duration < 0");
			}
			ageBonus = reader.ReadShort();
			lootShareLimitMalus = reader.ReadShort();
			int limit = reader.ReadUShort();
			results = new Types.FightResultListEntry[limit];
			for (int i = 0; i < limit; i++)
			{
				(results as Types.FightResultListEntry[])[i] = Types.ProtocolTypeManager.GetInstance<Types.FightResultListEntry>(reader.ReadShort());
				(results as Types.FightResultListEntry[])[i].Deserialize(reader);
			}
		}
	}
}
