using InfraMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS.Data
{
    public interface INetworkDataService
    {
        public List<Server> GetServers();
    }
}
