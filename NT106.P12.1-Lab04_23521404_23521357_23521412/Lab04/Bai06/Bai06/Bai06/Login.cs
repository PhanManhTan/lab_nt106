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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Bai06
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();  
        }
        private string tokentype = string.Empty;
        private string accesstoken = string.Empty;
        HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://nt106.uitiot.vn")
        };
        private async void button1_Click(object sender, EventArgs e)
        {
            if ( !string.IsNullOrEmpty(tbUsername.Text) && !string.IsNullOrEmpty(tbPassword.Text))
            {
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
                        //httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(tokentype, accesstoken);
                        MessageBox.Show("Đăng nhập thành công!");
                        HNAG hnag = new HNAG(tokentype,accesstoken,username);
                        hnag.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng thử lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
