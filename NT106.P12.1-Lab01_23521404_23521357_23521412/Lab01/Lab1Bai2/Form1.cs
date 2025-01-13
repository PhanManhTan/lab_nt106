using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1Bai2
{
    public partial class BaiTH2 : Form
    {
        public BaiTH2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BaiTH2_Load(object sender, EventArgs e)
        {

        }

        private void tinhgiatri_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 && nhapA.Text != null && nhapB.Text != null)
            {
                bcc(Convert.ToInt32(nhapA.Text), Convert.ToInt32(nhapB.Text));
            }
            else if (comboBox1.SelectedIndex == 1 && nhapA.Text != null && nhapB.Text != null)
            {
                string re = "";
                long s = gt(Convert.ToInt32(nhapB.Text) - Convert.ToInt32(nhapA.Text));
                re += "(" + nhapB.Text + " - " + nhapA.Text + ")! = " + s.ToString() + "\r\n";
                double p = sum(Convert.ToDouble(nhapA.Text), Convert.ToDouble(nhapB.Text));
                re += "S = " + p.ToString();
                kqua.Text = re;
            }
        }

        private void nutxoa_Click(object sender, EventArgs e)
        {
            nhapA.Clear();
            nhapB.Clear();
            kqua.Clear();
        }

        private void nutthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ketqua_Enter(object sender, EventArgs e)
        {

        }
        private bool Check(string s)
        {
            if (s.Length == 0) return true;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] < 48 || s[i] > 57)
                {
                    return false;
                }
            }
            return true;
        }
        long gt(int a)
        {
            if (a == 0 || a == 1) return 1;
            return a * gt(a - 1);
        }
        private double sum(double a, double b)
        {
            double su = 0;
            for (double i = 1; i <= b; i++)
            {
                su += Math.Pow(a, i);
            }
            return su;
        }

        private void bcc(int a, int b)
        {
            string s = "";
            int n = b - a;
            for (int i = 1; i <= 10; i++)
            {
                s += n.ToString() + " x " + i.ToString() + " = " + (n * i).ToString() + "\r\n";
            }
            kqua.Text = s;
        }

        private void nhapA_TextChanged(object sender, EventArgs e)
        {
            string s = nhapA.Text;
            if (Check(s) == false)
            {
                MessageBox.Show("Only number!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nhapA.Text = nhapA.Text.Remove(nhapA.Text.Length - 1); //xoa ki tu vua nhap
                nhapA.SelectionStart = nhapA.Text.Length; //dua con tro den cuoi cung
            }
        }

        private void nhapB_TextChanged(object sender, EventArgs e)
        {
            string s = nhapB.Text;
            if (Check(s) == false)
            {
                MessageBox.Show("Only number!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nhapB.Text = nhapB.Text.Remove(nhapB.Text.Length - 1); //xoa ki tu vua nhap
                nhapB.SelectionStart = nhapB.Text.Length; //dua con tro den cuoi cung
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
