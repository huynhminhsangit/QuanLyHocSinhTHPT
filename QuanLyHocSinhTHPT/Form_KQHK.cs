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
    public partial class Form_KQHK : Office2007Form
    {
        #region Toàn cục
        BUS_DiemSo      bus         = new BUS_DiemSo();
        BUS_HocSinh     busHS       = new BUS_HocSinh();
        BUS_Lop         busLop      = new BUS_Lop();
        BUS_MonHoc      busMonHoc   = new BUS_MonHoc();
        BUS_KQHKTheoLop busKQHK     = new BUS_KQHKTheoLop();
        DTO_DiemSo      pDiemSo     = new DTO_DiemSo();
        DTO_KetQuaHocKy pKQHKy      = new DTO_KetQuaHocKy();
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
            #region Load data to cbb
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
        public Form_KQHK()
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
        #region Lấy danh sách học sinh kèm bảng điểm 
        private void ThemDuLieuVaoBangKQHK()
        {
            // Chắc chắn được lớp và học kỳ
            if (cbb_lop.SelectedValue == null || cbb_hocky.SelectedValue == null)
                return;
            else
            {
                busKQHK.LayBangDiemHocKy_TheoLop(cbb_lop.SelectedValue.ToString(), cbb_hocky.SelectedValue.ToString());
                busKQHK.LayDSHocSinhChuaCoDTB_TheoLop(cbb_lop.SelectedValue.ToString(), cbb_hocky.SelectedValue.ToString());
                CapNhatDiemTB();
            }
        }
        private void CapNhatDiemTB()
        {
            int rowCount = 0;

            foreach (DataGridViewRow row in dgv_diemso.Rows)
            {
                //MessageBox.Show("" + rowCount);
                try
                {
                    if (rowCount <= dgv_diemso.Rows.Count)
                    {
                        pKQHKy.MaHocSinh = row.Cells[0].Value.ToString();
                        pKQHKy.MaHocKy = cbb_hocky.SelectedValue.ToString();
                        pKQHKy.MaLop = cbb_lop.SelectedValue.ToString();
                        pKQHKy.DiemTrungBinh = double.Parse(row.Cells[15].Value.ToString());
                    }
                    //MessageBox.Show("" + row.Cells[0].Value.ToString() + ";" + "" + cbb_hocky.SelectedValue.ToString() + ";" + cbb_lop.SelectedValue.ToString());
                    //MessageBox.Show("" + row.Cells[15].Value.ToString());
                    // Update điểm trung bình
                    busKQHK.LuuBangDiem_HocSinh_HocKy(pKQHKy);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Bạn nên nhập đầy đủ danh sách trước khi bấm lưu!", "CẢNH BÁO");
                    //return;
                }
                rowCount++;
            }
        }
        private void LayBangDiemHSTheoLop_HocKy()
        {
            // Chắc chắn được lớp và học kỳ
            if (cbb_lop.SelectedValue == null || cbb_hocky.SelectedValue == null)
            {
                dgv_diemso.DataSource = null;
                return;
            }
            else
                bus.LayBangDiem_Lop_HocKy(cbb_lop.SelectedValue.ToString(), cbb_hocky.SelectedValue.ToString());
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
            dgv_diemso.DataSource = bus.LayBangDiem_Lop_HocKy(cbb_lop.SelectedValue.ToString(), cbb_hocky.SelectedValue.ToString());
            BindingSource bs = new BindingSource();
            bs.DataSource = bus.LayBangDiem_Lop_HocKy(cbb_lop.SelectedValue.ToString(), cbb_hocky.SelectedValue.ToString());
            ThemDuLieuVaoBangKQHK();
        }
        #endregion
        #region Export To Excel
        private void btn_inbangdiem_Click(object sender, EventArgs e)
        {
            // tạo ứng dụng Excel
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // Tạo WorkBook mới 
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // tạo Sheet nới 
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            //Khai báo Sheet đầu tiên để làm việc
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // Thay đổi tên Sheet
            worksheet.Name = "Exported from gridview";
            // Lưu trữ dữ liệu cho dòng header
            for (int i = 1; i < dgv_diemso.Columns.Count + 1; i++)
                worksheet.Cells[1, i] = dgv_diemso.Columns[i - 1].HeaderText;

            // Lưu trữ dữ liệu cho các dòng, cột 
            for (int i = 0; i < dgv_diemso.Rows.Count - 1; i++)
                for (int j = 0; j < dgv_diemso.Columns.Count; j++)
                    worksheet.Cells[i + 2, j + 1] = dgv_diemso.Rows[i].Cells[j].Value.ToString();
            // Lưu file 
            workbook.SaveAs("D:\\output.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            // Thoát khỏi ứng dụng Excel 
            app.Quit();
        }
        #endregion      
    }
}
       
