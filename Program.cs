using Autofac;
using InfraMS.Application;
using InfraMS.Application.Verification.NetworkVerification;
using InfraMS.Data;
using InfraMS.Domain;
using System;
using System.Collections.Generic;

namespace InfraMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<INetworkDataService>().As<AmazonNetworkData>();
            
        }
    }
}
