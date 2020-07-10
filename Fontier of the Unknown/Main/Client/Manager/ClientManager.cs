using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fontier_of_the_Unknown.Main.Client.Manager
{
    class ClientManager
    {
        public Socket socket = null;
        private byte[] Buffer = null;

        public ClientManager(Socket Client)
        {
            try
            {
                this.socket = Client;
                this.Buffer = new Byte[4000];
                this.socket.BeginReceive(this.Buffer, 0, this.Buffer.Length, SocketFlags.None, WaitData, null);
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

                        if(TxT.Contains(','))
                        {
                            string[] Split = TxT.Split(',');

                            switch (Split[0])
                            {
                                case ("Update"):
                                    break;
                                case ("ListUsers"):
                                    Array.Resize(ref Config.ListUsers, Split.Length - 1);
                                    
                                    for (int i = 1; i < Split.Length; i++)
                                        Config.ListUsers[i-1] = Split[i];
                                    break;
                                case ("Change"):
                                    break;
                            }
                        }
                    }
                }
            }
            catch
            {
                Close(ref socket);
            }
            finally
            {
                try
                {
                    if (socket != null)
                    {
                        this.Buffer = new Byte[4000];
                        this.socket.BeginReceive(this.Buffer, 0, this.Buffer.Length, SocketFlags.None, WaitData, null);
                    }
                }
                catch { }
            }
        }

        private static void Close(ref Socket socket)
        {
            if(socket != null)
            {
                socket.Send(Encoding.UTF8.GetBytes("Close,now"));
                socket.Close();
                socket = null;
            }
        }
    }
}
