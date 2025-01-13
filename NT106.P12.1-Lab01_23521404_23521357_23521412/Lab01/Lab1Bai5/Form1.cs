using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1Bai5
{
    public partial class Form1 : Form
    {
        public class ThiSinh
        {
            public string ID { get; set; }
            public string HoTen { get; set; }
            public string Phai { get; set; }
            public float Diem1 { get; set; }
            public float Diem2 { get; set; }
            public float Diem3 { get; set; }
            public float DiemTB { get; set; }
            public string XepLoai { get; set; }

            public ThiSinh(string id, string hoTen, string phai, float diem1, float diem2, float diem3, float diemTB, string xepLoai)
            {
                ID = id;
                HoTen = hoTen;
                Phai = phai;
                Diem1 = diem1;
                Diem2 = diem2;
                Diem3 = diem3;
                DiemTB = diemTB;
                XepLoai = xepLoai;
            }
        }
        private List<ThiSinh> danhSachThiSinh = new List<ThiSinh>();
        private int currentID = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem cột được click có phải là cột chứa nút "Xóa" không
            if (e.ColumnIndex == Dsachthisinh.Columns["delete"].Index && e.RowIndex >= 0)
            {
                // Xác nhận hành động xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Xóa dòng được chọn
                    Dsachthisinh.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các trường nhập
                string hovaten = hoTen.Text;

                // Kiểm tra xem đã chọn giới tính hay chưa
                if (phai.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn Phái.");
                    return;
                }

                string phai1 = phai.SelectedItem.ToString();

                // Sử dụng CultureInfo.InvariantCulture để đảm bảo xử lý dấu thập phân đúng
                float diem1 = float.Parse(diemmon1.Text, CultureInfo.InvariantCulture);
                float diem2 = float.Parse(diemmon2.Text, CultureInfo.InvariantCulture);
                float diem3 = float.Parse(diemmon3.Text, CultureInfo.InvariantCulture);

                // Kiểm tra dữ liệu hợp lệ
                if (hovaten.Length > 30)
                {
                    MessageBox.Show("Họ và tên không được vượt quá 30 ký tự");
                    return;
                }

                if (diem1 < 0 || diem1 > 10 || diem2 < 0 || diem2 > 10 || diem3 < 0 || diem3 > 10)
                {
                    MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10");
                    return;
                }

                // Tạo ID cho thí sinh
                string id = $"TS{currentID.ToString("D3")}"; // Định dạng TSxxx
                currentID++;

                // Tính điểm trung bình
                float diemTB = (diem1 + diem2 + diem3) / 3;
                diemTB = (float)Math.Round(diemTB, 2);

                // Xếp loại
                string xepLoai = XepLoai(diem1, diem2, diem3, diemTB);

                // Thêm thí sinh vào danh sách
                ThiSinh ts = new ThiSinh(id, hovaten, phai1, diem1, diem2, diem3, diemTB, xepLoai);
                danhSachThiSinh.Add(ts);

                // Cập nhật DataGridView
                Dsachthisinh.Rows.Add(ts.ID, ts.HoTen, ts.Phai, ts.Diem1, ts.Diem2, ts.Diem3, ts.DiemTB, ts.XepLoai);

                // Clear input fields after adding
                hoTen.Clear();
                diemmon1.Clear();
                diemmon2.Clear();
                diemmon3.Clear();
                phai.SelectedIndex = -1;
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng điểm.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }



        private string XepLoai(float diem1, float diem2, float diem3, float diemTB)
        {
            if (diemTB >= 8 && diem1 >= 6.5 && diem2 >= 6.5 && diem3 >= 6.5)
                return "Giỏi";
            if (diemTB >= 6.5 && diem1 >= 5 && diem2 >= 5 && diem3 >= 5)
                return "Khá";
            if (diemTB >= 5 && diem1 >= 3.5 && diem2 >= 3.5 && diem3 >= 3.5)
                return "Trung Bình";
            if (diemTB >= 3.5 && diem1 >= 2 && diem2 >= 2 && diem3 >= 2)
                return "Yếu";
            return "Kém";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            hoTen.Clear();
            diemmon1.Clear();
            diemmon2.Clear();
            diemmon3.Clear();
            phai.SelectedIndex = -1;
        }

        private void mon1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mon2_TextChanged(object sender, EventArgs e)
        {

        }

        private void mon3_TextChanged(object sender, EventArgs e)
        {

        }

        private void phai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ThongKe()
        {
            int soLuongThiSinh = 0;
            string thiSinhDiemCaoNhat = "";
            float diemCaoNhat = float.MinValue;

            int soLuongGioi = 0;
            int soLuongKha = 0;
            int soLuongTrungBinh = 0;
            int soLuongYeuKem = 0;

            // Duyệt qua từng hàng của DataGridView
            foreach (DataGridViewRow row in Dsachthisinh.Rows)
            {
                if (!row.IsNewRow) // Kiểm tra nếu không phải hàng trống mới
                {
                    soLuongThiSinh++;

                    // Lấy tên và điểm trung bình
                    string tenThiSinh = row.Cells["Hovaten"].Value.ToString();
                    float diemTrungBinh = float.Parse(row.Cells["trungbinh"].Value.ToString());

                    // Kiểm tra thí sinh có điểm trung bình cao nhất
                    if (diemTrungBinh > diemCaoNhat)
                    {
                        diemCaoNhat = diemTrungBinh;
                        thiSinhDiemCaoNhat = tenThiSinh;
                    }

                    // Xếp loại
                    string xepLoai = row.Cells["xeploaihk"].Value.ToString();
                    switch (xepLoai)
                    {
                        case "Giỏi":
                            soLuongGioi++;
                            break;
                        case "Khá":
                            soLuongKha++;
                            break;
                        case "Trung bình":
                            soLuongTrungBinh++;
                            break;
                        case "Yếu":
                        case "Kém":
                            soLuongYeuKem++;
                            break;
                    }
                }
            }

            // Hiển thị kết quả
            MessageBox.Show(
                $"Số lượng thí sinh dự thi: {soLuongThiSinh}\n" +
                $"Thí sinh có điểm trung bình cao nhất: {thiSinhDiemCaoNhat} với {diemCaoNhat} điểm\n" +
                $"Số lượng thí sinh xếp loại Giỏi: {soLuongGioi}\n" +
                $"Số lượng thí sinh xếp loại Khá: {soLuongKha}\n" +
                $"Số lượng thí sinh xếp loại Trung bình: {soLuongTrungBinh}\n" +
                $"Số lượng thí sinh không đạt (Yếu, Kém): {soLuongYeuKem}"
            );
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKe();
        }
    }
}
