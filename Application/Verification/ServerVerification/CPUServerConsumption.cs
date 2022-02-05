using InfraMS.Application.ProcessingMethods;
using InfraMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS.Application.Verification.ServerVerification
{
    public class CPUServerConsumption : IServerVerification
    {
        public ProcessingMethodEnum Verificate(Server server)
        {
            if (server.CPU > 80) { return ProcessingMethodEnum.scale; }
            return ProcessingMethodEnum.none;
        }
    }
}
