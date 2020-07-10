using Fontier_of_the_Unknown.Main.Host.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fontier_of_the_Unknown.Main.Host
{
    public partial class HostForm : Form
    {
        public HostForm()
        {
            InitializeComponent();
        }

        private void BtnHost_Click(object sender, EventArgs e)
        {
            Config.Ips[1] = TextBoxServerIp.Text;

            for (int i = 0; i < Config.Ips.Length; i++)
                Config.Servers[i] = new ServerManager(Config.Ips[i], Config.Port);

            LabelIP.Visible = false;
            BtnHost.Visible = false;
            TextBoxServerIp.Visible = false;

            TimerUpdate.Enabled = true;
            BtnLoadStats.Visible = true;
            BtnAddStats.Visible = true;
            NumValorStats.Visible = true;
            ComboBoxCategoryStats.Visible = true;

            Client.Config.HostIp = "127.0.0.1";
            MainForm.HostOpen();
        }

        private void TimerUpdate_Tick(object sender, EventArgs e)
        {
            int StatusClients = 0;

            if (Config.Servers[0].Status == "Ligado") PanelStatus.BackColor = Color.Lime;
            if (Config.Servers[1].Status == "Ligado") PanelStatus2.BackColor = Color.Lime;

            if (Config.Servers[0].Status != "Ligado") PanelStatus.BackColor = Color.Red;
            if (Config.Servers[1].Status != "Ligado") PanelStatus2.BackColor = Color.Red;

            ListBoxPlayers.Items.Clear();
            for (int i = 0; i < Config.Sockets.Length; i++)
            {
                if (Config.Sockets[i] != null)
                {
                    StatusClients++;
                    if (Config.Sockets[i].UserName != null)
                        ListBoxPlayers.Items.Add(Config.Sockets[i].UserName);
                }
                else
                {
                    ListBoxPlayers.Items.Add("Vago. *");
                }
            }
        }
    }
}
