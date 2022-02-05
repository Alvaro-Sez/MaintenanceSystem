using InfraMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS.Application.Processing.ProcessingMethods.NetworkProcessingMethods
{
    internal interface IGetAverageBandWith
    {
        int GetAverageBandWith(List<Server> serverList);
    }
}
