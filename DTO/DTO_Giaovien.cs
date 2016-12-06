using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Giaovien
    {
        private string _MaGiaoVien;
        public string MaGiaoVien
        {
            get { return _MaGiaoVien; }
            set { _MaGiaoVien = value; }
        }
        private string _HoTen;
        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }

        private string _GioiTinh;
        public string GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }

        private string _DiaChi;
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        private string _SoDienThoai;
        public string SoDienThoai
        {
            get { return _SoDienThoai; }
            set { _SoDienThoai = value; }
        }
        private string _MonHoc;
        public string MonHoc
        {
            get { return _MonHoc; }
            set { _MonHoc = value; }
        }

    }
}
