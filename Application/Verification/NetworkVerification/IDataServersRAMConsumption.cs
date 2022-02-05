using InfraMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS.Application.Verification.NetworkVerification
{
    public interface IDataServersRAMConsumption
    {
        /*Los servidores de base de datos consumen de media menos del 90% de RAM*/
        public double GetDataServersAverageRAM(List<Server> serverList);
        
    }
}
