using Fontier_of_the_Unknown.Main.Host.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fontier_of_the_Unknown.Main.Host
{
    class Config
    {
        public static string[] Ips = {
            "127.0.0.1",
            "0.0.0.0"
        };
        public static int Port = 666;

        public static int MaxSlots = 5;
        public static ClientManager[] Sockets = new ClientManager[MaxSlots];
        public static ServerManager[] Servers = new ServerManager[Ips.Length];
    }

    public class SocketSendList
    {
        public string TxT { get; set; }

        public string GetInfoString()
        {
            return $"{TxT}";
        }
    }
}
