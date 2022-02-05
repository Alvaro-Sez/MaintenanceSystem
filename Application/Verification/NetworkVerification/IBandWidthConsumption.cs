using InfraMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS.Application.Verification.NetworkVerification
{
    public interface IBandWidthConsumption 
    {
        /*El ancho de banda consumido en la infraestructura es menor que 500 Gb/s*/
        public double GetAverageBandWidth(List<Server> serverList);
    }
}
