using Autofac;
using InfraMS.Application.Processing.NetworkProcessor;
using InfraMS.Application.Processing.ServerProcessor;
using InfraMS.Domain;
using InfraMS.Infraestructure;
using InfraMS.UI;
using System;
using System.Collections.Generic;

namespace InfraMS
{
    public class Program
    {
        static void Main(string[] args)
        {

            var build = ContainerConfig.Configure();

            var amazonData = build.Resolve<INetworkService>();
            var networkStateManager = build.Resolve<INetworkStateManager>();
            var verificationPipeline = build.Resolve<IPipelineServerProcessor>();
            
            List<Server> serverList = amazonData.GetServers();

            
            NetworkState networkState = networkStateManager.GetGeneralState(serverList);
            
            Console.WriteLine("-------------Before Processment Pipeline-------------");
            networkState.report();

            List<Server> serverFilteredList = verificationPipeline.Filter(serverList);
            NetworkState networkFilteredState = networkStateManager.GetGeneralState(serverFilteredList);
            
            Console.WriteLine("\n-------------After Processment Pipeline-------------");
            networkFilteredState.report();
            //serverFilteredList.report();
        }
    }
}
