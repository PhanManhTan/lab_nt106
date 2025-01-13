using Bai05;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MainForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            Bai01.Bai01 bai01 = new Bai01.Bai01();
            bai01.Show();   
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            Bai02.Bai02 bai02 = new Bai02.Bai02();
            bai02.Show();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            Lab2Bai3.Lab2Bai3 bai03=new Lab2Bai3.Lab2Bai3();
            bai03.Show();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            Bai04.Bai04 bai04 = new Bai04.Bai04();
            bai04.Show();
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            Bai05.Bai05 bai05 = new Bai05.Bai05();
            bai05.Show();
        }
    }
}
