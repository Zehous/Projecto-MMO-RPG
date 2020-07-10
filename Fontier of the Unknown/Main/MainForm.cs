using Fontier_of_the_Unknown.Main.Host;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fontier_of_the_Unknown.Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Panel Header
        Point LastPoint;

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void PanelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        #endregion

        private void BtnSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Criador do Programa => Zehous <=", "Criador Do Programa");
        }

        private void BtnJoinLobby_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            Client.Lobby Control = new Client.Lobby();
            Control.Location = new Point(0, 0);
            this.Controls.Add(Control);
        }

        private void BtnHostLobby_Click(object sender, EventArgs e)
        {
            HostForm Menu = new HostForm();
            Menu.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Client.Config.form = this;
        }

        public static void HostOpen()
        {
            Client.Config.form.Controls.Clear();

            Client.Lobby Control = new Client.Lobby();
            Control.Location = new Point(0, 0);
            Client.Config.form.Controls.Add(Control);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Client.Config.Client != null)
            {
                Client.Config.Client.socket.Close();
            }
        }
    }
}
