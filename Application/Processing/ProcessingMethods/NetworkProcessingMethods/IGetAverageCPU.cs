using InfraMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS.Application.Processing.ProcessingMethods.NetworkProcessingMethods
{
    internal interface IGetAverageCPU
    {
        int GetAverageCPU(List<Server> serverList);

    }
}
