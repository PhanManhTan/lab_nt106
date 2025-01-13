using System;
using Client;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        TcpListener server;
        public const int BufferSize = 4096;
        List<User> userConected=new List<User>();
        private void btnListen_Click(object sender, EventArgs e)
        {
            server = new TcpListener(IPAddress.Any, 9999);
            server.Start();
            Thread listen = new Thread(() =>
            {
                Serverlisten();
            });
            listen.IsBackground = true;
            listen.Start();
            btnListen.Enabled = false;
            MessageBox.Show("Start Listening ...");
        }
        void Serverlisten()
        {
            try
            {
                while (true)
                {
                    TcpClient tcpClient = server.AcceptTcpClient(); //có client kết nối
                    User user = new User(tcpClient); //tạo client với tcp client đã kết nối
                    user.Writer.AutoFlush = true;
                    Packet request = JsonConvert.DeserializeObject<Packet>(user.Reader.ReadLine());
                    if (!Find(request.Name)) //nếu tên user không trùng với urser nào đã kết nối
                    {
                        user.Username = request.Name;
                        updateHistory(user);
                        userConected.Add(user);

                        Thread reviveFromclient = new Thread(() =>
                        {
                            recive(user);
                        });
                        Updatechat(request);  //server update chat
                        SendToAll(request);  // up date cho các client đã kết nối

                        reviveFromclient.IsBackground = true;
                        reviveFromclient.Start();
                    }
                    else
                    {
                        user.Client.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool Find(string username)
        {
            foreach (User u in userConected) {
                if (u.Username == username)
                {
                    return true;
                }
            }
            return false;
        }
        void recive(User user)
        {
            
            try
            {
                while (user.Client.Connected)
                {
                    //user.Writer.AutoFlush = true;
                    Packet request = JsonConvert.DeserializeObject<Packet>(user.Reader.ReadLine());
                    switch (request.Code)
                    {
                        case "-1": //disconect
                            { 
                                user.Client.Close();
                                userConected.RemoveAll(item => item.Username == request.Name); 
                                
                                string deleteButton = request.Name;
                                Packet packet = request;
                                packet.Code = "-1";
                                SendToAll(packet);
                                Updatechat(packet);
                                break;
                            }
                        case "-2"://message connect
                        case "0": //gui message
                            {
                                SendToAll(request);
                                Updatechat(request);
                                break;
                            }
                        case "1": //gui file text
                            {
                                foreach (User u in userConected)
                                {
                                    if (u.Username != request.Name)
                                    {
                                        Send(u, request);
                                    }
                                }
                                break;
                            }
                        case "2": //gui Image
                            {
                                foreach (User u in userConected)
                                {
                                    if (u.Username!=request.Name)
                                    {
                                        Send(u,request);
                                    }
                                }
                                break;
                            }
                        default:  //gui private
                            {
                                foreach (User u in userConected)
                                {
                                    if (u.Username == request.Code)
                                    {
                                        Send(u, request);
                                        break;
                                    }
                                }
                                break;
                            }
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"I/O error: {ex.Message}");
                // Xử lý lỗi kết nối, ví dụ như log lỗi hoặc ngắt kết nối người dùng
            }
        }
        void SendToAll(Packet packet)
        {
            
            string messageInJson = JsonConvert.SerializeObject(packet);
            try
            {
                foreach (User u in userConected)
                {
                    u.Writer.WriteLine(messageInJson);
                    u.Writer.Flush();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Send(User user, Packet info)
        {
            
            string messageInJson = JsonConvert.SerializeObject(info);
            try
            {
                user.Writer.WriteLine(messageInJson);
                user.Writer.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Updatechat(Packet packet)
        {
            switch (packet.Code)
            {
                case "-2":
                    {
                        string display = packet.Name + " " + Encoding.UTF8.GetString(packet.Message) + "\n";
                        dis(display);
                        break;
                    }
                case "0":
                    {
                        //xu ly thread
                        string display=packet.Name + " : " + Encoding.UTF8.GetString(packet.Message)+"\n";
                        dis(display);
                        break;
                    }
                case "1":
                    {
                        string display = packet.Name + " : " + Encoding.UTF8.GetString(packet.Message) + "\n";
                        dis(display);
                        break;
                    }
                case "2":
                    {
                        string display = packet.Name + " : " + Encoding.UTF8.GetString(packet.Message) + "\n";
                        dis(display);
                        break;
                    }
                case "-1":
                    {
                        string display = packet.Name + Encoding.UTF8.GetString(packet.Message) + "\n";
                        dis(display);
                        break;
                    }

            }
        }
        private void dis(string message)
        {
            if (disChat.InvokeRequired)
            {
                // Tạo delegate để gọi phương thức trên UI thread
                disChat.Invoke(new Action<string>(dis), message);
            }
            else
            {
                disChat.AppendText(message + Environment.NewLine);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnListen.Enabled = true;
            server.Stop();
        }

        private void updateHistory(User user)
        {
            string mess = "";
            foreach (User u in userConected)
            {
                mess += u.Username + ";";
            }
            Packet packet = new Packet();   
            packet.Name = user.Username;
            packet.Code = "3";
            packet.Message=Encoding.UTF8.GetBytes(mess);
            Send(user, packet);
        }

        private void disChat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


