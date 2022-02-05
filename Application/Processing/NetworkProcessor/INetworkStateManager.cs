using InfraMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS.Application.Processing.NetworkProcessor
{
    public interface INetworkStateManager
    {
        public NetworkState GetGeneralState(List<Server> serverList);
    }
}
