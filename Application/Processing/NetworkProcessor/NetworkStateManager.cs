using InfraMS.Application.Verification.NetworkVerification;
using InfraMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS.Application.Processing.NetworkProcessor
{
    public class NetworkStateManager
    {
        private readonly INetworkVerification _networkVerifications;
        private NetworkState network = new NetworkState();

        public NetworkStateManager(INetworkVerification networkVerifications)
        {
            _networkVerifications = networkVerifications;
        }

        public NetworkState GetGeneralState(List<Server> serverList)
        {
            network.CPU = _networkVerifications.GetAverageCPU(serverList);
            network.BandWith = _networkVerifications.GetAverageBandWidth(serverList);
            network.DataServersFreeRAM = _networkVerifications.GetDataServersAverageRAM(serverList);
            return network;
        }


    }
}
