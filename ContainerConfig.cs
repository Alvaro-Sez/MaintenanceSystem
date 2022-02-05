using Autofac;
using InfraMS.Application.Processing.NetworkProcessor;
using InfraMS.Application.Processing.ProcessingMethods.ServerProcessingMethods;
using InfraMS.Application.Processing.ServerProcessor;
using InfraMS.Application.Verification.NetworkVerification;
using InfraMS.Application.Verification.ServerVerification;
using InfraMS.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            /*DataService*/
            builder.RegisterType<AmazonNetworkService>().As<INetworkService>();
            
            /*ServerVerifications*/
            builder.RegisterType<BIOSUpdated>().As<IServerVerification>();
            builder.RegisterType<ControllersInstalled>().As<IServerVerification>();
            builder.RegisterType<CPUServerConsumption>().As<IServerVerification>();
            builder.RegisterType<DataConsumption>().As<IServerVerification>();
            builder.RegisterType<HasIPapipa>().As<IServerVerification>();
            builder.RegisterType<RamApplicationConsumption>().As<IServerVerification>();
            builder.RegisterType<VMRunning>().As<IServerVerification>();

            /*ServerProcessor*/
            builder.RegisterType<ProcessorServerManager>().As<IProcessorServerMethods>();
            builder.RegisterType<PipelineServerProcessor>().As<IPipelineServerProcessor>();

            /*Network verification*/
            builder.RegisterType<NetworkVerification>().As<INetworkVerification>();

            /*Netwok processor*/
            builder.RegisterType<NetworkStateManager>().As<INetworkStateManager>();

            return builder.Build();
        }
    }
}
