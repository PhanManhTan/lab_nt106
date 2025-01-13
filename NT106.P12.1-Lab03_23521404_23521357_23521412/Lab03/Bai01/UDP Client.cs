using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Lab3Bai01
{
    public partial class UDP_Client : Form
    {
        public UDP_Client()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void butSndClient_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy địa chỉ IP từ TextBox
                string remoteIP = ipremotehost.Text;
                // Kiểm tra xem IP có đúng định dạng hay không
                if (!IPAddress.TryParse(remoteIP, out _))
                {
                    MessageBox.Show("Địa chỉ IP không hợp lệ. Vui lòng nhập lại.");
                    return;
                }
                // Lấy port từ TextBox và kiểm tra xem có hợp lệ không
                if (!int.TryParse(portclient.Text, out int remotePort) || remotePort < 1024 || remotePort > 65535)
                {
                    MessageBox.Show("Port không hợp lệ. Vui lòng nhập số nguyên trong khoảng từ 1024 đến 65535.");
                    return;
                }
                // Lấy thông điệp cần gửi từ TextBox
                string message = msg_client.Text;
                // Tạo UDP Client
                UdpClient udpClient = new UdpClient();
                // Tạo điểm kết nối tới Server với IP và Port
                IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Parse(remoteIP), remotePort);
                // Mã hóa thông điệp sang định dạng byte với UTF-8 để hỗ trợ tiếng Việt có dấu
                byte[] data = Encoding.UTF8.GetBytes(message);
                // Gửi dữ liệu đến Server
                udpClient.Send(data, data.Length, remoteEndPoint);
                // Hiển thị thông báo khi gửi thành công
                MessageBox.Show("Message sent to Server: " + message);
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu xảy ra sự cố
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ipremotehost_TextChanged(object sender, EventArgs e)
        {

        }

        private void portclient_TextChanged(object sender, EventArgs e)
        {

        }

        private void msg_client_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
