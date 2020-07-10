using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

namespace Fontier_of_the_Unknown.Main.Client
{
    public partial class Lobby : UserControl
    {
        public Lobby()
        {
            InitializeComponent();
        }

        #region Panel Header
        Point LastPoint;

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Config.form.Close();
        }

        private void BtnMini_Click(object sender, EventArgs e)
        {
            Config.form.WindowState = FormWindowState.Minimized;
        }

        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void PanelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Config.form.Left += e.X - LastPoint.X;
                Config.form.Top += e.Y - LastPoint.Y;
            }
        }

        #endregion

        private void BtnJoinLobby_Click(object sender, EventArgs e)
        {
            if (Connect(TextBoxIP.Text, TextBoxNomeLobby.Text))
            {
                BtnJoinLobby.Visible = false;
                TextBoxIP.Visible = false;
                TextBoxNomeLobby.Visible = false;

                Config.HostIp = TextBoxIP.Text;
                PanelContent.Visible = true;
            }
            else
            {
                BtnJoinLobby.ForeColor = Color.Red;
            }
        }

        private void Lobby_Load(object sender, EventArgs e)
        {
            if (Config.HostIp != null)
            {
                TextBoxIP.Text = Config.HostIp;
                TextBoxNomeLobby.Text = "Host";
                BtnJoinLobby_Click(sender, e);
            }
        }

        public static bool Connect(string Ip, string UserName)
        {
            try
            {
                var Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint connect = new IPEndPoint(IPAddress.Parse(Ip), Config.Port);
                Client.Connect(connect);

                byte[] Buffer = Encoding.UTF8.GetBytes(UserName);
                Client.Send(Buffer);

                Config.Client = new Manager.ClientManager(Client);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void UpdateListPlayers(ListBox ListBoxPlayers)
        {
            if (Config.ListUsers[0] != null)
            {
                ListBoxPlayers.Items.Clear();
                for (int i = 0; i < Config.ListUsers.Length; i++)
                {
                    ListBoxPlayers.Items.Add(Config.ListUsers[i]);
                }
            }
        }

        private void TimerUpdate_Tick(object sender, EventArgs e)
        {
            UpdateListPlayers(ListBoxPlayers);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Config.Client.socket.Send(Encoding.UTF8.GetBytes("UpdateList,now"));
        }
    }
}
