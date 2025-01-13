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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        private string receivedTokenType;
        private string receivedAccessToken;
        public Add(string TokenType, string AccessToken)
        {
            InitializeComponent();
            receivedTokenType = TokenType;
            receivedAccessToken = AccessToken;

        }
        private readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://nt106.uitiot.vn")
        };

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbTMA.Clear();
            tbG.Clear();
            tbDC.Clear();
            tbHA.Clear();
            tbMT.Clear();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string apiUrl = "https://nt106.uitiot.vn/api/v1/monan/add";
            var requestData = new
            {
                ten_mon_an = tbTMA.Text,
                gia = tbG.Text,
                mo_ta = tbMT.Text,
                hinh_anh = tbHA.Text,
                dia_chi = tbDC.Text
            };

            string jsonData = JsonConvert.SerializeObject(requestData);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, apiUrl);
            request.Content = content;
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(receivedTokenType, receivedAccessToken);

            HttpResponseMessage responses = await httpClient.SendAsync(request);

            if (responses.IsSuccessStatusCode)
            {
                MessageBox.Show("Bạn đã thêm món ăn thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }
            this.Close();
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }
    }
}
