using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementEmployees
{
    internal class Luong
    {
        private string maNV;
        private DateTime ngayCap;
        private float luongCoBan;
        private float luongThuong;
        private float luongPhuCap;

        public Luong(string maNV, DateTime ngaycap, float luongCoBan, float luongThuong, float luongPhuCap)
        {
            this.maNV = maNV;
            this.ngayCap = ngaycap;
            this.luongCoBan = luongCoBan;
            this.luongThuong = luongThuong;
            this.luongPhuCap = luongPhuCap;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime NgayCap { get=> ngayCap; set => ngayCap = value; }
        public float LuongCoBan { get => luongCoBan; set => luongCoBan = value; }
        public float LuongThuong { get => luongThuong; set => luongThuong = value; }
        public float LuongPhuCap { get => luongPhuCap; set => luongPhuCap = value; }
    }
}
