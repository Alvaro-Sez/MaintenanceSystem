using InfraMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS.Infraestructure
{
    public interface INetworkService
    {
        public List<Server> GetServers();
    }
}
