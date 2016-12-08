using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KetQuaHocKy
    {
        private string _MaHocSinh;

        public string MaHocSinh
        {
            get { return _MaHocSinh; }
            set { _MaHocSinh = value; }
        }
        private string _MaHocKy;

        public string MaHocKy
        {
            get { return _MaHocKy; }
            set { _MaHocKy = value; }
        }
        private string _MaLop;

        public string MaLop
        {
            get { return _MaLop; }
            set { _MaLop = value; }
        }
        private double _DiemTrungBinh;

        public double DiemTrungBinh
        {
            get { return _DiemTrungBinh; }
            set { _DiemTrungBinh = value; }
        }
    }
}
