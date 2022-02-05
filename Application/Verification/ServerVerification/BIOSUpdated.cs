using InfraMS.Application.ProcessingMethods;
using InfraMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS.Application.Verification.ServerVerification
{
    public class BIOSUpdated : IServerVerification
    {
        public ProcessingMethodEnum Verificate(Server server)
        {
            if(server.BiosUpdated) { return ProcessingMethodEnum.none; }
            return ProcessingMethodEnum.shutdown; 
        }
    }
}
