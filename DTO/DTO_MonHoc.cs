using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_MonHoc
    {
        private string _MaMonHoc;
        public string MaMonHoc
        {
            get { return _MaMonHoc; }
            set { _MaMonHoc = value; }
        }

        private string _TenMonHoc;
        public string TenMonHoc
        {
            get { return _TenMonHoc; }
            set { _TenMonHoc = value; }
        }

        private int _SoTiet;
        public int SoTiet
        {
            get { return _SoTiet; }
            set { _SoTiet = value; }
        }

        private int _HeSo;
        public int HeSo
        {
            get { return _HeSo; }
            set { _HeSo = value; }
        }

    }
}
