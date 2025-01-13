using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bai0456
{
    public partial class Bai0456 : Form
    {
        public Bai0456()
        {
            InitializeComponent();
        }
        private string tokentype=string.Empty;
        private string accesstoken=string.Empty;
        HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://nt106.uitiot.vn")
        };
        private async void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbURL.Text) &&!string.IsNullOrEmpty(tbUsername.Text) && !string.IsNullOrEmpty(tbPassword.Text))
            {
                richTextBox1.Clear();
                string username = tbUsername.Text;
                string password = tbPassword.Text;

                var formData = new Dictionary<string, string>
                {
                       { "username", username },
                       { "password", password }
                };

                var content = new FormUrlEncodedContent(formData);
                
                using (HttpResponseMessage response = await httpClient.PostAsync("auth/token", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var res = await response.Content.ReadAsStringAsync();
                        JObject jsonResponse = JObject.Parse(res);
                        if (jsonResponse["access_token"] != null)
                        {
                            tokentype = jsonResponse["token_type"].ToString();
                            accesstoken = jsonResponse["access_token"].ToString();
                        }
                        richTextBox1.Clear();
                        richTextBox1.AppendText(tokentype + '\n');
                        richTextBox1.AppendText(accesstoken + '\n');
                        richTextBox1.AppendText("\nĐăng nhập thành công");
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng thử lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private async void btnGet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(accesstoken))
            {
                richTextBox1.Clear();
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(tokentype, accesstoken);

                using (HttpResponseMessage response = await httpClient.GetAsync("api/v1/user/me"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var in4user=await response.Content.ReadAsStringAsync();
                        var formattedJson = JValue.Parse(in4user).ToString(Formatting.Indented);
                    
                        richTextBox1.AppendText(formattedJson);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng đăng nhập!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string nameuser=string .Empty;
        //private void btnHNAG_Click(object sender, EventArgs e)
        //{
        //    if (!string .IsNullOrEmpty(accesstoken))
        //    {
        //        Bai06.Bai06 b6 = new Bai06.Bai06();
        //        b6.ShowDialog();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng đăng nhập!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
