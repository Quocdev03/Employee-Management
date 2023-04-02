using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementEmployees
{
    internal class LichSuLamViec
    {
        private string maNv;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;

        public LichSuLamViec(string maNv, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            this.maNv = maNv;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
        }

        public string MaNv { get => maNv; set => maNv = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
    }
}
