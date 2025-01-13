using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Bai06
{
    public partial class inforFood : UserControl
    {
        public inforFood()
        {
            InitializeComponent();
        }
        public int id;
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Settenmonan(string s)
        {
            nameLb.Text = s;
        }
        public void Setgiamonan(string s)
        {
            costLb.Text = s;
        }
        public void Setdiachi(string s)
        {
            addressLb.Text = s;
        }
        public void Setnguoidonggop(string s)
        {
            contributeLb.Text = s;
        }
        public async  void SetPictureBox(string url)
        {
            if (!string.IsNullOrEmpty(url))
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        byte[] imageData = await client.GetByteArrayAsync(url);
                        using (var stream = new MemoryStream(imageData))
                        {
                            pictureBox1.Image = Image.FromStream(stream);
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                }
                catch
                {

                }
                
            }
        }
        public string getNameMA()
        {
            return nameLb.Text;
        }

        private void inforFood_Load(object sender, EventArgs e)
        {

        }
        public delegate void Dele(int id);
        public Dele del;
        private void labelRemove_Click(object sender, EventArgs e)
        {
            DialogResult dr= MessageBox.Show("Bạn có chắc muốn xóa món ăn này không?","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (dr==DialogResult.OK)
            {
                int x = id;
                del?.Invoke(x);
            }
        }
    }
}
