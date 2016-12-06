using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DTO
{
    public class DTO_DiemSo
    {
        private string _MaHocSinh;
        public string MaHocSinh
        {
            get { return _MaHocSinh; }
            set { _MaHocSinh = value; }
        }

        private string _MaMonHoc;
        public string MaMonHoc
        {
            get { return _MaMonHoc; }
            set { _MaMonHoc = value; }
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

        private double _DiemMieng;
        public double DiemMieng
        {
            get { return _DiemMieng; }
            set { _DiemMieng = value; }
        }

        private double _Diem15P;
        public double Diem15P
        {
            get { return _Diem15P; }
            set { _Diem15P = value; }
        }

        private double _Diem45P;
        public double Diem45P
        {
            get { return _Diem45P; }
            set { _Diem45P = value; }
        }

        private double _DiemThi;
        public double DiemThi
        {
            get { return _DiemThi; }
            set { _DiemThi = value; }
        }

        private double _DiemTrungBinh;
        public double DiemTrungBinh
        {
            get { return _DiemTrungBinh; }
            set { _DiemTrungBinh = value; }
        }
    }
}
