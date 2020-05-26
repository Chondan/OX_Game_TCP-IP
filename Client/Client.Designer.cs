namespace Client
{
    partial class Client
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
            this.ClientPortTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClientHostTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConnectBT = new System.Windows.Forms.Button();
            this.ClientChatTB = new System.Windows.Forms.TextBox();
            this.ClientSendBT = new System.Windows.Forms.Button();
            this.DisconnectBT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientNameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ClientScreenTB = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.PlayGameBT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientPortTb
            // 
            this.ClientPortTb.Location = new System.Drawing.Point(343, 39);
            this.ClientPortTb.Name = "ClientPortTb";
            this.ClientPortTb.Size = new System.Drawing.Size(158, 26);
            this.ClientPortTb.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Port";
            // 
            // ClientHostTB
            // 
            this.ClientHostTB.Location = new System.Drawing.Point(114, 39);
            this.ClientHostTB.Name = "ClientHostTB";
            this.ClientHostTB.Size = new System.Drawing.Size(158, 26);
            this.ClientHostTB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Host";
            // 
            // ConnectBT
            // 
            this.ConnectBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ConnectBT.Location = new System.Drawing.Point(527, 39);
            this.ConnectBT.Name = "ConnectBT";
            this.ConnectBT.Size = new System.Drawing.Size(115, 26);
            this.ConnectBT.TabIndex = 6;
            this.ConnectBT.Text = "CONNECT";
            this.ConnectBT.UseVisualStyleBackColor = true;
            this.ConnectBT.Click += new System.EventHandler(this.ConnectBT_Click);
            // 
            // ClientChatTB
            // 
            this.ClientChatTB.Enabled = false;
            this.ClientChatTB.Location = new System.Drawing.Point(114, 71);
            this.ClientChatTB.Multiline = true;
            this.ClientChatTB.Name = "ClientChatTB";
            this.ClientChatTB.Size = new System.Drawing.Size(527, 74);
            this.ClientChatTB.TabIndex = 11;
            // 
            // ClientSendBT
            // 
            this.ClientSendBT.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSendBT.Enabled = false;
            this.ClientSendBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ClientSendBT.Location = new System.Drawing.Point(526, 151);
            this.ClientSendBT.Name = "ClientSendBT";
            this.ClientSendBT.Size = new System.Drawing.Size(115, 26);
            this.ClientSendBT.TabIndex = 13;
            this.ClientSendBT.Text = "SEND";
            this.ClientSendBT.UseVisualStyleBackColor = false;
            this.ClientSendBT.Click += new System.EventHandler(this.ClientSendBT_Click);
            // 
            // DisconnectBT
            // 
            this.DisconnectBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.DisconnectBT.Location = new System.Drawing.Point(527, 183);
            this.DisconnectBT.Name = "DisconnectBT";
            this.DisconnectBT.Size = new System.Drawing.Size(115, 26);
            this.DisconnectBT.TabIndex = 14;
            this.DisconnectBT.Text = "Disconnect";
            this.DisconnectBT.UseVisualStyleBackColor = true;
            this.DisconnectBT.Click += new System.EventHandler(this.DisconnectBT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 15;
            // 
            // ClientNameTB
            // 
            this.ClientNameTB.Location = new System.Drawing.Point(114, 151);
            this.ClientNameTB.Name = "ClientNameTB";
            this.ClientNameTB.Size = new System.Drawing.Size(158, 26);
            this.ClientNameTB.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Name";
            // 
            // ClientScreenTB
            // 
            this.ClientScreenTB.Enabled = false;
            this.ClientScreenTB.Location = new System.Drawing.Point(114, 215);
            this.ClientScreenTB.Multiline = true;
            this.ClientScreenTB.Name = "ClientScreenTB";
            this.ClientScreenTB.Size = new System.Drawing.Size(527, 185);
            this.ClientScreenTB.TabIndex = 18;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(677, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(573, 600);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // PlayGameBT
            // 
            this.PlayGameBT.Location = new System.Drawing.Point(114, 420);
            this.PlayGameBT.Name = "PlayGameBT";
            this.PlayGameBT.Size = new System.Drawing.Size(527, 39);
            this.PlayGameBT.TabIndex = 20;
            this.PlayGameBT.Text = "PLAY GAME";
            this.PlayGameBT.UseVisualStyleBackColor = true;
            this.PlayGameBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Location = new System.Drawing.Point(287, 157);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(52, 20);
            this.PlayerLabel.TabIndex = 23;
            this.PlayerLabel.Text = "Player";
            this.PlayerLabel.TextChanged += new System.EventHandler(this.PlayerLabel_TextChanged);
            this.PlayerLabel.Click += new System.EventHandler(this.PlayerLabel_Click);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 570);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(677, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(573, 10);
            this.textBox1.TabIndex = 25;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 664);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PlayGameBT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ClientScreenTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClientNameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DisconnectBT);
            this.Controls.Add(this.ClientSendBT);
            this.Controls.Add(this.ClientChatTB);
            this.Controls.Add(this.ClientPortTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClientHostTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConnectBT);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ClientPortTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClientHostTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConnectBT;
        private System.Windows.Forms.TextBox ClientChatTB;
        private System.Windows.Forms.Button ClientSendBT;
        private System.Windows.Forms.Button DisconnectBT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClientNameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ClientScreenTB;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button PlayGameBT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
    }
}

