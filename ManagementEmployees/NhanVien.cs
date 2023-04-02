using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementEmployees
{
    internal class NhanVien
    {
        private string maNv;
        private string maPB;
        private string maCV;
        private string hoTen;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string diaChi;
        private string soDienThoai;

        public NhanVien(string maNv, string maPB, string maCV, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string soDienThoai)
        {
            this.maNv = maNv;
            this.maPB = maPB;
            this.maCV = maCV;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
        }

        public string MaNv { get => maNv; set => maNv = value; }
        public string MaPB { get => maPB; set => maPB = value; }
        public string MaCV { get => maCV; set => maCV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }

    }
}
