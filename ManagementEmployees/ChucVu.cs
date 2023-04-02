using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementEmployees
{
    internal class ChucVu
    {
        private string maCv;
        private string tenCv;

        public ChucVu(string maCv, string tenCv)
        {
            this.maCv = maCv;
            this.tenCv = tenCv;
        }

        public string MaCv { get => maCv; set => maCv = value; }
        public string TenCv { get => tenCv; set => tenCv = value; }
    }
}
