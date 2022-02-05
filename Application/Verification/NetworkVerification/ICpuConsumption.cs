using InfraMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS.Application.Verification.NetworkVerification
{
    public interface ICpuConsumption
    {
        /*•	La infraestructura está consumiendo en general menos del 80% de CPU */
        public double GetAverageCPU(List<Server> serverList);
    }
}
