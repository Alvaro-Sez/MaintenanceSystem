using InfraMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS.Application.Verification.NetworkVerification
{
    public class NetworkVerification : INetworkVerification
    {
        public double GetDataServersAverageRAM(List<Server> serverList)
        {
            List<Server> dataServers = serverList.Where(s => s.Type == ServerEnum.Data).ToList();
            double averageFreeRAM = dataServers.Select(s => s.FreeRAM).Average();
            return averageFreeRAM;
        }

        public double GetAverageBandWidth(List<Server> serverList)
        {
            double averageBandWidth = serverList.Select(s => s.BandWidth).Average();
            return averageBandWidth;
        }
        public double GetAverageCPU(List<Server> serverList)
        {
            double averageCPUConsumption = serverList.Select(s => s.CPU).Average();
            return averageCPUConsumption;
        }
    }
}
