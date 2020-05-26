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


namespace TCP
{
    public partial class Server : Form
    {
       
        public Server()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {

                if (address.AddressFamily == AddressFamily.InterNetwork)
                {


                    ServerHostTB.Text = address.ToString();
                }



            }
        }

        TcpListener mylistener = null;
        NetworkStream netStream = null;
        TcpClient[] client = new TcpClient[1000];
        List<TcpClient> client_list = new List<TcpClient>();
        

        class client_class
        {
            public string client_name;
            public TcpClient mytcpclient;
            public int turn;
            //public int ServerTurn;


        }
        List<client_class> client_name_list = new List<client_class>();
        List<client_class> client_match = new List<client_class>();
        //int count_client = 0;
        private static void AcceptCallBack(IAsyncResult AR)
        {


        }
        int chk;
        private async void StartBT_Click(object sender, EventArgs e)
        {
            
            mylistener = new TcpListener(IPAddress.Parse((ServerHostTB.Text)), Convert.ToInt32(ServerPortTb.Text));
            mylistener.Start(10);
            label4.Text = "Server started";
            chk = 1;
            timer1.Start();
            while (true)
            {

                TcpClient mytcpclient = await mylistener.AcceptTcpClientAsync();
                client_class tmp = new client_class();


                TcpClient clnt = mytcpclient;
                netStream = clnt.GetStream();
                if (netStream.DataAvailable)
                {
                    byte[] bytes = new byte[256];
                    await netStream.ReadAsync(bytes, 0, 256);
                    string name = Encoding.UTF8.GetString(bytes);

                    int check = 0;
                    foreach (var cln in client_name_list)
                    {

                        if (cln.client_name == name)
                        {
                            check += 1;
                            MessageBox.Show("oops");

                        }
                        
                    }
                    if (check == 0)
                    {
                        tmp.client_name = name;
                        tmp.mytcpclient = mytcpclient;
                        client_name_list.Add(tmp);
                        listBox1.Items.Clear();
                        foreach(var nm in client_name_list)
                        {
                            listBox1.Items.Add(nm.client_name);


                        }
                        //MessageBox.Show(tmp.client_name);

                        //client_list.Add(mytcpclient);
                        label3.Text = client_name_list.Count().ToString();

                    }
                    



                }
                
            }
            




        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (client_name_list.Count == 0)
            {
                client_name_list.Clear();
            }
            else
            {
                try
                {
                    foreach (var clientt in client_name_list)
                    {
                        TcpClient tmp = clientt.mytcpclient;
                        tmp.SendTimeout = 20;
                        netStream = tmp.GetStream();
                        try
                        {
                            if (ServerChatTB.Text != "")
                            {

                                netStream = clientt.mytcpclient.GetStream();
                                Byte[] sendBytes = Encoding.UTF8.GetBytes(ServerChatTB.Text + "\r\n");
                                netStream.Write(sendBytes, 0, sendBytes.Length);
                            }
                          
                            
                            //netStream.WriteByte((byte)'p');
                        }
                        catch
                        {

                            client_name_list.Remove(clientt);
                            listBox1.Items.Clear();
                            foreach (var nm in client_name_list)
                            {
                                listBox1.Items.Add(nm.client_name);


                            }
                            label3.Text = client_name_list.Count.ToString();



                        }

                        if (netStream.DataAvailable)
                        {
                            byte[] bytes = new byte[256];

                            netStream.ReadAsync(bytes, 0, 256);
                            string returndata = Encoding.UTF8.GetString(bytes);
                            string[] lines = returndata.Split(new[] { "\r\n" }, StringSplitOptions.None);
                            //MessageBox.Show(lines.ToString());
                            //ServerChatTB.Text += lines[0] + ":" + lines[1] + "\r\n";
                            ServerChatTB.Text += lines[0] + ":";
                            for (int j = 1; j < lines.Count(); j++)
                            {

                                ServerChatTB.Text += lines[j] + "\r\n";


                            }
                            //ServerChatTB.Text += "Client" + (i + 1).ToString() + ":" + returndata + "\r\n";

                            

                        }

                    }

                }
                catch
                {

                }
            }
            
        }


        private void Server_Load(object sender, EventArgs e)
        {

        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            mylistener.Stop();
            timer1.Stop();
            label4.Text = "Server stopped";
            chk = 0;
        }

        private void ServerChatTB_TextChanged(object sender, EventArgs e)
        {
            
        }
        int start;
        int checkk = 0;


        private void StartGameBT_Click(object sender, EventArgs e)
        {
            if (chk == 1)
            {
                //StartGameBT.Enabled = false;
                timer1.Stop();
                //timer2.Stop();
                //timer2.Start();
                //timer3.Start();
                client_match.Clear();
                board = new int[board_size, board_size];
                int turnA;
                int turnB;
                Random random = new Random();
                client_class tmp = new client_class();
                client_class tmp2 = new client_class();
                if (client_name_list.Count >= 2)
                {
                    turnA = random.Next(0, client_name_list.Count());
                    bool check = true;
                    while (check)
                    {
                        turnB = random.Next(0, client_name_list.Count());
                        if (turnA == turnB)
                        {

                        }
                        else
                        {
                            check = false;
                            ALabel.Text = client_name_list[turnA].client_name;
                            BLabel.Text = client_name_list[turnB].client_name;

                            foreach (var clientt in client_name_list)
                            {

                                if (clientt.client_name == client_name_list[turnA].client_name)
                                {
                                    tmp.client_name = client_name_list[turnA].client_name;
                                    tmp.mytcpclient = client_name_list[turnA].mytcpclient;
                                    tmp.turn = 1;
                                    client_match.Add(tmp);
                                    netStream = clientt.mytcpclient.GetStream();
                                    Byte[] sendBytes = Encoding.UTF8.GetBytes("A");

                                    netStream.Write(sendBytes, 0, sendBytes.Length);
                                    checkk += 1;
                                }
                                else if (clientt.client_name == client_name_list[turnB].client_name)
                                {
                                    tmp2.client_name = client_name_list[turnB].client_name;
                                    tmp2.mytcpclient = client_name_list[turnB].mytcpclient;
                                    tmp2.turn = 0;
                                    client_match.Add(tmp2);
                                    netStream = clientt.mytcpclient.GetStream();
                                    Byte[] sendBytes = Encoding.UTF8.GetBytes("B");

                                    netStream.Write(sendBytes, 0, sendBytes.Length);
                                    checkk += 1;
                                }
                                else
                                {
                                    netStream = clientt.mytcpclient.GetStream();
                                    Byte[] sendBytes = Encoding.UTF8.GetBytes("Watcher");

                                    netStream.Write(sendBytes, 0, sendBytes.Length);

                                }

                            }
                        }
                    }
                    MessageBox.Show("Game Started");




                }
                else
                {
                    MessageBox.Show("Not enough player");
                }
                //MessageBox.Show(client_match.Count.ToString());

                start = 1;
                



            }
            else
            {
                MessageBox.Show("Please start server");
            }
            timer2.Start();
            //timer1.Start();
        }
        int board_size = 3;
        int margin_left = 10;
        int margin_top = 10;
        int tile_width = 20;
        int[,] board;
        int row;
        int col;
        
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
                        if (board[row, col] == 1) b = Brushes.Red;
                        else b = Brushes.Blue;


                        if (board[row, col] != 0)
                        {
                            g.FillEllipse(b, margin_left + col * tile_width, margin_top + row * tile_width
                                , tile_width, tile_width);
                        }




                    }
            }
            Byte[] sendBytes;
            try
            {
                foreach (var clientt in client_name_list)
                {

                    TcpClient tmp = clientt.mytcpclient;
                    tmp.SendTimeout = 20;
                    netStream = tmp.GetStream();
                    for (int row = 0; row < board_size; row++)
                        for (int col = 0; col < board_size; col++)
                        {

                            sendBytes = Encoding.UTF8.GetBytes(board[row, col].ToString() + "\r\n");
                            netStream.Write(sendBytes, 0, sendBytes.Length);


                        }
                }



            }
            catch
            {

            }



        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            //timer1.Stop();



            try
            {



                foreach (var clientt in client_match)
                {

                    TcpClient tmp = clientt.mytcpclient;
                    tmp.SendTimeout = 20;
                    netStream = tmp.GetStream();
                    if (netStream.DataAvailable)
                    {
                        byte[] bytes = new byte[256];

                        netStream.ReadAsync(bytes, 0, 256);
                        string returndata = Encoding.UTF8.GetString(bytes);
                        string[] lines = returndata.Split(new[] { "\r\n" }, StringSplitOptions.None);
                        ServerChatTB.Text = lines[0] + lines[1] + lines[2];
                        row = int.Parse(lines[1]);
                        col = int.Parse(lines[2]);
                     

                        if (lines[0] == "A")
                        {
                            board[row, col] = 1;


                        }
                        else
                        {
                            board[row, col] = -1;

                        }


                    }

                }
            }
            catch
            {

            }


           

           
          

            Refresh();

            //timer1.Start();
        }
        
     

        private void pictureBox1_BackgroundImageChanged(object sender, EventArgs e)
        {
            
        }
    }
}
