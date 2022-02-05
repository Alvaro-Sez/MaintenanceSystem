using System;
using InfraMS.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS.Infraestructure
{
    public class AmazonNetworkService : INetworkService
    {
        public List<Server> GetServers()
        {
            List<Server> servers = new List<Server>();
            Random rnd = new Random();
            
            for (int i = 0; i < 50; i++)
            {
                Server server = new Server()
                {
                    CPU = rnd.Next(65, 99),
                    Memory = rnd.Next(65, 99),
                    BandWidth = rnd.Next(65, 99),
                    DiskUsage = rnd.Next(65, 99),
                    FreeRAM = rnd.Next(1, 35),
                    Type = (ServerEnum)rnd.Next(0, 2),
                    BiosUpdated = rnd.Next(0, 2) == 1 ? true : false,
                    ControllersInstalled = rnd.Next(0, 2) == 1 ? true : false,
                    VMRunning = rnd.Next(0, 2) == 1 ? true : false,
                    IPapipaAssigned = rnd.Next(0, 2) == 1 ? true : false
                };
                servers.Add(server);
            }
            return servers;
        }

    }
}
