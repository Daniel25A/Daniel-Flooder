using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielFlooder.Clases
{
    public class ConsoleSettings
    {
        public static string WelcomeTitle = @"            
._____________   _______   ____ ___ ____  __.____  __.___________________   
|   \______   \  \      \ |    |   \    |/ _|    |/ _|\_   _____/\______ \  
|   ||     ___/  /   |   \|    |   /      < |      <   |    __)_  |    |  \ 
|   ||    |     /    |    \    |  /|    |  \|    |  \  |        \ |    `   \
|___||____|     \____|__  /______/ |____|__ \____|__ \/_______  //_______  /
                        \/                 \/       \/        \/         \/                                                                     
";
        public static string ConsoleTitle = "UDP FLOOD | ADVANCED IP FLOOD | UDP FLOOD";
        public static string MsgEnterIP = "ENTER EL IP: ";
        public static string MsgInvalidIP = "INVALID IP PROVIDER";
        public static string MsgInvalidThredNumbers = "INVALID THREADS NUMBERS";
        public static string MsgEnterThreads = "ENTER THE AMMOUNT OF THREADS: ";
        public static string MsgEnterPort = "ENTER THE PORT NUMBER: ";
        public static string MsgAttackIP = "%value% PACKETS SEND TO THE IP %ip% | PORT NUMBER %port%";
        public static string MsgInvalidPort = "THE ENTERED PORT IS NOT VALID";
    }
}
