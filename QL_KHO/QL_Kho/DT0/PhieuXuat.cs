using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Kho.DT0
{
    class PhieuXuat
    {
        private string maPX;
        private string ngayXuat;
        private string tongTien;
        public string MaPX
        {
            get
            {
                return maPX;
            }

            set
            {
                maPX = value;
            }
        }
        public string NgayXuat
        {
            get
            {
                return ngayXuat;
            }

            set
            {
                ngayXuat = value;
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
