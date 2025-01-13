using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bai06
{
    public partial class HNAG : Form
    {
        private string tokentype = string.Empty;
        private string accesstoken = string.Empty;
        HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://nt106.uitiot.vn")
        };
        public HNAG(string Tokentype,string Accesstoken,string s)
        {
            InitializeComponent();
            labelUsername.Text ="Welcome "+ s; 
            cbPage.SelectedIndex = 0;
            cbPageSize.SelectedIndex = 4;
            tokentype = Tokentype;
            accesstoken = Accesstoken;

        }
        //HttpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(tokentype, accesstoken);
        //https://nt106.uitiot.vn/api/v1/monan/all
        //https://nt106.uitiot.vn/api/v1/monan/my-dishes
        //https://nt106.uitiot.vn/api/v1/monan/{id}
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add a = new Add(tokentype, accesstoken);
            a.ShowDialog();
            if (ALL.SelectedIndex == 1)
            {
                getDataMY();
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Control control = null;
            if (ALL.SelectedIndex==0)
            {
                if (taball.Count!=0)
                {
                    Random random = new Random();
                    int idx = random.Next(0, taball.Count);
                    FormX formX = new FormX(taball[idx]);
                    formX.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không có món ăn nào để hiển thị.");
                }
            }
            else
            {
                if (tabmy.Count != 0)
                {
                    Random random = new Random();
                    int idx = random.Next(0, tabmy.Count);
                    FormX formX = new FormX(tabmy[idx]);
                    formX.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không có món ăn nào để hiển thị.");
                }
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        List<Food> taball=new List<Food>();
        List<Food> tabmy=new List<Food>();
        private async void getDataALL()
        {
            try
            {
                string page = (cbPage.SelectedItem.ToString());
                string pagesize = (cbPageSize.SelectedItem.ToString());

                var requestData = new Dictionary<string, string>
                {
                       { "current", page },
                       { "pageSize", pagesize }
                };
                string jsonData = JsonConvert.SerializeObject(requestData);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "https://nt106.uitiot.vn/api/v1/monan/all");
                request.Content = content;
                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(tokentype, accesstoken);

                HttpResponseMessage responses = await httpClient.SendAsync(request);
                {
                    if (responses.IsSuccessStatusCode)
                    {
                        string responseContent = await responses.Content.ReadAsStringAsync();
                        FoodResponse foodResponse=JsonConvert.DeserializeObject<FoodResponse>(responseContent);
                        taball = foodResponse.Data;
                        flowLayoutPanel1.Controls.Clear();
                        if (foodResponse.Data.Count != 0)
                        {
                            foreach (var f in foodResponse.Data)
                            {
                                AddToPanel1(f);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn lại page!", "Page không khả dụng",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lấy dữ liệu thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void AddToPanel1(Food f)
        {
            inforFood dishInfoControl = new inforFood();
            dishInfoControl.Settenmonan(f.ten_mon_an);
            dishInfoControl.Setgiamonan(f.gia.ToString());
            dishInfoControl.Setdiachi(f.dia_chi);
            dishInfoControl.Setnguoidonggop(f.nguoi_dong_gop);
            dishInfoControl.SetPictureBox(f.hinh_anh);
            flowLayoutPanel1.Controls.Add(dishInfoControl);
        }
        private async void getDataMY()
        {
            try
            {
                string page = (cbPage.SelectedItem.ToString());
                string pagesize = (cbPageSize.SelectedItem.ToString());

                var requestData = new Dictionary<string, string>
                {
                       { "current", page },
                       { "pageSize", pagesize }
                };
                string jsonData = JsonConvert.SerializeObject(requestData);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "https://nt106.uitiot.vn/api/v1/monan/my-dishes");
                request.Content = content;
                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(tokentype, accesstoken);

                HttpResponseMessage responses = await httpClient.SendAsync(request);
                {
                    if (responses.IsSuccessStatusCode)
                    {
                        string responseContent = await responses.Content.ReadAsStringAsync();
                        FoodResponse foodResponse = JsonConvert.DeserializeObject<FoodResponse>(responseContent);
                        tabmy = foodResponse.Data;
                        flowLayoutPanel2.Controls.Clear();
                        if (foodResponse.Data.Count != 0)
                        {
                            foreach (var f in foodResponse.Data)
                            {
                                AddToPanel2(f);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn lại page!","Page không khả dụng",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lấy dữ liệu thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void AddToPanel2(Food f)
        {
            inforFood dishInfoControl = new inforFood();
            dishInfoControl.id = f.id;
            dishInfoControl.del = new inforFood.Dele(De);
            dishInfoControl.Settenmonan(f.ten_mon_an);
            dishInfoControl.Setgiamonan(f.gia.ToString());
            dishInfoControl.Setdiachi(f.dia_chi);
            dishInfoControl.Setnguoidonggop(f.nguoi_dong_gop);
            dishInfoControl.SetPictureBox(f.hinh_anh);
            foreach (Control c in dishInfoControl.Controls)
            {
                if (c is Label label && label.Name == "labelRemove")
                {
                    c.Visible = true;
                }
            }

            flowLayoutPanel2.Controls.Add(dishInfoControl);
        }

        private async void HNAG_Load(object sender, EventArgs e)
        {
            ALL.SelectedIndex = 0;
            getDataALL();
        }
        private void cbPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ALL.SelectedIndex == 0)
            {
                getDataALL();
            }
            else
            {
                getDataMY();
            }
        }

        private void cbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ALL.SelectedIndex==0)
            {
                getDataALL();
            }
            else
            {
                getDataMY();
            }
        }
        private void ALL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ALL.SelectedIndex == 0)
            {
                getDataALL();
            }
            else 
            {
                getDataMY();

            }

        }

        public async void De(int u)
        {
            string id=u.ToString();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, "https://nt106.uitiot.vn/api/v1/monan/"+u);
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(tokentype, accesstoken);
            HttpResponseMessage response = await httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Đã xóa thành công");
                getDataMY();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
            
        }

    }
}
