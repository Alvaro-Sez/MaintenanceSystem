using InfraMS.Application.Processing.ProcessingMethods;
using InfraMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS.Application.Verification.ServerVerification
{
    public interface IServerVerification 
    {
        public ProcessingMethodEnum Verificate(Server server);
    }
}
