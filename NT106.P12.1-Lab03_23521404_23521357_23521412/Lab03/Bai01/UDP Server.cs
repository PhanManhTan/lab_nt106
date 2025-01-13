using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3Bai01
{
    public partial class UDP_Server : Form
    {
        public UDP_Server()
        {
            InitializeComponent();
        }

        UdpClient udpServer;
        Thread receiveThread;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void butLisServer_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy port từ textBox1
                int serverPort = int.Parse(PortSV.Text);

                // Tạo một UDP Server để lắng nghe trên port đã chỉ định
                udpServer = new UdpClient(serverPort);

                // Tạo và khởi chạy một thread để xử lý nhận dữ liệu từ Client
                receiveThread = new Thread(new ThreadStart(ServerThread));
                receiveThread.IsBackground = true;
                receiveThread.Start();

                // Hiển thị thông báo rằng server đã bắt đầu lắng nghe
                MessageBox.Show("Server started and listening on port " + serverPort);
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có sự cố khi khởi tạo server
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void rcv_msgSV_TextChanged(object sender, EventArgs e)
        {

        }

        // Thread để xử lý việc nhận dữ liệu từ Client
        private void ServerThread()
        {
            IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
            while (true)
            {
                try
                {
                    // Nhận dữ liệu từ bất kỳ Client nào
                    byte[] data = udpServer.Receive(ref remoteEndPoint);

                    // Giải mã thông điệp từ định dạng byte sang chuỗi (UTF-8)
                    string receivedMessage = Encoding.UTF8.GetString(data);

                    // Chỉ lấy địa chỉ IP từ remoteEndPoint
                    string clientIp = remoteEndPoint.Address.ToString();

                    // Cập nhật giao diện với thông điệp đã nhận
                    UpdateReceivedMessage($"{clientIp}: {receivedMessage}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Hàm để cập nhật giao diện hiển thị thông điệp theo cách thread-safe
        private void UpdateReceivedMessage(string message)
        {
            if (rcv_msgSV.InvokeRequired)
            {
                rcv_msgSV.Invoke(new MethodInvoker(delegate {
                    rcv_msgSV.AppendText(message + Environment.NewLine);
                }));
            }
            else
            {
                rcv_msgSV.AppendText(message + Environment.NewLine);
            }
        }

    }
}
