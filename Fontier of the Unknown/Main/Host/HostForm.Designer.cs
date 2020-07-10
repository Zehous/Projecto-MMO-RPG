namespace Fontier_of_the_Unknown.Main.Host
{
    partial class HostForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ListBoxPlayers = new System.Windows.Forms.ListBox();
            this.BtnLoadStats = new System.Windows.Forms.Button();
            this.NumValorStats = new System.Windows.Forms.NumericUpDown();
            this.ComboBoxCategoryStats = new System.Windows.Forms.ComboBox();
            this.BtnAddStats = new System.Windows.Forms.Button();
            this.BtnHost = new System.Windows.Forms.Button();
            this.TextBoxServerIp = new System.Windows.Forms.TextBox();
            this.PanelStatus = new System.Windows.Forms.Panel();
            this.TimerUpdate = new System.Windows.Forms.Timer(this.components);
            this.PanelStatus2 = new System.Windows.Forms.Panel();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.LabelIP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumValorStats)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxPlayers
            // 
            this.ListBoxPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ListBoxPlayers.ForeColor = System.Drawing.Color.White;
            this.ListBoxPlayers.FormattingEnabled = true;
            this.ListBoxPlayers.Location = new System.Drawing.Point(12, 12);
            this.ListBoxPlayers.Name = "ListBoxPlayers";
            this.ListBoxPlayers.Size = new System.Drawing.Size(120, 329);
            this.ListBoxPlayers.TabIndex = 0;
            // 
            // BtnLoadStats
            // 
            this.BtnLoadStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnLoadStats.FlatAppearance.BorderSize = 0;
            this.BtnLoadStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoadStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadStats.Location = new System.Drawing.Point(173, 64);
            this.BtnLoadStats.Name = "BtnLoadStats";
            this.BtnLoadStats.Size = new System.Drawing.Size(168, 28);
            this.BtnLoadStats.TabIndex = 6;
            this.BtnLoadStats.Text = "Load Stats Player";
            this.BtnLoadStats.UseVisualStyleBackColor = false;
            this.BtnLoadStats.Visible = false;
            // 
            // NumValorStats
            // 
            this.NumValorStats.Location = new System.Drawing.Point(172, 132);
            this.NumValorStats.Name = "NumValorStats";
            this.NumValorStats.Size = new System.Drawing.Size(107, 20);
            this.NumValorStats.TabIndex = 7;
            this.NumValorStats.Visible = false;
            // 
            // ComboBoxCategoryStats
            // 
            this.ComboBoxCategoryStats.FormattingEnabled = true;
            this.ComboBoxCategoryStats.Location = new System.Drawing.Point(195, 98);
            this.ComboBoxCategoryStats.Name = "ComboBoxCategoryStats";
            this.ComboBoxCategoryStats.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxCategoryStats.TabIndex = 8;
            this.ComboBoxCategoryStats.Visible = false;
            // 
            // BtnAddStats
            // 
            this.BtnAddStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnAddStats.FlatAppearance.BorderSize = 0;
            this.BtnAddStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddStats.Location = new System.Drawing.Point(285, 126);
            this.BtnAddStats.Name = "BtnAddStats";
            this.BtnAddStats.Size = new System.Drawing.Size(66, 28);
            this.BtnAddStats.TabIndex = 9;
            this.BtnAddStats.Text = "Add";
            this.BtnAddStats.UseVisualStyleBackColor = false;
            this.BtnAddStats.Visible = false;
            // 
            // BtnHost
            // 
            this.BtnHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnHost.FlatAppearance.BorderSize = 0;
            this.BtnHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHost.Location = new System.Drawing.Point(264, 313);
            this.BtnHost.Name = "BtnHost";
            this.BtnHost.Size = new System.Drawing.Size(108, 28);
            this.BtnHost.TabIndex = 11;
            this.BtnHost.Text = "Start Server";
            this.BtnHost.UseVisualStyleBackColor = false;
            this.BtnHost.Click += new System.EventHandler(this.BtnHost_Click);
            // 
            // TextBoxServerIp
            // 
            this.TextBoxServerIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxServerIp.Location = new System.Drawing.Point(138, 319);
            this.TextBoxServerIp.Name = "TextBoxServerIp";
            this.TextBoxServerIp.Size = new System.Drawing.Size(120, 22);
            this.TextBoxServerIp.TabIndex = 10;
            // 
            // PanelStatus
            // 
            this.PanelStatus.BackColor = System.Drawing.Color.Red;
            this.PanelStatus.Location = new System.Drawing.Point(141, 12);
            this.PanelStatus.Name = "PanelStatus";
            this.PanelStatus.Size = new System.Drawing.Size(35, 35);
            this.PanelStatus.TabIndex = 13;
            // 
            // TimerUpdate
            // 
            this.TimerUpdate.Interval = 500;
            this.TimerUpdate.Tick += new System.EventHandler(this.TimerUpdate_Tick);
            // 
            // PanelStatus2
            // 
            this.PanelStatus2.BackColor = System.Drawing.Color.Red;
            this.PanelStatus2.Location = new System.Drawing.Point(337, 12);
            this.PanelStatus2.Name = "PanelStatus2";
            this.PanelStatus2.Size = new System.Drawing.Size(35, 35);
            this.PanelStatus2.TabIndex = 14;
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatus.Location = new System.Drawing.Point(182, 22);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(149, 16);
            this.LabelStatus.TabIndex = 15;
            this.LabelStatus.Text = "<= Status  Servers=>";
            // 
            // LabelIP
            // 
            this.LabelIP.AutoSize = true;
            this.LabelIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIP.Location = new System.Drawing.Point(135, 300);
            this.LabelIP.Name = "LabelIP";
            this.LabelIP.Size = new System.Drawing.Size(123, 16);
            this.LabelIP.TabIndex = 16;
            this.LabelIP.Text = "Ip Server: (Radmin)";
            // 
            // HostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.LabelIP);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.PanelStatus2);
            this.Controls.Add(this.PanelStatus);
            this.Controls.Add(this.BtnHost);
            this.Controls.Add(this.TextBoxServerIp);
            this.Controls.Add(this.BtnAddStats);
            this.Controls.Add(this.ComboBoxCategoryStats);
            this.Controls.Add(this.NumValorStats);
            this.Controls.Add(this.BtnLoadStats);
            this.Controls.Add(this.ListBoxPlayers);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "HostForm";
            this.Text = "HostForm";
            ((System.ComponentModel.ISupportInitialize)(this.NumValorStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxPlayers;
        private System.Windows.Forms.Button BtnLoadStats;
        private System.Windows.Forms.NumericUpDown NumValorStats;
        private System.Windows.Forms.ComboBox ComboBoxCategoryStats;
        private System.Windows.Forms.Button BtnAddStats;
        private System.Windows.Forms.Button BtnHost;
        private System.Windows.Forms.TextBox TextBoxServerIp;
        private System.Windows.Forms.Panel PanelStatus;
        private System.Windows.Forms.Timer TimerUpdate;
        private System.Windows.Forms.Panel PanelStatus2;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Label LabelIP;
    }
}