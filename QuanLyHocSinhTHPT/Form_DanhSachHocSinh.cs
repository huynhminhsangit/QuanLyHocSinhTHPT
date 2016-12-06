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
    public partial class Form_DanhSachHocSinh : Office2007Form
    {
        #region Toàn cục
        BUS_Lop busLop = new BUS_Lop();
        BUS_HocSinh busHocSinh = new BUS_HocSinh();
        BUS_KhoiLop busKhoiLop = new BUS_KhoiLop();
        BUS_NamHoc busNamHoc = new BUS_NamHoc();
        BUS_PhanLop busPhanLop = new BUS_PhanLop();
        #endregion
        #region Load
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
        private void LoadDataIntoCombobox()
        {
            //cbb_namhoc
            cbb_namhoc.DataSource = busNamHoc.LoadDataInto_DGVNamHoc();
            cbb_namhoc.DisplayMember = "TENNAMHOC";
            cbb_namhoc.ValueMember = "MANAMHOC";
            //cbb_khoi
            cbb_khoilop.DataSource = busKhoiLop.LoadDataInto_DGVKhoiLop();
            cbb_khoilop.DisplayMember = "TENKHOILOP";
            cbb_khoilop.ValueMember = "MAKHOI";
            //cbb_lop
            LocDanhSachLopTheoNamHoc_Khoi();

        }
        public Form_DanhSachHocSinh()
        {
            InitializeComponent();
        }
        private void Form_DanhSachHocSinh_Load(object sender, EventArgs e)
        {
            // Load data
            LoadDataIntoCombobox();
        }
        #endregion
        private void cbb_namhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocDanhSachLopTheoNamHoc();
        }

        private void cbb_khoilop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocDanhSachLopTheoNamHoc_Khoi();
        }

        private void cbb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_danhsachhocsinh.DataSource = busPhanLop.LayDSHocSinhTheoMaLopMaKhoiMaNH(cbb_lop.SelectedValue.ToString());
        }

    }
}
