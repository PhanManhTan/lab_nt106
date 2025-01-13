using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class FormX : Form
    {
        public FormX()
        {
            InitializeComponent();
        }
        public FormX(Food f)
        {
            InitializeComponent();
            inforFood dishInfoControl = new inforFood();
            dishInfoControl.Settenmonan(f.ten_mon_an);
            dishInfoControl.Setgiamonan(f.gia.ToString());
            dishInfoControl.Setdiachi(f.dia_chi);
            dishInfoControl.Setnguoidonggop(f.nguoi_dong_gop);
            dishInfoControl.SetPictureBox(f.hinh_anh);
            dishInfoControl.Dock = DockStyle.Fill;
            this.Controls.Add(dishInfoControl);
        }

        private void FormX_Load(object sender, EventArgs e)
        {

        }
    }
}
