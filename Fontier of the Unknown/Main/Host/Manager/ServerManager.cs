using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Fontier_of_the_Unknown.Main.Host.Manager
{
    class ServerManager
    {
        public string Status = null;
        public int ServerId = 1;
        public Socket socket = null;
        public string Ip = null;
        

        public ServerManager(string Ip, int Port)
        {
            Status = "Inicializando";
            try
            {
                this.Ip = Ip;
                IPAddress ipad = null;
                if (IPAddress.TryParse(Ip, out ipad))
                {
                    IPEndPoint ipep = new IPEndPoint(ipad, Port);

                    this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    this.socket.Bind(ipep);
                    this.socket.Listen(0);

                    Status = "Ligado";

                    this.socket.BeginAccept(WaitConnect, null);
                }
            }
            catch
            {
                Status = "Deligado Forçado";
            }
        }

        private void WaitConnect(IAsyncResult ar)
        {
            try
            {
                if (Status == "Ligado")
                {
                    Socket NewClient = this.socket.EndAccept(ar);
                    int newClientID = this.GetFreeClientId();
                    if (newClientID > -1)
                    {
                        Config.Sockets[newClientID] = new ClientManager(NewClient, newClientID);
                    }
                    else
                    {
                        NewClient.Close();
                        NewClient = null;
                    }
                }
            } finally {
                if (Status == "Ligado")
                {
                    this.socket.BeginAccept(WaitConnect, null);
                }
            }
        }

        private int GetFreeClientId()
        {
            try
            {
                if (Status == "Ligado")
                {
                    for (int i = 0; i < Config.Sockets.Length; i++)
                        if (Config.Sockets[i] == null)
                            return i;
                }
            }
            catch { }
            return -1;
        }

        public string GetPlayerList()
        {
            string Result = "";
            for (int i = 0; i < Config.Sockets.Length; i++)
            {
                if (Config.Sockets[i] != null)
                {
                    if (Config.Sockets[i].UserName != null)
                        Result += Config.Sockets[i].UserName;
                }
                else
                {
                    Result += "Vago. *";
                }
                Result += ",";
            }
            return Result;
        }
    }
}
