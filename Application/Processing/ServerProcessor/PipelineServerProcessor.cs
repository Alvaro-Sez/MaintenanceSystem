using InfraMS.Application.Processing.ProcessingMethods.ServerProcessingMethods;
using InfraMS.Application.Verification.ServerVerification;
using InfraMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS.Application.Processing.ServerProcessor
{
    public class PipelineServerProcessor : IPipelineServerProcessor
    {
        private readonly IEnumerable<IServerVerification> _verificationList;
        private readonly INetworkProcessingMethods _processorMethod;
        public PipelineServerProcessor(IEnumerable<IServerVerification> verificationList, INetworkProcessingMethods processorMethods)
        {
            _verificationList = verificationList;
            _processorMethod = processorMethods;
        }

        public List<Server> Filter(List<Server> serverList)
        {
            List<Server> filteredList = serverList;

            foreach(IServerVerification verification in _verificationList)
            {
                filteredList = _processorMethod.ShutdownServers(verification, filteredList);
                filteredList = _processorMethod.RestartServers(verification, filteredList);
                filteredList = _processorMethod.ScaleServers(verification, filteredList);
            }
            return filteredList;
        }
        
    }
}
