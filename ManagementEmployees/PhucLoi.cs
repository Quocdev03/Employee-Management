using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementEmployees
{
    internal class PhucLoi
    {
        private string maPL;
        private string maNV;
        private DateTime ngayThucHien;
        private string noiDung;
        private string loai;

        public PhucLoi( string mapl , string manv,DateTime nth , string nd,string l)
        {
            this.MaPL = mapl;
            this.MaNV = manv;
            this.NgayThucHien = nth;
            this.NoiDung = nd;
            this.Loai = l;
        }

        public string MaPL { get => maPL; set => maPL = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime NgayThucHien { get => ngayThucHien; set => ngayThucHien = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string Loai { get => loai; set => loai = value; }
    }
}
