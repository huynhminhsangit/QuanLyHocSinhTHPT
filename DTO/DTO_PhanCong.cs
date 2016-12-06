using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhanCong
    {
        private string _NamHoc;
        public string NamHoc
        {
            get { return _NamHoc; }
            set { _NamHoc = value; }
        }

        private string _Lop;
        public string Lop
        {
            get { return _Lop; }
            set { _Lop = value; }
        }
        private string _MaMonHoc;
        public string MaMonHoc
        {
            get { return _MaMonHoc; }
            set { _MaMonHoc = value; }
        }

        private string _GiaoVien;
        public string Giaovien
        {
            get { return _GiaoVien; }
            set { _GiaoVien = value; }
        }
        private int _Stt;

        public int Stt
        {
            get { return _Stt; }
            set { _Stt = value; }
        }
    }
}
