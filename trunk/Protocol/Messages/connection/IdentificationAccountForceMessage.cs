// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'IdentificationAccountForceMessage.xml' the '27/06/2012 15:54:55'
using System;
using BiM.Core.IO;
using System.Collections.Generic;

namespace BiM.Protocol.Messages
{
	public class IdentificationAccountForceMessage : IdentificationMessage
	{
		public const uint Id = 6119;
		public override uint MessageId
		{
			get
			{
				return 6119;
			}
		}
		
		public string forcedAccountLogin;
		
		public IdentificationAccountForceMessage()
		{
		}
		
		public IdentificationAccountForceMessage(bool autoconnect, bool useCertificate, bool useLoginToken, Types.VersionExtended version, string lang, string login, IEnumerable<sbyte> credentials, short serverId, string forcedAccountLogin)
			 : base(autoconnect, useCertificate, useLoginToken, version, lang, login, credentials, serverId)
		{
			this.forcedAccountLogin = forcedAccountLogin;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(forcedAccountLogin);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			forcedAccountLogin = reader.ReadUTF();
		}
	}
}