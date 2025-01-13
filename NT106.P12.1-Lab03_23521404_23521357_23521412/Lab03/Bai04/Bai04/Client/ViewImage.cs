using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Client
{
    public partial class ViewImage : Form
    {
        byte[] x;
        public ViewImage(byte[] imageData)
        {
            InitializeComponent();
            x= imageData;
            // Hiển thị ảnh trong sự kiện Load
            //OnMessageReceived(imageData);
        }
        public void UpdateData(byte[] data)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<byte[]>(UpdateData), data);
            }
            else
            {
                // Thực hiện cập nhật UI với dữ liệu mới
                using (MemoryStream ms = new MemoryStream(data))
                {
                    this.pictureBox1.Image = Image.FromStream(ms);
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                    
            }
        }
        private void OnMessageReceived(byte[] packet)
        {
            // Gọi DisplayMessage để hiển thị tin nhắn nhận được
            this.BeginInvoke((MethodInvoker)(() => UpdateData(packet)));
        }

        private void ViewImage_Load(object sender, EventArgs e)
        {
            OnMessageReceived(x);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //private void DisplayMessage(Packet packet)
        //{
        //    // Timer để hiển thị tin nhắn trong 4 giây
        //    var displayTimer = new System.Threading.Timer(state =>
        //    {
        //        // Cập nhật UI để hiển thị tin nhắn từ client khác
        //        this.Invoke((MethodInvoker)(() =>
        //        {
        //            string messageText = Encoding.UTF8.GetString(packet.ArrayByte);

        //            if (User1.Text == packet.Username)
        //            {
        //                panel1.Visible = true;
        //                richTextBoxU1.Visible = true;
        //                richTextBoxU1.Text = messageText;
        //            }
        //            else if (User2.Text == packet.Username)
        //            {
        //                panel2.Visible = true;
        //                richTextBoxU2.Visible = true;
        //                richTextBoxU2.Text = messageText;
        //            }
        //            else if (User3.Text == packet.Username)
        //            {
        //                panel3.Visible = true;
        //                richTextBoxU3.Visible = true;
        //                richTextBoxU3.Text = messageText;
        //            }
        //        }));

        //        // Sau 4 giây, ẩn tin nhắn đi
        //        var hideTimer = new System.Threading.Timer(_ =>
        //        {
        //            this.Invoke((MethodInvoker)(() =>
        //            {
        //                if (User1.Text == packet.Username)
        //                {
        //                    richTextBoxU1.Clear(); // Xóa nội dung tin nhắn
        //                    richTextBoxU1.Visible = false;
        //                    panel1.Visible = false;
        //                }
        //                else if (User2.Text == packet.Username)
        //                {
        //                    richTextBoxU2.Clear();
        //                    richTextBoxU2.Visible = false;
        //                    panel2.Visible = false;
        //                }
        //                else if (User3.Text == packet.Username)
        //                {
        //                    richTextBoxU3.Clear();
        //                    richTextBoxU3.Visible = false;
        //                    panel3.Visible = false;
        //                }
        //            }));
        //        }, null, 4000, Timeout.Infinite); // Đặt 4 giây cho timer ẩn
        //    }, null, 0, Timeout.Infinite);
        //}

        // Phương thức này sẽ được gọi bởi thread nhận tin nhắn khi nhận được tin nhắn từ client khác
        
    }
}
