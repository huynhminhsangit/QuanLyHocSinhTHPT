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
    public partial class Form_HocSinh : Office2007Form
    {
        
        #region Toàn cục
        BUS_HocSinh bus = new BUS_HocSinh();
        DTO_HocSinh pHocSinh = new DTO_HocSinh();
        BindingSource bs = new BindingSource();
        int donghientai;
        #endregion
        #region Load 
        public Form_HocSinh()
        {
            InitializeComponent();
        }
        public void LoadDataIntoCombobox()
        {
            // Load data vào cbb_dantoc
            BUS_DanToc bus_DT = new BUS_DanToc();
            cbb_dantoc.DataSource = bus_DT.LoadDataInto_DGVDanToc();
            cbb_dantoc.DisplayMember = "TENDANTOC";
            cbb_dantoc.ValueMember = "MADANTOC";
            // Load data vào cbb_tongiao
            BUS_TonGiao bus_TG = new BUS_TonGiao();
            cbb_tongiao.DataSource = bus_TG.LoadDataInto_DGVTonGiao();
            cbb_tongiao.DisplayMember = "TENTONGIAO";
            cbb_tongiao.ValueMember = "MATONGIAO";
            // Load data vào cbb_doituong
            BUS_DoiTuong busDT = new BUS_DoiTuong();
            cbb_doituong.DataSource = busDT.LoadDataInto_DGVDoiTuong();
            cbb_doituong.DisplayMember = "TENDOITUONG";
            cbb_doituong.ValueMember = "MADOITUONG";
            // Load data vào cbb_phuhuynh
            BUS_PhuHuynh bus_PH = new BUS_PhuHuynh();
            cbb_phuhuynh.DataSource = bus_PH.LoadDataInto_DGVPhuHuynh();
            cbb_phuhuynh.DisplayMember = "HOTENPHUHUYNH";
            cbb_phuhuynh.ValueMember = "MAPHUHUYNH";
            // Load data vào cbb_gioitinh
            BUS_GioiTinh bus_gioitinh = new BUS_GioiTinh();
            cbb_gioitinh.DataSource = bus_gioitinh.LoadDataIntoDGVGioiTinh();
            cbb_gioitinh.DisplayMember = "TENGIOITINH";
            cbb_gioitinh.ValueMember = "MAGIOITINH";
        }
        private void Form_HocSinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_LoadDataIntoDB.PHUHUYNH' table. You can move, or remove it, as needed.
            this.pHUHUYNHTableAdapter.Fill(this.ds_LoadDataIntoDB.PHUHUYNH);
            // TODO: This line of code loads data into the 'ds_LoadDataIntoDB.DOITUONG' table. You can move, or remove it, as needed.
            this.dOITUONGTableAdapter.Fill(this.ds_LoadDataIntoDB.DOITUONG);
            // TODO: This line of code loads data into the 'ds_LoadDataIntoDB.TONGIAO' table. You can move, or remove it, as needed.
            this.tONGIAOTableAdapter.Fill(this.ds_LoadDataIntoDB.TONGIAO);
            // TODO: This line of code loads data into the 'ds_LoadDataIntoDB.DANTOC' table. You can move, or remove it, as needed.
            this.dANTOCTableAdapter.Fill(this.ds_LoadDataIntoDB.DANTOC);
            // TODO: This line of code loads data into the 'ds_LoadDataIntoDB.GIOITINH' table. You can move, or remove it, as needed.
            this.gIOITINHTableAdapter.Fill(this.ds_LoadDataIntoDB.GIOITINH);
            
            // Load dữ liệu DataGridView
            dgv_hocsinh.DataSource = bus.LoadDataInto_DGVHocSinh();

            // Load Binding
            bs.DataSource = dgv_hocsinh.DataSource;
            bindingNavigatorHocSinh.BindingSource = bs;

            // Load DataCombobox
            LoadDataIntoCombobox();

            dgv_hocsinh.AllowUserToAddRows = false;
            dgv_hocsinh.ReadOnly = true;
            dgv_hocsinh.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";

            if (dgv_hocsinh.RowCount > 1)
                donghientai = dgv_hocsinh.CurrentRow.Index;
            else
                donghientai = 0;    
        }
        #endregion
        #region Xử lý btn trên Toolstrip
        private void tsbtn_themmoi_Click(object sender, EventArgs e)
        {
            // Cho phép người dùng thêm dòng mới
            dgv_hocsinh.AllowUserToAddRows = true;
            // Mở khóa
            dgv_hocsinh.ReadOnly = false;

            // di chuyển thanh Scroll về cuối DataGridView
            dgv_hocsinh.FirstDisplayedScrollingRowIndex = dgv_hocsinh.Rows.Count - 1;

            for (int i = 0; i < dgv_hocsinh.Rows.Count - 1; ++i)
            {
                dgv_hocsinh.Rows[i].ReadOnly = true;
            }
        }

        private void tsbtn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.No)
                    return;

                foreach (DataGridViewRow item in dgv_hocsinh.SelectedRows)
                    dgv_hocsinh.Rows.Remove(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại. Hãy thử lại!");
            }
        }

        private void tsbtn_sua_Click(object sender, EventArgs e)
        {
            dgv_hocsinh.AllowUserToAddRows = false;
            // Mở khóa
            dgv_hocsinh.ReadOnly = false;
            // Mở khóa từng dòng
            for (int i = 0; i < dgv_hocsinh.Rows.Count - 1; ++i)
                dgv_hocsinh.Rows[i].ReadOnly = false;
        }

        private void tsbtn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_hocsinh.CurrentRow != null)
                    dgv_hocsinh.CurrentCell = dgv_hocsinh.Rows[dgv_hocsinh.Rows.Count - 1].Cells[dgv_hocsinh.CurrentCell.ColumnIndex];

                DataTable dt = (DataTable)dgv_hocsinh.DataSource; // ép kiểu dữ liệu trong dataGridView là 1 DataTable
                if (bus.Update_All(dt) == false)
                {
                    MessageBox.Show("Lưu lại thất bại!");
                    return;
                }
                else
                    MessageBox.Show("Lưu thành công! Hãy nhấn Refresh để kiểm tra lại.");
            }
            catch { return; }
        }

        private void tsbtn_capnhat_Click(object sender, EventArgs e)
        {
            dgv_hocsinh.DataSource = bus.LoadDataInto_DGVHocSinh();
        }
        private void tsbtn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Xử lý Binding Source
        private void SelectRow()
        {
            dgv_hocsinh.ClearSelection();
            dgv_hocsinh.Rows[bs.Position].Selected = true; // Select full row 
            dgv_hocsinh.FirstDisplayedScrollingRowIndex = donghientai;
        }
        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            donghientai = 0;
            SelectRow();
        }
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (donghientai <= dgv_hocsinh.Rows.Count)
            {
                dgv_hocsinh.Rows[donghientai].Selected = false;
                dgv_hocsinh.Rows[donghientai--].Selected = true;
            }
            SelectRow();
        }
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            if (dgv_hocsinh.Rows.Count > 1)
            {
                if (donghientai < dgv_hocsinh.RowCount)
                {
                    dgv_hocsinh.Rows[donghientai].Selected = false;
                    dgv_hocsinh.Rows[donghientai++].Selected = true;
                }
            }

            SelectRow();
        }
        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            donghientai = dgv_hocsinh.Rows.Count - 1;
            SelectRow();
        }
        #endregion
        #region Xử lý thêm bằng DTO
        private void btnLuuVaoDS_Click(object sender, EventArgs e)
        {
            if (bus.KT_KhoaChinh(txt_mahocsinh.Text) == false)
            {
                MessageBox.Show("Mã học sinh đã có, hãy thử lại!");
                return;
            }
            else
            {
                try
                {
                    pHocSinh.MaHocSinh = txt_mahocsinh.Text;
                    pHocSinh.HoTenHocSinh = txt_hoten.Text;
                    pHocSinh.GioiTinh = cbb_gioitinh.SelectedValue.ToString();
                    pHocSinh.NgaySinh = DateTime.Parse(dt_ngaysinh.Value.ToString());
                    pHocSinh.NoiSinh = txt_noisinh.Text;
                    pHocSinh.DanToc = cbb_dantoc.SelectedValue.ToString();
                    pHocSinh.TonGiao = cbb_tongiao.SelectedValue.ToString();
                    pHocSinh.DoiTuong = cbb_doituong.SelectedValue.ToString();
                    pHocSinh.PhuHuynh = cbb_phuhuynh.SelectedValue.ToString();
                    // Thêm dữ liệu
                    bus.Them(pHocSinh);
                    // Msg
                    MessageBox.Show("Thêm dữ liệu mới thành công! Hãy cập nhật để kiểm tra.");
                    // Clear
                    RefreshControl();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thất bại, hãy thử lại!");
                }
            }
        }
        public void RefreshControl()
        {
            txt_mahocsinh.Clear();
            txt_hoten.Clear();
            txt_noisinh.Clear();
            dt_ngaysinh.Text = "";
        }
        #endregion
    }
}
