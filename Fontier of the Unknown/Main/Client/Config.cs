using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fontier_of_the_Unknown.Main.Client
{
    class Config
    {
        public static int Port = 666;
        public static Form form = null;
        public static string HostIp = null;

        public static Manager.ClientManager Client = null;
        public static string[] ListUsers = new string[1];
    }
}
