using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
namespace Client
{
    public partial class Client : Form
    {
       
        public Client()
        {
            InitializeComponent();
        }
        
        NetworkStream netStream = null;

        class client_class
        {
            public string client_name;
            public string client_message;

        }
        List<client_class> client_list = new List<client_class>();
        int chk;
        public void ConnectBT_Click(object sender, EventArgs e)
        {
            

            if (ClientNameTB.Text != "")
            {
                ClientNameTB.Enabled = false;
                try
                {

                    TcpClient myclient = new TcpClient();
                    myclient.Connect(IPAddress.Parse(ClientHostTB.Text), Convert.ToInt32(ClientPortTb.Text));                 
                    netStream = myclient.GetStream();                   
                    Byte[] sendBytes = Encoding.UTF8.GetBytes(ClientNameTB.Text);
                    netStream.Write(sendBytes, 0, sendBytes.Length);                
                    label3.Text = "Connected";
                    ConnectBT.Enabled = false;
                    //timer1.Start();
                    timer2.Start();
                    chk = 1;
                }
                catch
                {
                    MessageBox.Show("no server");
                }
            }
            else
            {
                MessageBox.Show("Please insert your name");
            }         
        }
        private void ClientSendBT_Click(object sender, EventArgs e)
        {           
            if (netStream == null) return;
            if (netStream.CanWrite)
            {
                client_class tmp = new client_class();
                client_list.Clear();
                tmp.client_name = ClientNameTB.Text;
                tmp.client_message = ClientChatTB.Text;
                client_list.Add(tmp);
                foreach (var clnt in client_list)
                {                
                    Byte[] sendBytes = Encoding.UTF8.GetBytes(tmp.client_name + "\r\n" + ClientChatTB.Text + "\r\n");
                    netStream.Write(sendBytes, 0, sendBytes.Length);
                }             
            }
            ClientChatTB.Text = "";        
        }
        private void ClientScreenTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ClientSendBT_Click(this, null);
                ClientChatTB.Text = "";
            }
        }
        private void DisconnectBT_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timer1.Stop();
            netStream.Dispose();
            ClientNameTB.Enabled = true;
            ConnectBT.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //ClientScreenTB.Text = "";
            if (netStream.DataAvailable)
            {
                byte[] bytes = new byte[256];
                netStream.ReadAsync(bytes, 0, 256);
                string returndata = Encoding.UTF8.GetString(bytes);
                ClientScreenTB.Text = returndata;
            }
            timer1.Stop();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {   
        }
        private void timer2_Tick(object sender, EventArgs e)
        {  
            if (netStream.DataAvailable)
            {
                byte[] bytes = new byte[256];
                netStream.ReadAsync(bytes, 0, 256);
                string returndata = Encoding.UTF8.GetString(bytes);               
                PlayerLabel.Text = returndata;
                timer2.Stop();
                //timer1.Start();
            }
        }
        int board_size = 3;
        int margin_left = 10;
        int margin_top = 10;
        int tile_width = 20;
        //int turn = 1;
        int[,] board;
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            tile_width = (pictureBox1.Width - (2 * margin_left)) / board_size;

            for (int i = 0; i <= board_size; i++)
            {
                g.DrawLine(Pens.Black, margin_left + i * tile_width, margin_top
                    , margin_left + i * tile_width, margin_top + board_size * tile_width);

                g.DrawLine(Pens.Black, margin_left, margin_top + i * tile_width
                    , margin_left + tile_width * board_size, margin_top + i * tile_width

                    );
            }
            if (start == 1)
            {
                for (int row = 0; row < board_size; row++)
                    for (int col = 0; col < board_size; col++)
                    {
                        Brush b;
                        if (board[row, col] == 1)
                        {
                            b = Brushes.Red;
                        }
                        else if (board[row,col]==0)
                        {
                            b = Brushes.White;
                        }
                        else
                        {
                            b = Brushes.Blue;
                        }                     
                        if (board[row, col] != 0)
                        {
                            g.FillEllipse(b, margin_left + col * tile_width, margin_top + row * tile_width
                                , tile_width, tile_width);
                        }

                    }
            }          
        }            
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        int start;
        int pos;
        int turn = 0;
        int press;
        private void button1_Click(object sender, EventArgs e)
        {
            if (chk == 1)
            {
                PlayGameBT.BackColor = Color.LimeGreen;
                checkfull = 0;
                start = 1;
                press = 1;
                board = new int[board_size, board_size];
                if (PlayerLabel.Text == "A")
                {
                    pos = 1;
                    //turn = 1;
                }
                if (PlayerLabel.Text == "B")
                {
                    pos = -1;
                    //turn = 0;
                }

                for (int row = 0; row < board_size; row++)
                    for (int col = 0; col < board_size; col++)
                    {
                        board[row, col] = 0;
                    }
                //board[1, 2] = 1;
                //board[0, 1] = -1;
                Refresh();
            }
            else
            {
                MessageBox.Show("Please connect to the server");
            }
        }           
        int check;     
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {      
            int row = (e.Y - margin_top) / tile_width;
            int col = (e.X - margin_left) / tile_width;
            if (press == 1)
            {
                judge();
                int full = 0;
                for (int roww = 0; roww < board_size; roww++)
                    for (int coll = 0; coll < board_size; coll++)
                    {
                        if (board[roww, coll] != 0)
                        {
                            full += 1;
                        }
                    }
                if (checkfull != 1 && full != 9)
                {
                    if (turn == 1 && PlayerLabel.Text == "B")
                    {
                        if (board[row, col] != 1 && board[row, col] != -1)
                        {
                            board[row, col] = pos;
                            Byte[] sendBytes = Encoding.UTF8.GetBytes("B" + "\r\n" + row + "\r\n" + col);
                            netStream.Write(sendBytes, 0, sendBytes.Length);
                        }
                    }
                    else if (turn == 0 && PlayerLabel.Text == "A")
                    {
                        if (board[row, col] != 1 && board[row, col] != -1)
                        {
                            board[row, col] = pos;
                            Byte[] sendBytes = Encoding.UTF8.GetBytes("A" + "\r\n" + row + "\r\n" + col);
                            netStream.Write(sendBytes, 0, sendBytes.Length);
                        }
                    }
                    else
                    {
                        MessageBox.Show("It's not your turn");
                    }
                    //if (PlayerLabel.Text == "A")
                    //{
                    //    Byte[] sendBytes = Encoding.UTF8.GetBytes("A" + "\r\n" + row + "\r\n" + col);
                    //    netStream.Write(sendBytes, 0, sendBytes.Length);


                    //}
                    //if (PlayerLabel.Text == "B")
                    //{
                    //    Byte[] sendBytes = Encoding.UTF8.GetBytes("B" + "\r\n" + row + "\r\n" + col);
                    //    netStream.Write(sendBytes, 0, sendBytes.Length);

                    //}
                    Refresh();
                    //MessageBox.Show(row.ToString());
                    //MessageBox.Show(col.ToString());
                    judge();
                }
                else
                {
                    judge();
                }
                if (checkfull == 1)
                {
                    if (winner == 1)
                    {
                        MessageBox.Show("Player A win");
                        press = 0;
                        PlayGameBT.BackColor = default(Color);
                    }
                    else
                    {
                        MessageBox.Show("Player B win");
                        press = 0;
                        PlayGameBT.BackColor = default(Color);
                    }
                }
                else if (checkfull == -1)
                {
                    MessageBox.Show("Draw");
                    press = 0;
                    PlayGameBT.BackColor = default(Color);
                }
            }
            else
            {
                MessageBox.Show("Please press 'PLAY GAME' ");
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label5.Text = e.X.ToString();
            label6.Text = e.Y.ToString();

        }
        private void Client_Load(object sender, EventArgs e)
        {
            //board = new int[board_size, board_size];

            //board[1, 2] = 1;
            //board[0, 1] = -1;
        }
        protected string[] lines; 
        private void timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                if (netStream.DataAvailable)
                {

                    byte[] bytes = new byte[256];
                    netStream.ReadAsync(bytes, 0, 256);
                    string returndata = Encoding.UTF8.GetString(bytes);
                    //textBox1.Text = returndata;

                    lines = returndata.Split(new[] { "\r\n" }, StringSplitOptions.None);
                    ClientScreenTB.Text = "";

                    //timer3.Start();
                }
            }
            catch
            {
            }
        }

        private void PlayerLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lines.Count().ToString());
            board[0, 0] = int.Parse(lines[0]);
            board[0, 1] = int.Parse(lines[1]);
            board[0, 2] = int.Parse(lines[2]);
            board[1, 0] = int.Parse(lines[3]);
            board[1, 1] = int.Parse(lines[4]);
            board[1, 2] = int.Parse(lines[5]);
            board[2, 0] = int.Parse(lines[6]);
            board[2, 1] = int.Parse(lines[7]);
            board[2, 2] = int.Parse(lines[8]);
            
            check = 0;
            for (int i = 0; i < 9; i++)
            {
                check += int.Parse(lines[i]);
            }
            Refresh();
            MessageBox.Show(check.ToString());
        }
        int tmr = 0;
        private void PlayerLabel_TextChanged(object sender, EventArgs e)
        {
            tmr += 1;
            if (tmr == 1)
            {
                timer3.Start();
                timer4.Start();
            }
            if(PlayerLabel.Text == "A")
            {
                textBox1.BackColor = Color.Red;
            }
            else if (PlayerLabel.Text == "B")
            {
                textBox1.BackColor = Color.Blue;
            }
        }

        public int checkfull = 0;
        public int winner;
        void judge()
        {

            try
            {
                for (int row = 0; row < 3; row++)
                {
                    if (board[row, 0] == board[row, 1])
                    {
                        if (board[row, 0] == board[row, 2])
                        {
                            if (board[row, 0] != 0)
                            {
                                checkfull = 1;
                                if (board[row, 0] == 1)
                                {                                 
                                    winner = 1;
                                    //MessageBox.Show("A win");
                                }
                                else
                                {
                                    winner = 0;
                                    //MessageBox.Show("B win");
                                }
                            }
                        }
                    }
                }
                for (int col = 0; col < 3; col++)
                {
                    if (board[0, col] == board[1, col])
                    {
                        if (board[0, col] == board[2, col])
                        {
                            if (board[0, col] != 0)
                            {
                                checkfull = 1;
                                if (board[0, col] == 1)
                                {       
                                    winner = 1;
                                    //MessageBox.Show("A win");
                                }
                                else
                                {
                                    winner = 0;
                                    //MessageBox.Show("B win");
                                }
                            }
                        }
                    }
                }
                if (board[0, 0] == board[1, 1])
                {
                    if (board[0, 0] == board[2, 2])
                    {
                        if (board[0, 0] != 0)
                        {
                            checkfull = 1;
                            if (board[0, 0] == 1)
                            {
                                
                                winner = 1;
                                //MessageBox.Show("A win");
                            }
                            else
                            {
                                winner = 0;
                                //MessageBox.Show("B win");
                            }
                        }
                    }
                }
                if (board[0, 2] == board[1, 1])
                {
                    if (board[0, 2] == board[2, 0])
                    {
                        if (board[2, 0] != 0)
                        {
                            checkfull = 1;
                            if (board[0, 2] == 1)
                            {
                                winner = 1;
                                //MessageBox.Show("A win");
                            }
                            else
                            {
                                winner = 0;
                                //MessageBox.Show("B win");
                            }
                        }
                    }
                }
            }
            catch
            {
            }
            int full = 0;
            for (int row = 0; row < board_size; row++)
                for (int col = 0; col < board_size; col++)
                {
                    if (board[row,col] != 0)
                    {
                        full += 1;
                    }

                }
            if (full ==9 && checkfull == 0)
            {
                checkfull = -1;
                //MessageBox.Show("Draw");
            }
        }


        private void timer4_Tick(object sender, EventArgs e)
        {
            try
            {
                board[0, 0] = int.Parse(lines[0]);
                board[0, 1] = int.Parse(lines[1]);
                board[0, 2] = int.Parse(lines[2]);
                board[1, 0] = int.Parse(lines[3]);
                board[1, 1] = int.Parse(lines[4]);
                board[1, 2] = int.Parse(lines[5]);
                board[2, 0] = int.Parse(lines[6]);
                board[2, 1] = int.Parse(lines[7]);
                board[2, 2] = int.Parse(lines[8]);
                check = 0;
                for (int i = 0; i < 9; i++)
                {
                    check += int.Parse(lines[i]);
                }
                Refresh();
            }
            catch
            {
            }
            if (check == 1)
            {
                turn = 1;
                label7.Text = "B turn";
            }
            else
            {
                turn = 0;
                label7.Text = "A turn";
            }

        }
    }
}
