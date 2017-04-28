using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Kho.DT0
{
    class PhieuNhap
    {
        private string maPN;
        private string ngayNhap;
        private string tongTien;

        public string MaPN
        {
            get
            {
                return maPN;
            }

            set
            {
                maPN = value;
            }
        }
        public string NgayNhap
        {
            get
            {
                return ngayNhap;
            }

            set
            {
                ngayNhap = value;
            }
        }
        public string TongTien
        {
            get
            {
                return tongTien;
            }

            set
            {
                tongTien = value;
            }
        }
    }
}
