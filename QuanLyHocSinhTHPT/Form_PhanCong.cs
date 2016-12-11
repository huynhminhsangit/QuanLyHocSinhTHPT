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
    public partial class Form_PhanCong : Office2007Form
    {
        
        #region Toàn cục
        BUS_PhanCong bus = new BUS_PhanCong();
        BindingSource bs = new BindingSource();
        int donghientai;

        Form_NamHoc frmNamHoc = null;
        Form_Lop frmLop = null;
        Form_MonHoc frmMonHoc = null;
        Form_GiaoVien frmGiaoVien = null;
        #endregion
        #region Load
        public Form_PhanCong()
        {
            InitializeComponent();
        }
        public void LoadDataIntoCombobox()
        {
            // Load data vào cbb_namhoc
            BUS_NamHoc bus_NH = new BUS_NamHoc();
            cbb_namhoc.DataSource = bus_NH.LoadDataInto_DGVNamHoc();
            cbb_namhoc.DisplayMember = "TENNAMHOC";
            cbb_namhoc.ValueMember = "MANAMHOC";
            // Load data vào cbb_lop
            BUS_Lop bus_Lop = new BUS_Lop();
            cbb_lop.DataSource = bus_Lop.LoadDataInto_DGVLop();
            cbb_lop.DisplayMember = "TENLOP";
            cbb_lop.ValueMember = "MALOP";
            // Load data vào cbb_monhoc
            BUS_MonHoc bus_MH = new BUS_MonHoc();
            cbb_monhoc.DataSource = bus_MH.LoadDataInto_DGVMonHoc();
            cbb_monhoc.DisplayMember = "TENMONHOC";
            cbb_monhoc.ValueMember = "MAMONHOC";
            // Load data vào cbb_giaovien
            BUS_GiaoVien bus_GV = new BUS_GiaoVien();
            cbb_giaovien.DataSource = bus_GV.LoadDataInto_DGVGiaoVien();
            cbb_giaovien.DisplayMember = "TENGIAOVIEN";
            cbb_giaovien.ValueMember = "MAGIAOVIEN";
        }
        private void Form_PhanCong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_LoadDataIntoDB.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Fill(this.ds_LoadDataIntoDB.GIAOVIEN);
            // TODO: This line of code loads data into the 'ds_LoadDataIntoDB.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.ds_LoadDataIntoDB.MONHOC);
            // TODO: This line of code loads data into the 'ds_LoadDataIntoDB.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.ds_LoadDataIntoDB.LOP);
            // TODO: This line of code loads data into the 'ds_LoadDataIntoDB.NAMHOC' table. You can move, or remove it, as needed.
            this.nAMHOCTableAdapter.Fill(this.ds_LoadDataIntoDB.NAMHOC);

            // Load dữ liệu DataGridView
            dgv_phancong.DataSource = bus.LoadDataInto_DGVPhanCong();

            // Load Binding
            bs.DataSource = dgv_phancong.DataSource;
            bindingNavigatorPhanCong.BindingSource = bs;

            // Load DataCombobox
            LoadDataIntoCombobox();

            dgv_phancong.AllowUserToAddRows = false;
            dgv_phancong.ReadOnly = true;

            if (dgv_phancong.RowCount > 1)
                donghientai = dgv_phancong.CurrentRow.Index;
            else
                donghientai = 0;
        }
        #endregion
        #region Xử lý btn trên Toolstrip
        private void tsbtn_themmoi_Click(object sender, EventArgs e)
        {
            // Cho phép người dùng thêm dòng mới
            dgv_phancong.AllowUserToAddRows = true;
            // Mở khóa
            dgv_phancong.ReadOnly = false;

            // di chuyển thanh Scroll về cuối DataGridView
            dgv_phancong.FirstDisplayedScrollingRowIndex = dgv_phancong.Rows.Count - 1;

            for (int i = 0; i < dgv_phancong.Rows.Count - 1; ++i)
            {
                dgv_phancong.Rows[i].ReadOnly = true;
            }
        }

        private void tsbtn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.No)
                    return;

                foreach (DataGridViewRow item in dgv_phancong.SelectedRows)
                    dgv_phancong.Rows.Remove(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu này nằm trong database. Hãy thử lại!");
            }
        }

        private void tsbtn_sua_Click(object sender, EventArgs e)
        {
            dgv_phancong.AllowUserToAddRows = false;
            // Mở khóa
            dgv_phancong.ReadOnly = false;
            // Mở khóa từng dòng
            for (int i = 0; i < dgv_phancong.Rows.Count - 1; ++i)
                dgv_phancong.Rows[i].ReadOnly = false;
        }

        private void tsbtn_luu_Click(object sender, EventArgs e)
        {
            if (dgv_phancong.CurrentRow != null)
                dgv_phancong.CurrentCell = dgv_phancong.Rows[dgv_phancong.Rows.Count - 1].Cells[dgv_phancong.CurrentCell.ColumnIndex];

            DataTable dt = (DataTable)dgv_phancong.DataSource; // ép kiểu dữ liệu trong dataGridView là 1 DataTable
            if (bus.Update_All(dt) == false)
            {
                MessageBox.Show("Lưu lại thất bại!");
                return;
            }
            else
                MessageBox.Show("Lưu thành công! Hãy nhấn Refresh để kiểm tra lại.");
        }

        private void tsbtn_capnhat_Click(object sender, EventArgs e)
        {
            dgv_phancong.DataSource = bus.LoadDataInto_DGVPhanCong();
        }

        private void tsbtn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Xử lý Binding Source
        private void SelectRow()
        {
            dgv_phancong.ClearSelection();
            dgv_phancong.Rows[bs.Position].Selected = true; // Select full row 
            dgv_phancong.FirstDisplayedScrollingRowIndex = donghientai;
        }
        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            donghientai = 0;
            SelectRow();
        }
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (donghientai <= dgv_phancong.Rows.Count)
            {
                dgv_phancong.Rows[donghientai].Selected = false;
                dgv_phancong.Rows[donghientai--].Selected = true;
            }
            SelectRow();
        }
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            if (dgv_phancong.Rows.Count > 1)
            {
                if (donghientai < dgv_phancong.RowCount)
                {
                    dgv_phancong.Rows[donghientai].Selected = false;
                    dgv_phancong.Rows[donghientai++].Selected = true;
                }
            }

            SelectRow();
        }
        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            donghientai = dgv_phancong.Rows.Count - 1;
            SelectRow();
        }
        #endregion
        #region Open Form
        private void btn_themnamhoc_Click(object sender, EventArgs e)
        {
            if (frmNamHoc == null || frmNamHoc.IsDisposed)
            {
                frmNamHoc = new Form_NamHoc();
                frmNamHoc.MdiParent = Form_Main.ActiveForm;
                frmNamHoc.Show();
            }
            else
                frmNamHoc.Activate();
        }

        private void btn_themlop_Click(object sender, EventArgs e)
        {
            if (frmLop == null || frmLop.IsDisposed)
            {
                frmLop = new Form_Lop();
                frmLop.MdiParent = Form_Main.ActiveForm;
                frmLop.Show();
            }
            else
                frmLop.Activate();
        }

        private void btn_themmonhoc_Click(object sender, EventArgs e)
        {
            if (frmMonHoc == null || frmMonHoc.IsDisposed)
            {
                frmMonHoc = new Form_MonHoc();
                frmMonHoc.MdiParent = Form_Main.ActiveForm;
                frmMonHoc.Show();
            }
            else
                frmGiaoVien.Activate();
        }

        private void btn_themgiaovien_Click(object sender, EventArgs e)
        {
            if (frmGiaoVien == null || frmGiaoVien.IsDisposed)
            {
                frmGiaoVien = new Form_GiaoVien();
                frmGiaoVien.MdiParent = Form_Main.ActiveForm;
                frmGiaoVien.Show();
            }
            else
                frmGiaoVien.Activate();
        }
        #endregion
        #region Thêm dữ liệu bằng DTO
        private void btn_luuds_Click(object sender, EventArgs e)
        {
            if (bus.KT_KhoaChinh(txt_stt.Text) == false)
            {
                MessageBox.Show("Số thứ tự đã tồn tại, thử lại!");
                return;
            }
            else
            {
                try
                {
                    
                    DTO_PhanCong pPhanCong = new DTO_PhanCong();
                    pPhanCong.Stt = int.Parse(txt_stt.Text);
                    pPhanCong.NamHoc = cbb_namhoc.SelectedValue.ToString();
                    pPhanCong.Lop = cbb_lop.SelectedValue.ToString();
                    pPhanCong.MaMonHoc = cbb_monhoc.SelectedValue.ToString();
                    pPhanCong.Giaovien = cbb_giaovien.SelectedValue.ToString();
                    bus.Them(pPhanCong);
                    MessageBox.Show("Thêm dữ liệu thành công, tải lại để kiểm tra.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm dữ liệu thất bại, hãy thử lại!");
                }
            }
        }
        #endregion
    }
}
