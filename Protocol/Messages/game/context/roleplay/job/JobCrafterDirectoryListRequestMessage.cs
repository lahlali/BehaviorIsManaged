

// Generated on 04/17/2013 22:29:47
using System;
using System.Collections.Generic;
using System.Linq;
using BiM.Protocol.Types;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
    public class JobCrafterDirectoryListRequestMessage : NetworkMessage
    {
        public const uint Id = 6047;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte jobId;
        
        public JobCrafterDirectoryListRequestMessage()
        {
        }
        
        public JobCrafterDirectoryListRequestMessage(sbyte jobId)
        {
            this.jobId = jobId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSByte(jobId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            jobId = reader.ReadSByte();
            if (jobId < 0)
                throw new Exception("Forbidden value on jobId = " + jobId + ", it doesn't respect the following condition : jobId < 0");
        }
        
    }
    
}