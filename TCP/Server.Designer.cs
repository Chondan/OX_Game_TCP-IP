namespace TCP
{
    partial class Server
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
            this.StartBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ServerHostTB = new System.Windows.Forms.TextBox();
            this.ServerPortTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StopBT = new System.Windows.Forms.Button();
            this.ServerChatTB = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ALabel = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.StartGameBT = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartBT
            // 
            this.StartBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StartBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.StartBT.Location = new System.Drawing.Point(518, 37);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(75, 26);
            this.StartBT.TabIndex = 0;
            this.StartBT.Text = "START";
            this.StartBT.UseVisualStyleBackColor = false;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host";
            // 
            // ServerHostTB
            // 
            this.ServerHostTB.Location = new System.Drawing.Point(105, 37);
            this.ServerHostTB.Name = "ServerHostTB";
            this.ServerHostTB.Size = new System.Drawing.Size(158, 26);
            this.ServerHostTB.TabIndex = 2;
            // 
            // ServerPortTb
            // 
            this.ServerPortTb.Location = new System.Drawing.Point(334, 37);
            this.ServerPortTb.Name = "ServerPortTb";
            this.ServerPortTb.Size = new System.Drawing.Size(158, 26);
            this.ServerPortTb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // StopBT
            // 
            this.StopBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.StopBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.StopBT.Location = new System.Drawing.Point(598, 37);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(75, 26);
            this.StopBT.TabIndex = 5;
            this.StopBT.Text = "STOP";
            this.StopBT.UseVisualStyleBackColor = false;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // ServerChatTB
            // 
            this.ServerChatTB.Enabled = false;
            this.ServerChatTB.Location = new System.Drawing.Point(105, 88);
            this.ServerChatTB.Multiline = true;
            this.ServerChatTB.Name = "ServerChatTB";
            this.ServerChatTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ServerChatTB.Size = new System.Drawing.Size(570, 315);
            this.ServerChatTB.TabIndex = 6;
            this.ServerChatTB.TextChanged += new System.EventHandler(this.ServerChatTB_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "#client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(13, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(82, 264);
            this.listBox1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(733, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(573, 600);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.BackgroundImageChanged += new System.EventHandler(this.pictureBox1_BackgroundImageChanged);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.Location = new System.Drawing.Point(71, 483);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(52, 20);
            this.ALabel.TabIndex = 11;
            this.ALabel.Text = "TurnA";
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Location = new System.Drawing.Point(557, 483);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(52, 20);
            this.BLabel.TabIndex = 12;
            this.BLabel.Text = "TurnB";
            // 
            // StartGameBT
            // 
            this.StartGameBT.Location = new System.Drawing.Point(180, 476);
            this.StartGameBT.Name = "StartGameBT";
            this.StartGameBT.Size = new System.Drawing.Size(312, 72);
            this.StartGameBT.TabIndex = 13;
            this.StartGameBT.Text = "START OX";
            this.StartGameBT.UseVisualStyleBackColor = true;
            this.StartGameBT.Click += new System.EventHandler(this.StartGameBT_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 515);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Player A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(550, 515);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Player B";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(33, 538);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 10);
            this.textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Blue;
            this.textBox2.Location = new System.Drawing.Point(518, 538);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 10);
            this.textBox2.TabIndex = 18;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 656);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StartGameBT);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.ALabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ServerChatTB);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.ServerPortTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ServerHostTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartBT);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerHostTB;
        private System.Windows.Forms.TextBox ServerPortTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StopBT;
        private System.Windows.Forms.TextBox ServerChatTB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.Button StartGameBT;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

