using InfraMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS.Application.Verification.NetworkVerification
{
    public interface INetworkVerification: ICpuConsumption, IDataServersRAMConsumption, IBandWidthConsumption
    {
        
    }
}
