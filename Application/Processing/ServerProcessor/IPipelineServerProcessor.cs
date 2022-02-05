using InfraMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS.Application
{
    internal interface IPipelineServerProcessor
    {
        List<Server>Filter(List<Server> serverList);
    }
}
