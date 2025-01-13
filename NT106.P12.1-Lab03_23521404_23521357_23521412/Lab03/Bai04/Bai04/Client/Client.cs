using Newtonsoft.Json;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using System.Runtime.InteropServices.ComTypes;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;
using System.Xml.Linq;


namespace Client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        public TcpClient client;
        private User user = new User();
        public IPEndPoint serverIP;
        private Packet packetFile = new Packet();
        bool choseFile = false;

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Title = "Open";
                openFileDialog1.Filter = "All file(*.*)|*.*";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    
                    string fileExtension = Path.GetExtension(openFileDialog1.FileName).ToLower();

                    if (fileExtension == ".txt")//txt
                    {
                        packetFile.Name = user.Username;
                        packetFile.Code = "1";
                        string fileContent = File.ReadAllText(openFileDialog1.FileName);
                        packetFile.Message = Encoding.UTF8.GetBytes(fileContent);
                        string mess = "Send a File text";
                        tbMessage.Text = mess;
                        choseFile = true;
                    }
                    else if (fileExtension == ".png") //png
                    {
                        packetFile.Name = user.Username;
                        packetFile.Code = "2";
                        Image image = Image.FromFile(openFileDialog1.FileName);
                        packetFile.Message = converterDemo(image);
                        string mess = "Send a Image";
                        tbMessage.Text = mess;
                        choseFile = true;
                    }
                    else if (fileExtension == ".jpg")//jpg
                    {
                        packetFile.Name = user.Username;
                        packetFile.Code = "2";
                        packetFile.Message = File.ReadAllBytes(openFileDialog1.FileName);
                        string mess = "Send a Image";
                        tbMessage.Text = mess;
                        choseFile = true;
                    }
                    else
                    {
                        MessageBox.Show("Please only choose file .txt or .png or .jpg");
                    }
                    
                }
            }
        }
        public static byte[] converterDemo(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //while (tcpClient.Connected)
            //{
            //    //Application.DoEvents();

            //    byte[] readBuffers = new byte[BufferSize];
            //    while (ns.DataAvailable)
            //    {
            //        ns.Read(readBuffers, 0, BufferSize);
            //    }
            //    string headermessage = Encoding.UTF8.GetString(readBuffers).Replace("\0", string.Empty);//cac ki tu trong duoc thay bang \0
            //    string[] content = headermessage.Split(';');
            //    if (content.Length >= 3)
            //    {
            //        string userSend = content[0];
            //        MessageType meType = (MessageType)Enum.Parse(typeof(MessageType), content[1], true);//xac dinh kieu
            //        if (meType == MessageType.Message)
            //        {
            //            string messageSend = content[2].Replace("\0", string.Empty);
            //            string formattedMsg = $"{userSend}: {messageSend} \n";
            //            Updatechat(formattedMsg);

            //        }
            //        else if (meType == MessageType.FileText)
            //        {
            //            if (string.IsNullOrEmpty(SaveFileName))
            //            {
            //                DialogResult result;
            //                result = MessageBox.Show("", "", MessageBoxButtons.YesNo);
            //                if (result == DialogResult.Yes)
            //                {
            //                    SaveFileDialog DialogSave = new SaveFileDialog();
            //                    DialogSave.Filter = "Text Files (*.txt)|*.txt";
            //                    DialogSave.RestoreDirectory = true; //giu trang thai 
            //                    DialogSave.Title = "Save";
            //                    if (DialogSave.ShowDialog() == DialogResult.OK)
            //                    {
            //                        SaveFileName = DialogSave.FileName;
            //                        fileSaveMemoryStream = new MemoryStream();
            //                    }

            //                }
            //                byte[] filePart = Encoding.UTF8.GetBytes(content[2].Replace("\0", string.Empty));
            //                fileSaveMemoryStream?.Write(filePart, 0, filePart.Length);
            //                string messageSend = "Send a file text";
            //                string formattedMsg = $"{userSend}: {messageSend} \n";
            //                Updatechat(formattedMsg);
            //            }
            //        }
            //        else
            //        {
            //            if (string.IsNullOrEmpty(SaveFileName))
            //            {
            //                DialogResult result;
            //                result = MessageBox.Show("", "", MessageBoxButtons.YesNo);
            //                if (result == DialogResult.Yes)
            //                {
            //                    SaveFileDialog DialogSave = new SaveFileDialog();
            //                    DialogSave.Filter = "PNG Files (*.png)|*.png,JPG Files (*.jpg)|*.jpg";
            //                    DialogSave.RestoreDirectory = true; //giu trang thai 
            //                    DialogSave.Title = "Save";
            //                    if (DialogSave.ShowDialog() == DialogResult.OK)
            //                    {
            //                        SaveFileName = DialogSave.FileName;
            //                        fileSaveMemoryStream = new MemoryStream();
            //                    }

            //                }
            //                byte[] filePart = Encoding.UTF8.GetBytes(content[2].Replace("\0", string.Empty));
            //                fileSaveMemoryStream?.Write(filePart, 0, filePart.Length);
            //                string messageSend = "Send a Image";
            //                string formattedMsg = $"{userSend}: {messageSend} \n";
            //                Updatechat(formattedMsg);
            //            }
            //        }
            //    }
            //}
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(tbName.Text))
            {
                client = new TcpClient();
                serverIP = new IPEndPoint(IPAddress.Parse(tbIP.Text), 9999);
                client.Connect(serverIP);
                user = new User(client);
                user.Username = tbName.Text;
                Packet packet = new Packet(user.Username,"-2", Encoding.UTF8.GetBytes("Join the chat"));
                Send(packet);
                Thread threadrecive = new Thread(() =>
                {
                    revive();
                });
                threadrecive.IsBackground = true;
                threadrecive.Start();
                btnConnect.Enabled = false;
                tbName.Enabled =false;
                MessageBox.Show("Connected");
            }
            else
            {
                MessageBox.Show("Please enter your name");
            }
        }
        void revive()
        {
            try
            {
                while (user.Client.Connected)
                {
                    while (true)
                    {
                        Packet request = JsonConvert.DeserializeObject<Packet>(user.Reader.ReadLine());
                        switch (request.Code)
                        {
                            case "-2": //conect
                                {
                                    //xu lý thread
                                    AddButton(request.Name);

                                    updateChat(request);
                                    break;
                                }
                            case "0":  //message
                                {
                                    updateChat(request);
                                    break;
                                }
                            case "1": //file text
                                {
                                    ViewText viewText = new ViewText(request.Message);
                                    viewText.ShowDialog();
                                    break;
                                }
                            case "2": //image
                                {

                                    ViewImage vi = new ViewImage(request.Message);
                                    
                                    vi.ShowDialog();

                                    break;
                                }
                            case "3": // update button connect
                                {
                                    string[] mem = Encoding.UTF8.GetString(request.Message).Split(';');
                                    for (int i = 0; i < mem.Length; i++)
                                    {
                                        AddButton(mem[i]);
                                    }
                                    break;
                                }
                            case "-1": //update button disconect
                                {
                                    updateChat(request);
                                    break;
                                }
                            default:  //recive private chat
                                {
                                    RecivePrivate(request);
                                    break;
                                }

                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void UpdateChildFormViewiImage(byte[] data)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<byte[]>(UpdateChildFormViewiImage), data);
            }
            else
            {
                // Gọi phương thức trên form con để cập nhật dữ liệu
                //ViewImage.UpdateData(data);
            }
        }
        void AddButton(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                if (flowLayoutPanel1.InvokeRequired)
                {
                    // Tạo delegate để gọi phương thức trên UI thread
                    flowLayoutPanel1.Invoke(new Action<string>(AddButton), name);
                }
                else
                {
                    Button button = new Button();
                    button.Text = name;
                    button.Width = 100;
                    button.Height = 35;
                    button.BackColor = Color.White;
                    button.Click += CreatePrivateChat;
                    flowLayoutPanel1.Controls.Add(button);
                }
            }
            

        }
        private void updateChat(Packet packet)
        {
            switch (packet.Code)
            {
                case "-2": //conect
                    {
                        string mess = packet.Name + " " + Encoding.UTF8.GetString(packet.Message) + "\n";
                        dis(mess);
                        break;
                    }
                case "0": //message
                    {
                        string mess = packet.Name + " : " + Encoding.UTF8.GetString(packet.Message) + "\n";
                        dis(mess);
                        break;
                    }
                case "1": //file text
                    {
                        string mess = packet.Name + " : " + Encoding.UTF8.GetString(packet.Message) + "\n";
                        dis(mess);
                        break;
                    }
                case "2": //file image
                    {
                        string mess = packet.Name + " : " + Encoding.UTF8.GetString(packet.Message) + "\n";
                        dis(mess);
                        break;
                    }
                case "-1": //disconect
                    {
                        string mess = packet.Name +" " + Encoding.UTF8.GetString(packet.Message) + "\n";
                        dis(mess);
                        deleteButton(packet.Name);
                        break;
                    }
            }
        }
        private void CreatePrivateChat(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (user.Username != clickedButton.Text)
            {
                if (clickedButton.BackColor == Color.Blue) { 
                    clickedButton.BackColor = Color.White;
                    PrivateChat privateChat = new PrivateChat(Ct);
                    privateChat.name = clickedButton.Text;
                    privateChat.gui = new PrivateChat.Guidata(Nhanprivate);
                    privateChat.Show();
                }
                else
                {
                    PrivateChat privateChat = new PrivateChat();
                    privateChat.name = clickedButton.Text;
                    privateChat.gui = new PrivateChat.Guidata(Nhanprivate);
                    privateChat.Show();
                }
                
            }
        }
        private void Nhanprivate(string s)
        {
            string[] x = s.Split(';');
            Packet packet = new Packet();
            packet.Name = user.Username;
            packet.Message=Encoding.UTF8.GetBytes(x[0]);
            packet.Code = x[1];
            Send(packet);

        }
        
        private void deleteButton(string name)
        {
            if (flowLayoutPanel1.InvokeRequired)
            {
                // Tạo delegate để gọi phương thức trên UI thread
                flowLayoutPanel1.Invoke(new Action<string>(deleteButton), name);
            }
            else
            {
                foreach (Control control in flowLayoutPanel1.Controls.OfType<Button>().ToList())
                {
                    if (control.Text == name)
                    {
                        flowLayoutPanel1.Controls.Remove(control);
                        control.Dispose(); // Giải phóng tài nguyên của Button sau khi xóa
                    }
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
        void Send(Packet packet)
        {
            string messageInJson = JsonConvert.SerializeObject(packet);
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
        private void leave(User user)
        {
            string leaveChat = "Left the chat";
            Packet packet = new Packet();
            packet.Name = user.Username;
            packet.Code = "-1";
            packet.Message = Encoding.UTF8.GetBytes(leaveChat);
            Send(packet);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!choseFile) //message
            {
                sendMessage();
            }
            else //file
            {
                sendMessage();
                Send(packetFile);
                packetFile=new Packet();
                choseFile = false;
            }
        }
         
        private void sendMessage()
        {
            if (!string.IsNullOrEmpty(tbMessage.Text))
            {
                Packet packet = new Packet();
                packet.Name = tbName.Text;
                packet.Code = "0";
                packet.Message = Encoding.UTF8.GetBytes(tbMessage.Text);
                Send(packet);
                tbMessage.Text = "";
            }
        }
        //disconect
        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            leave(user);
        }
        //disconect
        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            leave(user);
        }

        string Ct=string.Empty;
        private void RecivePrivate(Packet packet)
        {
            string c = Encoding.UTF8.GetString(packet.Message);
            foreach (Control control in flowLayoutPanel1.Controls.OfType<Button>().ToList())
            {
                if (control.Text == packet.Name)
                {
                    control.BackColor = Color.Blue;
                    Ct += packet.Name + " : " + c + "\n";
                }
            }
            
        }
    }
}
