using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS.Application.ProcessingMethods.ServerProcessingMethods
{
    public interface INetworkProcessingMethods : IShutdownServers, IRestartServers, IScaleServers
    {

    }
}
