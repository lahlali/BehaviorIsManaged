// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameRolePlayShowChallengeMessage.xml' the '27/06/2012 15:55:02'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class GameRolePlayShowChallengeMessage : NetworkMessage
	{
		public const uint Id = 301;
		public override uint MessageId
		{
			get
			{
				return 301;
			}
		}
		
		public Types.FightCommonInformations commonsInfos;
		
		public GameRolePlayShowChallengeMessage()
		{
		}
		
		public GameRolePlayShowChallengeMessage(Types.FightCommonInformations commonsInfos)
		{
			this.commonsInfos = commonsInfos;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			commonsInfos.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			commonsInfos = new Types.FightCommonInformations();
			commonsInfos.Deserialize(reader);
		}
	}
}
