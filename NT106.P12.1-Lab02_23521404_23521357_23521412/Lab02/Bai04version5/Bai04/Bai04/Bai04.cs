using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
        }

        int index;

        private List<SinhVien> svSave = new List<SinhVien>();
        private List<SinhVien> svOpen = new List<SinhVien>();

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //open
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Open";
            openFileDialog1.Filter = "Text File (*.txt) |*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            // Đảm bảo có ít nhất 6 dòng
                            if (!string.IsNullOrWhiteSpace(line))
                            {
                                SinhVien sv = new SinhVien
                                {
                                    HoVaTen = line, // Dòng 1
                                    MSSV = Convert.ToInt32(sr.ReadLine()), // Dòng 2
                                    SDT = sr.ReadLine(), // Dòng 3
                                    DiemMon1 = float.Parse(sr.ReadLine()), // Dòng 4
                                    DiemMon2 = float.Parse(sr.ReadLine()), // Dòng 5
                                    DiemMon3 = float.Parse(sr.ReadLine()) // Dòng 6
                                };

                                svOpen.Add(sv);
                            }
                        }
                    }

                    display(svOpen);
                    index = -1;
                }
            }


        }
        private void display(List<SinhVien> sv)
        {
            string re = "";
            foreach (SinhVien vi in sv)
            {

                re += vi.HoVaTen + "\r\n";
                re += vi.MSSV.ToString() + "\r\n";
                re += vi.SDT.ToString() + "\r\n";
                re += vi.DiemMon1.ToString() + "\r\n";
                re += vi.DiemMon2.ToString() + "\r\n";
                re += vi.DiemMon3.ToString() + "\r\n";
                re += "\n";
            }
            showTextBox.Text = re;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (svSave.Count!=0)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Title = "Save";
                saveFileDialog1.Filter = "Binary File (*.bin) |*.bin";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(fs, svSave);
                    }
                }
            }
            else
            {
                MessageBox.Show("Danh sách sinh viên lưu rỗng!", "Errol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //back
            if (--index >= 0)
            {
                showIn4(svOpen[index]);

            }
            else
            {
                index++;
                MessageBox.Show("Bạn đang ở đầu danh sách!", "Errol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //next
            if (++index < svOpen.Count)
            {
                showIn4(svOpen[index]);
            }
            else
            {
                index--;
                MessageBox.Show("Bạn đang ở cuối danh sách!", "Errol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //add

            SinhVien temp = new SinhVien(hotenView.Text, Convert.ToInt32(mssvView.Text), sdtView.Text, float.Parse(diem1View.Text), float.Parse(diem2View.Text), float.Parse(diem3View.Text));
            temp.DiemTB = (float)((float.Parse(diem1View.Text) + float.Parse(diem2View.Text) + float.Parse(diem3View.Text)) / 3.0);
            if (!check(temp))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng dữ liệu!", "Errol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!svSave.Contains(temp))
                {
                    svSave.Add(temp);
                }
                else
                {
                    MessageBox.Show("Sinh viên đã tồn tại trong danh sách lưu!", "Errol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                showIn4save(temp);
            }
            
        }

        private bool check(SinhVien s)
        {
            if (string.IsNullOrWhiteSpace(s.HoVaTen)) // HoVaTen không được trống
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên.", "Errol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (s.MSSV.ToString().Length != 8) // MSSV phải có độ dài 8
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng MSSV (8 ký tự).", "Errol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (s.SDT.Length != 10 || s.SDT[0] != '0') // SDT phải 10 ký tự và bắt đầu bằng 0
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng SDT (10 ký tự và ký tự 0 ở đầu).", "Errol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if ((s.DiemMon1>10||s.DiemMon1<0)&&(s.DiemMon2>10||s.DiemMon2<0)&&(s.DiemMon3>10||s.DiemMon3<0))
            {
                MessageBox.Show("Vui lòng nhập điểm hợp lệ.", "Errol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }
        private void showIn4(SinhVien x)
        {
            hotenView.Text = x.HoVaTen;
            mssvView.Text = x.MSSV.ToString();
            sdtView.Text = x.SDT;
            diem1View.Text = x.DiemMon1.ToString();
            diem2View.Text = x.DiemMon2.ToString();
            diem3View.Text = x.DiemMon3.ToString();
            diemTBview.Text = "0";
            STT.Text = (index + 1).ToString();
        }

        private void showIn4save(SinhVien x)
        {
            hotenSave.Text = x.HoVaTen;
            mssvSave.Text = x.MSSV.ToString();
            sdtSave.Text = x.SDT;
            diem1Save.Text = x.DiemMon1.ToString();
            diem2Save.Text = x.DiemMon2.ToString();
            diem3Save.Text = x.DiemMon3.ToString();
            diemTBSave.Text = x.DiemTB.ToString();
        }
    }
}
