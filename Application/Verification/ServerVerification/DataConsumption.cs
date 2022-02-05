using InfraMS.Application.ProcessingMethods;
using InfraMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS.Application.Verification.ServerVerification
{
    internal class DataConsumption : IServerVerification
    {

        public ProcessingMethodEnum Verificate(Server server)
        {
            if(server.Type == ServerEnum.Data)
            {
                if(server.DiskUsage >= 90) { return ProcessingMethodEnum.scale; }
                return ProcessingMethodEnum.none;
            }
            if (server.DiskUsage > 80) { return ProcessingMethodEnum.scale; }
            return ProcessingMethodEnum.none;
        }
    }
}
