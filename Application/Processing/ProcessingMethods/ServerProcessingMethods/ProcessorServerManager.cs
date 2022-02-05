using InfraMS.Application.Verification.ServerVerification;
using InfraMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS.Application.Processing.ProcessingMethods.ServerProcessingMethods
{
    public class ProcessorServerManager : IProcessorServerMethods
    {
        
        public List<Server> ShutdownServers(IServerVerification verification, List<Server> serverList)
        {
            serverList.ForEach(x =>
            {
                if (verification.Verificate(x) == ProcessingMethodEnum.shutdown)
                {
                    x.ShutdownTime = DateTime.Now;
                    x.Memory = 0;
                    x.CPU = 0;
                    x.BandWidth = 0;
                    x.VMRunning = false;
                }
            });
            return serverList;
        }

        public List<Server> RestartServers(IServerVerification verification,List<Server> serverList)
        {
            serverList.ForEach(x =>
            {
                if (verification.Verificate(x) == ProcessingMethodEnum.restart)
                {
                    x.RestartTime = DateTime.Now;
                }
            });
            return serverList;
        }

        public List<Server> ScaleServers(IServerVerification verification, List<Server> serverList)
        {
            serverList.ForEach(x =>
            {
                if (verification.Verificate(x) == ProcessingMethodEnum.scale)
                {
                    x.Scaled = true;
                }
            });
            return serverList;
        }
    }
}
