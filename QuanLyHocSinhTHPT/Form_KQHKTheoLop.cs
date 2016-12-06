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
    public partial class Form_KQHKTheoLop : Office2007Form
    {
        #region Toàn cục
        BUS_DiemSo bus = new BUS_DiemSo();
        BUS_HocSinh busHS = new BUS_HocSinh();
        BUS_Lop busLop = new BUS_Lop();
        BUS_MonHoc busMonHoc = new BUS_MonHoc();
        DTO_DiemSo pDiemSo = new DTO_DiemSo();
        #endregion
        #region Load
        // Lọc lớp theo năm, tránh trùng lặp lại lớp
        private void LocDanhSachLopTheoNamHoc()
        {
            if (cbb_namhoc.SelectedValue == null)
            {
                //dgv_diemso.DataSource = null;
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
            #region Call Bus
            BUS_NamHoc busNH = new BUS_NamHoc();
            BUS_HocKy busHK = new BUS_HocKy();
            BUS_MonHoc busMH = new BUS_MonHoc();
            #endregion
            #region Thêm điểm
            // cbb_namhoc
            cbb_namhoc.DataSource = busNH.LoadDataInto_DGVNamHoc();
            cbb_namhoc.DisplayMember = "TENNAMHOC";
            cbb_namhoc.ValueMember = "MANAMHOC";
            // cbb_hocky
            cbb_hocky.DataSource = busHK.LoadDataInto_DGVHocKy();
            cbb_hocky.DisplayMember = "TENHOCKY";
            cbb_hocky.ValueMember = "MAHOCKY";
            // cbb_lop
            LocDanhSachLopTheoNamHoc();
            #endregion
        }
        public Form_KQHKTheoLop()
        {
            InitializeComponent();
        }

        private void Form_KQHKTheoLop_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            // Load dữ liệu vào cbb
            LoadDataIntoCombobox();
        }
        #endregion
        private void LayBangDiemHSTheoLop_HocKy()
        {
            // Chắc chắn được lớp, môn học và học kỳ
            if (cbb_lop.SelectedValue == null || cbb_hocky.SelectedValue == null)
            {
                dgv_diemso.DataSource = null;
                return;
            }
            else
                bus.LayList_BangDiem_Lop_HocKy(cbb_lop.SelectedValue.ToString(), cbb_hocky.SelectedValue.ToString());
            // Hiển thị năm học, học kỳ, lớp, giáo viên chủ nhiệm
            lbl_namhoc.Text = cbb_namhoc.Text;
            lbl_hocky.Text = cbb_hocky.Text;
            lbl_lop.Text = cbb_lop.Text;
            lbl_gvcn.Text = busLop.LayTenGiaoVien_TheoMaLop(cbb_lop.SelectedValue.ToString());
        }
        private void cbb_namhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocDanhSachLopTheoNamHoc();
            LayBangDiemHSTheoLop_HocKy();
        }
        private void cbb_hocky_SelectedIndexChanged(object sender, EventArgs e)
        {
            LayBangDiemHSTheoLop_HocKy();
        }

        private void cbb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LayBangDiemHSTheoLop_HocKy();
            btn_hienthidanhsach.Enabled = true;
        }

        private void btn_hienthidanhsach_Click(object sender, EventArgs e)
        {
            dgv_diemso.DataSource = bus.LayList_BangDiem_Lop_HocKy(cbb_lop.SelectedValue.ToString(), cbb_hocky.SelectedValue.ToString());
        }
    }
}
