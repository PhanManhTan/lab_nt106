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

namespace Lab1Bai3
{
    public partial class Form1 : Form
    {
        bool flag = false;
        string[] numberWords = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
        public Form1()
        {
            InitializeComponent();
        }
        private bool check(char s)
        {
            if (s > 57 || s < 48)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void number_TextChanged(object sender, EventArgs e)
        {
            if (number.Text.Length != 0)
            {
                if (number.Text.Length > 12)
                {
                    MessageBox.Show("Number with maximum 12 characters", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    number.Text = number.Text.Remove(number.Text.Length - 1); //xoa ki tu vua nhap
                    number.SelectionStart = number.Text.Length; //dua con tro den cuoi cung
                }
                char c = number.Text[number.Text.Length - 1];
                if (check(c) == false)
                {
                    MessageBox.Show("Only number!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    number.Text = number.Text.Remove(number.Text.Length - 1); //xoa ki tu vua nhap
                    number.SelectionStart = number.Text.Length; //dua con tro den cuoi cung
                }
            }
        }

        private string ReadNum(string s)
        {
            //string subString = s.Substring(size-3, 3);
            int size = s.Length;
            string f = "";
            if (size <= 12 && size > 9)
            {
                string billion = s.Substring(0, size - 9);
                string million = s.Substring(size - 9, 3);
                string thousand = s.Substring(size - 6, 3);
                string hundred = s.Substring(size - 3, 3);

                f += Read000(billion) + " Tỷ ";
                if (Read000(million) != "") f += Read000(million) + " Triệu ";
                if (Read000(thousand) != "") f += Read000(thousand) + " Nghìn ";
                f += Read000(hundred);
            }
            else if (size <= 9 && size > 6)
            {
                string million = s.Substring(0, size - 6);
                string thousand = s.Substring(size - 6, 3);
                string hundred = s.Substring(size - 3, 3);

                f += Read000(million) + " Triệu ";
                if (Read000(thousand) != "") f += Read000(thousand) + " Nghìn ";
                f += Read000(hundred);
            }
            else if (size <= 6 && size > 3)
            {
                string thousand = s.Substring(0, size - 3);
                string hundred = s.Substring(size - 3, 3);

                f += Read000(thousand) + " Nghìn " + Read000(hundred);
            }
            else
            {
                string hundred = s.Substring(0, size);

                f += Read000(hundred);
            }
            return f;
        }
        private string Read000(string num)     // abc
        {
            int size = num.Length;

            string result = "";

            if (size == 3)
            {
                if (num == "000") return result;
                int index0 = int.Parse(num[0].ToString());
                result += numberWords[index0] + " Trăm ";

                if (num[1] == '0' && num[2] == '0')
                {
                    result += " ";
                }
                else if (num[1] == '0' && num[2] != '0')
                {
                    int index2 = int.Parse(num[2].ToString()); ;
                    result += "Lẻ " + numberWords[index2];
                }
                else if (num[1] == '1')
                {
                    result += "Mười ";
                    if (num[2] == '0')
                    {
                        result += " ";
                    }
                    else
                    {
                        int index2 = int.Parse(num[2].ToString()); ;
                        result += numberWords[index2];
                    }
                }
                else
                {
                    int index1 = int.Parse(num[1].ToString()); ;
                    int index2 = int.Parse(num[2].ToString()); ;
                    result += numberWords[index1] + " Mươi " + numberWords[index2];

                }
            }
            else if (size == 2)
            {
                if (num[0] == '1')
                {
                    result += "Mười ";
                    if (num[1] == '0')
                    {
                        result += " ";
                    }
                    else
                    {
                        int index1 = int.Parse(num[1].ToString()); ;
                        result += numberWords[index1];
                    }
                }
                else
                {
                    int index1 = int.Parse(num[1].ToString()); ;
                    int index0 = int.Parse(num[0].ToString()); ;
                    result += numberWords[index0] + " Mươi " + numberWords[index1];
                }
            }
            else
            {
                int index0 = int.Parse(num[0].ToString()); ;
                result += numberWords[index0];
            }
            return result.Trim();

        }
        private void Readnum_Click(object sender, EventArgs e)
        {
            textBox2.Text = ReadNum(number.Text);
        }
    }
}
