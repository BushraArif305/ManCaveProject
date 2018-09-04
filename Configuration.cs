using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManCaveLeague
{
    public static class Configuration
    {
        public static User User { get; set; }
        static string ip = "192.168.0.216";
        public static string SystemIp
        { get { return ip; } }
        public static void KillMediaPlayerProcess()
        {
            Process[] processes = Process.GetProcessesByName("MediaPlayerControl");
            if (processes.Length > 0)
            {
                int length = processes.Length;
                for (int i = 0; i < length; i++)
                {
                    try
                    {
                        processes[i].Kill();
                    }
                    catch { }
                }
            }
        }
    }
    
}
