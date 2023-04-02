using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementEmployees
{
    internal class PhongBan
    {
        private string maPB;
        private string tenPB;
        private string soDienThoai;

        public PhongBan(string maPB, string tenPB, string soDienThoai)
        {
            this.maPB = maPB;
            this.tenPB = tenPB;
            this.soDienThoai = soDienThoai;
        }

        public string MaPB { get => maPB; set => maPB = value; }
        public string TenPB { get => tenPB; set => tenPB = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
    }
}
