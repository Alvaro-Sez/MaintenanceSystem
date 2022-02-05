using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraMS.Domain
{
    public class Server
    {
        public DateTime RestartTime { get; set; }
        public DateTime ShutdownTime { get; set; }
        public int CPU { get; set; }
        public int Memory { get; set; }
        public int BandWidth { get; set; }
        public int DiskUsage { get; set; }
        public int FreeRAM { get; set; }
        public ServerEnum Type { get; set; }
        public bool BiosUpdated { get; set; }
        public bool ControllersInstalled { get; set; }
        public bool VMRunning { get; set; }
        public bool IPapipaAssigned { get; set; }
        public bool Scaled { get; set; } = false;


        


    }
}
