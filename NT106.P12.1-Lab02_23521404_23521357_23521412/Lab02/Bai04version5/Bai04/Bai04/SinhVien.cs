using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    [Serializable]
    internal class SinhVien
    {
        public string HoVaTen { get; set; }
        public int MSSV { get; set; }
        public string SDT { get; set; }
        public float DiemMon1 { get; set; }
        public float DiemMon2 { get; set; }
        public float DiemMon3 { get; set; }
        public float DiemTB { get; set; }

        public SinhVien() { }
        public SinhVien(string hoVaTen, int mSSV, string sDT, float diemMon1, float diemMon2, float diemMon3)
        {
            HoVaTen = hoVaTen;
            MSSV = mSSV;
            SDT = sDT;
            DiemMon1 = diemMon1;
            DiemMon2 = diemMon2;
            DiemMon3 = diemMon3;
            DiemTB = 0;
        }
        public override bool Equals(object obj)
        {
            if (obj is SinhVien sv)
            {
                return MSSV == sv.MSSV; // So sánh dựa trên MSSV
            }
            return false;
        }

        public override int GetHashCode()
        {
            return MSSV.GetHashCode(); // Tạo mã băm từ MSSV
        }
    }
}
