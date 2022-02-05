using InfraMS.Application.Verification.ServerVerification;
using InfraMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS.Application.Processing.ProcessingMethods.ServerProcessingMethods
{
    public interface IShutdownServers
    {
        List<Server> ShutdownServers(IServerVerification verification, List<Server> serverList);
    }
}
