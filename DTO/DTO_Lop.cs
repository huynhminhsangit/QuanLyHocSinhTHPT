using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Lop
    {
        private string _MaLop;

        public string MaLop
        {
            get { return _MaLop; }
            set { _MaLop = value; }
        }
        private string _TenLop;

        public string TenLop
        {
            get { return _TenLop; }
            set { _TenLop = value; }
        }
        private string _Khoi;

        public string Khoi
        {
            get { return _Khoi; }
            set { _Khoi = value; }
        }
        private string _NamHoc;

        public string NamHoc
        {
            get { return _NamHoc; }
            set { _NamHoc = value; }
        }
        private int _SiSoLop;

        public int SiSoLop
        {
            get { return _SiSoLop; }
            set { _SiSoLop = value; }
        }
        private string _GiaoVienCN;

        public string GiaoVienCN
        {
            get { return _GiaoVienCN; }
            set { _GiaoVienCN = value; }
        }
    }
}
