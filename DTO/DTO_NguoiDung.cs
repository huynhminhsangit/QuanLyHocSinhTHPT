using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NguoiDung
    {
        private string _MaNguoiDung;
        public string MaNamHoc
        {
            get { return _MaNguoiDung; }
            set { _MaNguoiDung = value; }
        }

        private string _CapDoQuanLy;
        public string CapDoQuanLy
        {
            get { return _CapDoQuanLy; }
            set { _CapDoQuanLy = value; }
        }

        private string _HoTen;
        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }

        private string _TenDangNhap;
        public string TenDangNhap
        {
            get { return _TenDangNhap; }
            set { _TenDangNhap = value; }
        }

        private string _MatKhau;
        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }
    }
}
