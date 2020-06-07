using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DanielFlooder.Clases
{
    public class Core
    {
        #region Packet 
        public static string PacketSends = "0x30 | %%300 | 0x31 | 0x32 | %%400";
        #endregion
        public static int PacketsSend = 0;
        public static List<Thread> Procesos = new List<Thread>();
    }
}
