namespace Fontier_of_the_Unknown.Main.Client
{
    partial class Lobby
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnMini = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.TextBoxNomeLobby = new System.Windows.Forms.TextBox();
            this.BtnJoinLobby = new System.Windows.Forms.Button();
            this.TextBoxIP = new System.Windows.Forms.TextBox();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.ListBoxPlayers = new System.Windows.Forms.ListBox();
            this.TimerUpdate = new System.Windows.Forms.Timer(this.components);
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.PanelHeader.SuspendLayout();
            this.PanelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnMini
            // 
            this.BtnMini.BackColor = System.Drawing.Color.Black;
            this.BtnMini.FlatAppearance.BorderSize = 0;
            this.BtnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMini.Location = new System.Drawing.Point(711, 11);
            this.BtnMini.Name = "BtnMini";
            this.BtnMini.Size = new System.Drawing.Size(35, 30);
            this.BtnMini.TabIndex = 3;
            this.BtnMini.Text = "_";
            this.BtnMini.UseVisualStyleBackColor = false;
            this.BtnMini.Click += new System.EventHandler(this.BtnMini_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Black;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(753, 11);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(35, 30);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PanelHeader.Controls.Add(this.TextBoxNomeLobby);
            this.PanelHeader.Controls.Add(this.BtnJoinLobby);
            this.PanelHeader.Controls.Add(this.TextBoxIP);
            this.PanelHeader.Controls.Add(this.BtnMini);
            this.PanelHeader.Controls.Add(this.BtnClose);
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(800, 50);
            this.PanelHeader.TabIndex = 1;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            this.PanelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseMove);
            // 
            // TextBoxNomeLobby
            // 
            this.TextBoxNomeLobby.Location = new System.Drawing.Point(19, 30);
            this.TextBoxNomeLobby.Name = "TextBoxNomeLobby";
            this.TextBoxNomeLobby.Size = new System.Drawing.Size(115, 20);
            this.TextBoxNomeLobby.TabIndex = 7;
            this.TextBoxNomeLobby.Text = "Guest";
            // 
            // BtnJoinLobby
            // 
            this.BtnJoinLobby.BackColor = System.Drawing.Color.Black;
            this.BtnJoinLobby.FlatAppearance.BorderSize = 0;
            this.BtnJoinLobby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnJoinLobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJoinLobby.Location = new System.Drawing.Point(140, 11);
            this.BtnJoinLobby.Name = "BtnJoinLobby";
            this.BtnJoinLobby.Size = new System.Drawing.Size(100, 30);
            this.BtnJoinLobby.TabIndex = 5;
            this.BtnJoinLobby.Text = "Join Lobby";
            this.BtnJoinLobby.UseVisualStyleBackColor = false;
            this.BtnJoinLobby.Click += new System.EventHandler(this.BtnJoinLobby_Click);
            // 
            // TextBoxIP
            // 
            this.TextBoxIP.Location = new System.Drawing.Point(19, 3);
            this.TextBoxIP.Name = "TextBoxIP";
            this.TextBoxIP.Size = new System.Drawing.Size(115, 20);
            this.TextBoxIP.TabIndex = 6;
            // 
            // PanelContent
            // 
            this.PanelContent.Controls.Add(this.BtnUpdate);
            this.PanelContent.Controls.Add(this.ListBoxPlayers);
            this.PanelContent.Location = new System.Drawing.Point(20, 70);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(750, 356);
            this.PanelContent.TabIndex = 2;
            this.PanelContent.Visible = false;
            // 
            // ListBoxPlayers
            // 
            this.ListBoxPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ListBoxPlayers.ForeColor = System.Drawing.Color.White;
            this.ListBoxPlayers.FormattingEnabled = true;
            this.ListBoxPlayers.Location = new System.Drawing.Point(538, 6);
            this.ListBoxPlayers.Name = "ListBoxPlayers";
            this.ListBoxPlayers.Size = new System.Drawing.Size(206, 342);
            this.ListBoxPlayers.TabIndex = 0;
            // 
            // TimerUpdate
            // 
            this.TimerUpdate.Enabled = true;
            this.TimerUpdate.Interval = 500;
            this.TimerUpdate.Tick += new System.EventHandler(this.TimerUpdate_Tick);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Black;
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(432, 6);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(100, 30);
            this.BtnUpdate.TabIndex = 8;
            this.BtnUpdate.Text = "Atualizar";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.PanelHeader);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Lobby";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.Lobby_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.PanelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMini;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Button BtnJoinLobby;
        private System.Windows.Forms.TextBox TextBoxIP;
        private System.Windows.Forms.TextBox TextBoxNomeLobby;
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.ListBox ListBoxPlayers;
        private System.Windows.Forms.Timer TimerUpdate;
        private System.Windows.Forms.Button BtnUpdate;
    }
}
