namespace Fontier_of_the_Unknown.Main
{
    partial class MainForm
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
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.BtnMini = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.PanelHeader2 = new System.Windows.Forms.Panel();
            this.LabelTItle = new System.Windows.Forms.Label();
            this.BtnJoinLobby = new System.Windows.Forms.Button();
            this.BtnHostLobby = new System.Windows.Forms.Button();
            this.BtnSobre = new System.Windows.Forms.Button();
            this.PanelHeader.SuspendLayout();
            this.PanelHeader2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PanelHeader.Controls.Add(this.BtnMini);
            this.PanelHeader.Controls.Add(this.BtnClose);
            this.PanelHeader.Location = new System.Drawing.Point(200, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(600, 50);
            this.PanelHeader.TabIndex = 0;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            this.PanelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseMove);
            // 
            // BtnMini
            // 
            this.BtnMini.BackColor = System.Drawing.Color.Black;
            this.BtnMini.FlatAppearance.BorderSize = 0;
            this.BtnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMini.Location = new System.Drawing.Point(512, 12);
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
            this.BtnClose.Location = new System.Drawing.Point(553, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(35, 30);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // PanelHeader2
            // 
            this.PanelHeader2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PanelHeader2.Controls.Add(this.LabelTItle);
            this.PanelHeader2.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader2.Name = "PanelHeader2";
            this.PanelHeader2.Size = new System.Drawing.Size(200, 125);
            this.PanelHeader2.TabIndex = 1;
            // 
            // LabelTItle
            // 
            this.LabelTItle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTItle.Location = new System.Drawing.Point(0, 27);
            this.LabelTItle.Name = "LabelTItle";
            this.LabelTItle.Size = new System.Drawing.Size(200, 62);
            this.LabelTItle.TabIndex = 0;
            this.LabelTItle.Text = "Games Center\r\n  By: Zehous\r\n";
            this.LabelTItle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnJoinLobby
            // 
            this.BtnJoinLobby.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnJoinLobby.FlatAppearance.BorderSize = 0;
            this.BtnJoinLobby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnJoinLobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJoinLobby.Location = new System.Drawing.Point(206, 56);
            this.BtnJoinLobby.Name = "BtnJoinLobby";
            this.BtnJoinLobby.Size = new System.Drawing.Size(150, 50);
            this.BtnJoinLobby.TabIndex = 4;
            this.BtnJoinLobby.Text = "Join Lobby";
            this.BtnJoinLobby.UseVisualStyleBackColor = false;
            this.BtnJoinLobby.Click += new System.EventHandler(this.BtnJoinLobby_Click);
            // 
            // BtnHostLobby
            // 
            this.BtnHostLobby.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnHostLobby.FlatAppearance.BorderSize = 0;
            this.BtnHostLobby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHostLobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHostLobby.Location = new System.Drawing.Point(362, 56);
            this.BtnHostLobby.Name = "BtnHostLobby";
            this.BtnHostLobby.Size = new System.Drawing.Size(150, 50);
            this.BtnHostLobby.TabIndex = 5;
            this.BtnHostLobby.Text = "Host Lobby";
            this.BtnHostLobby.UseVisualStyleBackColor = false;
            this.BtnHostLobby.Click += new System.EventHandler(this.BtnHostLobby_Click);
            // 
            // BtnSobre
            // 
            this.BtnSobre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnSobre.FlatAppearance.BorderSize = 0;
            this.BtnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSobre.Location = new System.Drawing.Point(518, 56);
            this.BtnSobre.Name = "BtnSobre";
            this.BtnSobre.Size = new System.Drawing.Size(150, 50);
            this.BtnSobre.TabIndex = 6;
            this.BtnSobre.Text = "Sobre";
            this.BtnSobre.UseVisualStyleBackColor = false;
            this.BtnSobre.Click += new System.EventHandler(this.BtnSobre_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSobre);
            this.Controls.Add(this.BtnHostLobby);
            this.Controls.Add(this.BtnJoinLobby);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.PanelHeader2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Panel PanelHeader2;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnMini;
        private System.Windows.Forms.Label LabelTItle;
        private System.Windows.Forms.Button BtnJoinLobby;
        private System.Windows.Forms.Button BtnHostLobby;
        private System.Windows.Forms.Button BtnSobre;
    }
}