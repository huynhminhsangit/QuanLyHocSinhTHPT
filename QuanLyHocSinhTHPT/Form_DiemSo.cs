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
    public partial class Form_DiemSo : Office2007Form
    {
        #region Toàn cục
        BUS_DiemSo bus = new BUS_DiemSo();
        BUS_HocSinh busHS = new BUS_HocSinh();
        BUS_Lop busLop = new BUS_Lop();
        DTO_DiemSo pDiemSo = new DTO_DiemSo();
        #endregion
        #region Load
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
            // cbb_monhoc
            cbb_monhoc.DataSource = busMH.LoadDataInto_DGVMonHoc();
            cbb_monhoc.DisplayMember = "TENMONHOC";
            cbb_monhoc.ValueMember = "MAMONHOC";
            #endregion
        }
        public Form_DiemSo()
        {
            InitializeComponent();
        }
        private void Form_DiemSo_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // Load dữ liệu vào cbb
            LoadDataIntoCombobox();

            dgv_diemso.AllowUserToAddRows = false;
            dgv_diemso.ReadOnly = false;


            btn_hienthidanhsach.Enabled = false;
        }
        #endregion
        #region Xử lý btn trên Toolstrip
        private void tsbtn_xoa_Click(object sender, EventArgs e)
        {
            
        }

        private void tsbtn_sua_Click(object sender, EventArgs e)
        {
            dgv_diemso.AllowUserToAddRows = false;
            // Mở khóa
            dgv_diemso.ReadOnly = false;
            // Mở khóa từng dòng
            for (int i = 0; i < dgv_diemso.Rows.Count - 1; ++i)
                dgv_diemso.Rows[i].ReadOnly = false;
        }
        private void tsbtn_luu_Click(object sender, EventArgs e)
        {          
            int rowCount = 0;
          
            foreach (DataGridViewRow row in dgv_diemso.Rows)
            {
                //MessageBox.Show("" + rowCount);
                try
                {
                    if (rowCount <= dgv_diemso.Rows.Count)
                    {
                        pDiemSo.MaHocSinh = row.Cells[0].Value.ToString();
                        pDiemSo.MaMonHoc = cbb_monhoc.SelectedValue.ToString();
                        pDiemSo.MaHocKy = cbb_hocky.SelectedValue.ToString();
                        pDiemSo.MaLop = cbb_lop.SelectedValue.ToString();
                        pDiemSo.DiemMieng = double.Parse(row.Cells[2].Value.ToString());
                        pDiemSo.Diem15P = double.Parse(row.Cells[3].Value.ToString());
                        pDiemSo.Diem45P = double.Parse(row.Cells[4].Value.ToString());
                        pDiemSo.DiemThi = double.Parse(row.Cells[5].Value.ToString());
                        pDiemSo.DiemTrungBinh = double.Parse(row.Cells[6].Value.ToString());
                    }
                    //MessageBox.Show("" + row.Cells[0].Value.ToString() + ";" + "" + cbb_monhoc.SelectedValue.ToString() + ";" + cbb_hocky.SelectedValue.ToString() + ";" + cbb_lop.SelectedValue.ToString());
                    //MessageBox.Show("" + row.Cells[2].Value.ToString() + ";" + row.Cells[3].Value.ToString() + ";" + row.Cells[4].Value.ToString() + ";" + row.Cells[5].Value.ToString() + ";" + row.Cells[6].Value.ToString());
                    // Update điểm
                    bus.LuuBangDiem_HocSinh_MonHoc_HocKy(pDiemSo);                       
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn nên nhập đầy đủ danh sách trước khi bấm lưu!", "CẢNH BÁO");
                    return;
                }
                rowCount++;
            }
            
        }
        private void tsbtn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Tự động tính đtb môn
        private void dgv_diemso_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double tongdiemktthuongxuyen, tongdiemkiemtradinhki, diemthi, dtb = 0;
            double tongsobaikiemtra = 6;

            if (dgv_diemso.CurrentRow.Cells[0].Value.ToString() != "" && dgv_diemso.CurrentRow.Cells[2].Value.ToString() != "" && dgv_diemso.CurrentRow.Cells[3].Value.ToString() != null && dgv_diemso.CurrentRow.Cells[4].Value.ToString() != "" && dgv_diemso.CurrentRow.Cells[5].Value.ToString() != "")
            {
                //if (dgv_diemso.CurrentRow.Cells[0].Value != null && dgv_diemso.CurrentRow.Cells[2].Value != null && dgv_diemso.CurrentRow.Cells[3].Value != null && dgv_diemso.CurrentRow.Cells[4].Value != null && dgv_diemso.CurrentRow.Cells[5].Value.ToString() != null)
                //{
                tongdiemktthuongxuyen = double.Parse(dgv_diemso.CurrentRow.Cells[2].Value.ToString()) + double.Parse(dgv_diemso.CurrentRow.Cells[3].Value.ToString());
                tongdiemkiemtradinhki = double.Parse(dgv_diemso.CurrentRow.Cells[4].Value.ToString());
                diemthi = double.Parse(dgv_diemso.CurrentRow.Cells[5].Value.ToString());
                dtb = Math.Round(((tongdiemktthuongxuyen + (tongdiemkiemtradinhki * 2) + (diemthi * 3)) / tongsobaikiemtra), 2);
                // Kiểm tra nếu sau khi tính đtb mà đtb > 10 thì gán đtb là 10
                if (dtb > 10)
                {
                    dtb = 10;
                    dgv_diemso.CurrentRow.Cells[6].Value = dtb.ToString();
                }
                else // vẫn hiển thị bình thường
                    dgv_diemso.CurrentRow.Cells[6].Value = dtb.ToString();
            }
        }
        #endregion
        #region Lọc danh sách menu thêm điểm
        private void ThemDuLieuVaoBangDiemSo()
        {
            // Chắc chắn được lớp, môn học và học kỳ
            if (cbb_lop.SelectedValue == null || cbb_monhoc.SelectedValue == null || cbb_hocky.SelectedValue == null)
            {
                dgv_diemso.DataSource = null;
                return;
            }
            else
                // thực hiện thao tác tạo record chưa có điểm để chuẩn bị đọc lên lưới
                bus.LayBangDiem_Lop_MonHoc_HocKy(cbb_lop.SelectedValue.ToString(), cbb_monhoc.SelectedValue.ToString(), cbb_hocky.SelectedValue.ToString());
        }
        // Lọc lớp theo năm, tránh trùng lặp lại lớp
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
        private void btn_hienthidanhsach_Click(object sender, EventArgs e)
        {
            if (cbb_namhoc.SelectedValue != null && cbb_lop.SelectedValue != null && cbb_monhoc.SelectedValue != null && cbb_hocky.SelectedValue != null)
                dgv_diemso.DataSource = bus.LayDSHocSinhDaCoDiem_TheoMaNamHoc_MaLop_MonHoc_HocKy(cbb_namhoc.SelectedValue.ToString(), cbb_lop.SelectedValue.ToString(), cbb_monhoc.SelectedValue.ToString(), cbb_hocky.SelectedValue.ToString());
            // Hiển thị danh sách lớp theo môn xong thì ẩn control
            btn_hienthidanhsach.Enabled = false;
        }
        private void cbb_namhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocDanhSachLopTheoNamHoc();
            ThemDuLieuVaoBangDiemSo();
        }
        private void cbb_hocky_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThemDuLieuVaoBangDiemSo();
        }
        private void cbb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThemDuLieuVaoBangDiemSo();
        }
        private void cbb_monhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThemDuLieuVaoBangDiemSo();
            btn_hienthidanhsach.Enabled = true;
        }
        #endregion
        #region Kiểm tra điểm nhập vào có hợp lệ không
        private void dgv_diemso_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            double newDouble;
            if (e.ColumnIndex == dgv_diemso.Columns[2].Index)
            {
                dgv_diemso.Rows[e.RowIndex].ErrorText = "";


                // Don't try to validate the 'new row' until finished  
                // editing since there 
                // is not any point in validating its initial value. 
                if (dgv_diemso.Rows[e.RowIndex].IsNewRow) { return; }
                if (!double.TryParse(e.FormattedValue.ToString(),
                    out newDouble) || newDouble < 0 || newDouble > 10)
                {
                    e.Cancel = true;
                    dgv_diemso.Rows[e.RowIndex].ErrorText = "Điểm miệng không hợp lệ!";
                }
            }
            else if (e.ColumnIndex == dgv_diemso.Columns[3].Index)
            {
                dgv_diemso.Rows[e.RowIndex].ErrorText = "";

                // Don't try to validate the 'new row' until finished  
                // editing since there 
                // is not any point in validating its initial value. 
                if (dgv_diemso.Rows[e.RowIndex].IsNewRow) { return; }
                if (!double.TryParse(e.FormattedValue.ToString(),
                    out newDouble) || newDouble < 0 || newDouble > 10)
                {
                    e.Cancel = true;
                    dgv_diemso.Rows[e.RowIndex].ErrorText = "Điểm 15 phút không hợp lệ!";
                }
            }
            else if (e.ColumnIndex == dgv_diemso.Columns[4].Index)
            {
                dgv_diemso.Rows[e.RowIndex].ErrorText = "";

                // Don't try to validate the 'new row' until finished  
                // editing since there 
                // is not any point in validating its initial value. 
                if (dgv_diemso.Rows[e.RowIndex].IsNewRow) { return; }
                if (!double.TryParse(e.FormattedValue.ToString(),
                    out newDouble) || newDouble < 0 || newDouble > 10)
                {
                    e.Cancel = true;
                    dgv_diemso.Rows[e.RowIndex].ErrorText = "Điểm 1 tiết không hợp lệ!";
                }
            }
            else if (e.ColumnIndex == dgv_diemso.Columns[5].Index)
            {
                dgv_diemso.Rows[e.RowIndex].ErrorText = "";

                // Don't try to validate the 'new row' until finished  
                // editing since there 
                // is not any point in validating its initial value. 
                if (dgv_diemso.Rows[e.RowIndex].IsNewRow) { return; }
                if (!double.TryParse(e.FormattedValue.ToString(),
                    out newDouble) || newDouble < 0 || newDouble > 10)
                {
                    e.Cancel = true;
                    dgv_diemso.Rows[e.RowIndex].ErrorText = "Điểm thi cuối kì không hợp lệ!";
                }
            }
        }
        #endregion
    }
}
