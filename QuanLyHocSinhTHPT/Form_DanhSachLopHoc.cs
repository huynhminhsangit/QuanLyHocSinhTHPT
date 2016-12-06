using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLyHocSinhTHPT.Component;
using BUS;
using DTO;

namespace QuanLyHocSinhTHPT
{
    public partial class Form_DanhSachLopHoc : Office2007Form
    {
        BUS_Lop busLop = new BUS_Lop();
        BUS_HocSinh bus_hocsinh = new BUS_HocSinh();
        BUS_KhoiLop bus_khoi = new BUS_KhoiLop();
        BUS_NamHoc bus_Namhoc = new BUS_NamHoc();
        BUS_PhanLop bus_phanlop = new BUS_PhanLop();
   
        public Form_DanhSachLopHoc()
        {
            InitializeComponent();
        }
        private void LocDanhSachLopTheoNamHoc_Khoi()
        {
            if (cbb_namhoc.SelectedValue == null)
            {
                cbb_lop.DataSource = null;
                return;
            }
            else
            {
                // tiến hành lấy các lớp của năm đó và hiển thị lên cbb_lop
                cbb_lop.DataSource = busLop.LayDSLop_TheoNamHoc_Khoi(cbb_namhoc.SelectedValue.ToString(), cbb_khoilop.SelectedValue.ToString());
                cbb_lop.DisplayMember = "TENLOP";
                cbb_lop.ValueMember = "MALOP";
            }

        }
        private void LocDanhSachLopTheoNamHoc()
        {
            if (cbb_namhoc.SelectedValue == null)
            {
                cbb_lop.DataSource = null;
                return;
            }
            else
            {
                // tiến hành lấy các lớp của năm đó và hiển thị lên cbb_lop
                cbb_lop.DataSource = busLop.LayDSLop_TheoNamHoc(cbb_namhoc.SelectedValue.ToString());
                cbb_lop.DisplayMember = "TENLOP";
                cbb_lop.ValueMember = "MALOP";
            }

        }
        public void LoadDataIntoCombobox()
        {
            // cbb_namhoc
            cbb_namhoc.DataSource = bus_Namhoc.LoadDataInto_DGVNamHoc();
            cbb_namhoc.DisplayMember = "TENNAMHOC";
            cbb_namhoc.ValueMember = "MANAMHOC";
            //cbb_khoi
            cbb_khoilop.DataSource = bus_khoi.LoadDataInto_DGVKhoiLop();
            cbb_khoilop.DisplayMember = "TENKHOILOP";
            cbb_khoilop.ValueMember = "MAKHOI";
            //cbblop
            LocDanhSachLopTheoNamHoc();
                  
        }
  

        private void Form_DanhSachLopHoc_Load(object sender, EventArgs e)
        {
            LoadDataIntoCombobox();
        }

        private void cbb_malop_SelectedIndexChanged(object sender, EventArgs e)//dùng combo ma lớp đe hien thị tìm kiếm 
        {
            dgv_lop.DataSource = busLop.TimKiem_TheoMaLop(cbb_lop.SelectedValue.ToString());
        }

        private void cbb_makhoi_SelectedIndexChanged(object sender, EventArgs e)//dùng combo ma khối đe hien thị tìm kiếm 
        {
            LocDanhSachLopTheoNamHoc_Khoi();
        }

        private void cbb_namhoc_SelectedIndexChanged(object sender, EventArgs e)//dùng combo nam hoc de hien thi tim kiem tren datagridview
        {
            LocDanhSachLopTheoNamHoc();
        }

    

    

       
    }
}
