using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HocSinh
    {
        private string _Mahocsinh;

        public string MaHocSinh
        {
            get { return _Mahocsinh; }
            set { _Mahocsinh = value; }
        }
        private string _Hoten;

        public string HoTenHocSinh
        {
            get { return _Hoten; }
            set { _Hoten = value; }
        }
        private string _Gioitinh;

        public string GioiTinh
        {
            get { return _Gioitinh; }
            set { _Gioitinh = value; }
        }

        private DateTime _Ngaysinh;
        public DateTime NgaySinh
        {
            get { return _Ngaysinh; }
            set { _Ngaysinh = value; }
        }

        private string _Noisinh;
        public string NoiSinh
        {
            get { return _Noisinh; }
            set { _Noisinh = value; }
        }

        private string _Dantoc;
        public string DanToc
        {
            get { return _Dantoc; }
            set { _Dantoc = value; }
        }

        private string _Tongiao;
        public string TonGiao
        {
            get { return _Tongiao; }
            set { _Tongiao = value; }
        }
        private string _Doituong;

        public string DoiTuong
        {
            get { return _Doituong; }
            set { _Doituong = value; }
        }
        private string _Phuhuynh;

        public string PhuHuynh
        {
            get { return _Phuhuynh; }
            set { _Phuhuynh = value; }
        }
    }
}
