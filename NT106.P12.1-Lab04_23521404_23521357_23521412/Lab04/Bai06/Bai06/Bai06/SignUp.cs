using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }





        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbUN.Clear();
            tbPW.Clear();
            tbE.Clear();
            tbFN.Clear();
            tbLN.Clear();
            tbP.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUN.Text))
            {
                MessageBox.Show("Vui lòng nhập Username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(tbPW.Text))
            {
                MessageBox.Show("Vui lòng nhập Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(tbE.Text))
            {
                MessageBox.Show("Vui lòng nhập Email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(tbFN.Text))
            {
                MessageBox.Show("Vui lòng nhập Firstname!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(tbLN.Text))
            {
                MessageBox.Show("Vui lòng nhập Lastname!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(tbP.Text))
            {
                MessageBox.Show("Vui lòng nhập Phone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(comboBox1.SelectedIndex==-1)
            {
                MessageBox.Show("Vui lòng chọn ngôn ngữ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int ss;
            if (radioButton1.Checked) {
                ss = 1;
            }
            else
            {
                ss=0;
            }
            user u = new user
            {
                username = tbUN.Text,
                password = tbPW.Text,
                email = tbE.Text,
                first_name = tbFN.Text,
                last_name = tbLN.Text,
                sex = ss,
                birthday = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"),
                language = comboBox1.SelectedItem.ToString(),
                phone = tbP.Text
            };
            using (HttpClient client = new HttpClient())
            {
                string jsonData = JsonConvert.SerializeObject(u);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("https://nt106.uitiot.vn/api/v1/user/signup", content);

                // Kiểm tra phản hồi
                if (response.IsSuccessStatusCode)
                {
                    // Nếu đăng ký thành công
                    MessageBox.Show("Đăng ký thành công");
                    
                }
                else
                {
                    // Nếu đăng ký thất bại, lấy nội dung lỗi
                    string errorContent = await response.Content.ReadAsStringAsync();

                    // Chuyển đổi JSON phản hồi lỗi thành đối tượng động để lấy "detail"
                    dynamic errorResponse = JsonConvert.DeserializeObject(errorContent);
                    string errorMessage = errorResponse?.detail ?? "Đăng ký thất bại với lỗi không xác định.";

                    MessageBox.Show("Lỗi: " + errorMessage);
                }
            }

        }
    }
}
