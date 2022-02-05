using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS.Application.Verification.ServerVerification
{
    public class VerificatorsContainer
    {
        private List<IServerVerification> _verificators;

        
        void Add (IServerVerification serverVerification) { _verificators.Add (serverVerification);}

    }
}
