using InfraMS.Application.Verification.ServerVerification;
using InfraMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS.Application.ProcessingMethods.ServerProcessingMethods
{
    public interface IScaleServers
    {
        List<Server> ScaleServers(IServerVerification verification, List<Server> serverList);
    }
}
