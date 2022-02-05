using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS.Application.Verification.ServerVerification
{
    public class VerificatorsContainer
    {
        private List<IServerVerification> _verificators = new List<IServerVerification>();

        VerificatorsContainer()
        {
            _verificators.Add(new BIOSUpdated());
            _verificators.Add(new ControllersInstalled());
            _verificators.Add(new CPUServerConsumption());
            _verificators.Add(new DataConsumption());
            _verificators.Add(new HasIPapipa());
            _verificators.Add(new RamApplicationConsumption());
            _verificators.Add(new VMRunning());
        }

        public List<IServerVerification> InjectVerificationList()
        { 
            return _verificators;
        }
    }
}
