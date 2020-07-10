using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fontier_of_the_Unknown.Main.Host.Manager
{
    class ClientManager
    {
        public Socket socket = null;
        public int ClientID = 0;
        public string UserName = null;

        private byte[] Buffer = null;
        Thread Th = null;

        public List<SocketSendList> WaitSend = new List<SocketSendList>();

        public ClientManager(Socket Client, int ClientID)
        {
            try
            {
                this.socket = Client;
                this.ClientID = ClientID;

                this.Buffer = new Byte[4000];

                this.socket.BeginReceive(this.Buffer, 0, this.Buffer.Length, SocketFlags.None, WaitData, null);
                Thread Th = new Thread(new ThreadStart(WaitSendRequest));
                Th.Start();
                this.Th = Th;
            }
            catch { }
        }

        private void WaitData(IAsyncResult ar)
        {
            try
            {
                if (socket != null)
                {
                    int size = this.socket.EndReceive(ar);
                    if (size > 0)
                    {
                        Array.Resize(ref this.Buffer, size);
                        string TxT = Encoding.UTF8.GetString(this.Buffer);

                        if (UserName == null)
                        {
                            UserName = TxT;
                            string Update = GetPlayerList();
                            for (int i = 0; i < Config.Sockets.Length; i++)
                            {
                                if (Config.Sockets[i] != null)
                                {
                                    Config.Sockets[i].WaitSend.Add(new SocketSendList() { TxT = "ListUsers," + Update });
                                    Debug.WriteLine($"Socket: {i} | sending: ListUsers,{Update}");
                                }
                            }
                            //socket.Send(Encoding.UTF8.GetBytes("ListUsers," + GetPlayerList()));
                        }

                        if(TxT.Contains(','))
                        {
                            string[] Split = TxT.Split(',');

                            switch(Split[0])
                            {
                                case ("UpdateList"):
                                    socket.Send(Encoding.UTF8.GetBytes("ListUsers," + GetPlayerList()));
                                    break;
                                case ("Close"):
                                    Close(ref socket, ClientID);
                                    break;
                            }
                        }
                    }
                }  
            }
            catch 
            {
                Close(ref socket, ClientID);
            }
            finally
            {
                try
                {
                    if(socket != null)
                    {
                        this.Buffer = new Byte[4000];
                        this.socket.BeginReceive(this.Buffer, 0, this.Buffer.Length, SocketFlags.None, WaitData, null);
                    }
                }
                catch  { }
            }
        }

        private void WaitSendRequest()
        {
            try
            {
                //Debug.WriteLine($"Socket: {ClientID} | WaitToSend: {WaitSend.Count}");
                if (WaitSend.Count > 0)
                {
                    Debug.WriteLine("Send");
                    for (int i = 0; i < WaitSend.Count; i++)
                    {
                        if (WaitSend[i].TxT != null)
                        {
                            socket.Send(Encoding.UTF8.GetBytes(WaitSend[i].TxT));
                            WaitSend.Remove(WaitSend[i]);
                        }
                    }
                }
                Thread.Sleep(500);
            }
            finally
            {
                WaitSendRequest();
            }
        }

        public void Close(ref Socket socket, int ClientID)
        {
            socket.Close();
            socket = null;
            Config.Sockets[ClientID] = null;

            Th.Abort();

            string Update = GetPlayerList();
            for (int i = 0; i < Config.Sockets.Length; i++)
            {
                if (Config.Sockets[i] != null)
                {
                    Config.Sockets[i].WaitSend.Add(new SocketSendList() { TxT = "ListUsers," + Update });
                    Debug.WriteLine($"Socket: {i} | sending: ListUsers,{Update}");
                }
            }
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
