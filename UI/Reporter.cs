using InfraMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS.UI
{
    public static class Reporter
    {
    public static void report(this NetworkState networkState)
        {
            Console.WriteLine("\nNetwork State:\n");
            Console.WriteLine($"General CPU Consumption: {networkState.CPU}%");
            Console.WriteLine($"General DataServers FreeRAM: {networkState.DataServersFreeRAM}%");
            Console.WriteLine($"General BandWith Consumption: {networkState.BandWith}%");
        }

        public static void report(this List<Server> serverList)
        {
            Console.WriteLine("\n\n\nNetwork Server List");
        foreach (Server server in serverList)
            {

                Console.WriteLine($"\n---------Id: {server.Id} ---------");
                Console.WriteLine($"CPU: {server.CPU}");
                Console.WriteLine($"FreeRAM: {server.FreeRAM}");
                Console.WriteLine($"DiskUsage:{server.DiskUsage}");
                Console.WriteLine($"BandWidth:{server.BandWidth}");
                Console.WriteLine($"Type:{server.Type}");
                Console.WriteLine($"Shutdown dateTime: {server.ShutdownTime}");
                Console.WriteLine($"Restart dateTime: {server.RestartTime}");
                Console.WriteLine($"Scaled: {server.Scaled}");
                Console.WriteLine($"BiosUpdated: {server.BiosUpdated}");
                Console.WriteLine($"ControllersInstalled: {server.ControllersInstalled}");
                Console.WriteLine($"VMRunning: {server.VMRunning}");
                Console.WriteLine($"IPapipaAssigned: {server.IPapipaAssigned}\n");
            }

        }

    }
}
