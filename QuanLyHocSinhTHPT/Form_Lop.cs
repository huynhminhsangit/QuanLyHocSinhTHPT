using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using BUS;
using DTO;

namespace QuanLyHocSinhTHPT
{
    public partial class Form_Lop : Office2007Form
    {
        
        #region Toàn cục
        BUS_Lop bus = new BUS_Lop();
        BindingSource bs = new BindingSource();
        int donghientai;
        DTO_Lop pLopHoc = new DTO_Lop();
        Form_NamHoc frmNamHoc = null;
        Form_KhoiLop frmKhoiLop = null;
        Form_GiaoVien frmGiaoVien = null;
        #endregion
        #region Load
        public Form_Lop()
        {
            InitializeComponent();
        }
        public void LoadDataIntoCombobox()
        {
            // Load Data Combobox KhoiLop
            BUS_KhoiLop bus_KL = new BUS_KhoiLop();
            cbb_khoilop.DataSource = bus_KL.LoadDataInto_DGVKhoiLop();
            cbb_khoilop.DisplayMember = "TENKHOILOP";
            cbb_khoilop.ValueMember = "MAKHOI";

            // Load Data Combobox NamHoc
            BUS_NamHoc bus_NH = new BUS_NamHoc();
            cbb_namhoc.DataSource = bus_NH.LoadDataInto_DGVNamHoc();
            cbb_namhoc.DisplayMember = "TENNAMHOC";
            cbb_namhoc.ValueMember = "MANAMHOC";

            // Load Data Combobox GiaoVienChuNhiem
            BUS_GiaoVien bus_GV = new BUS_GiaoVien();
            cbb_giaovienchunhiem.DataSource = bus_GV.LoadDataGiaoVien_ChuaChuNhiem();
            cbb_giaovienchunhiem.DisplayMember = "TENGIAOVIEN";
            cbb_giaovienchunhiem.ValueMember = "MAGIAOVIEN";
        }
        private void Form_Lop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_LoadDataIntoDB.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Fill(this.ds_LoadDataIntoDB.GIAOVIEN);
            // TODO: This line of code loads data into the 'ds_LoadDataIntoDB.NAMHOC' table. You can move, or remove it, as needed.
            this.nAMHOCTableAdapter.Fill(this.ds_LoadDataIntoDB.NAMHOC);
            // TODO: This line of code loads data into the 'ds_LoadDataIntoDB.KHOILOP' table. You can move, or remove it, as needed.
            this.kHOILOPTableAdapter.Fill(this.ds_LoadDataIntoDB.KHOILOP);

            // Load dữ liệu DataGridView
            dgv_lop.DataSource = bus.LoadDataInto_DGVLop();

            // Load Binding
            bs.DataSource = dgv_lop.DataSource;
            bindingNavigatorKhoiLop.BindingSource = bs;

            // Load DataCombobox
            LoadDataIntoCombobox();

            dgv_lop.AllowUserToAddRows = false;
            dgv_lop.ReadOnly = true;

            if (dgv_lop.RowCount > 1)
                donghientai = dgv_lop.CurrentRow.Index;
            else
                donghientai = 0;
        }
        #endregion
        #region Xử lý btn trên Toolstrip
        private void tsbtn_themmoi_Click(object sender, EventArgs e)
        {
            // Cho phép người dùng thêm dòng mới
            dgv_lop.AllowUserToAddRows = true;
            // Mở khóa
            dgv_lop.ReadOnly = false;

            // di chuyển thanh Scroll về cuối DataGridView
            dgv_lop.FirstDisplayedScrollingRowIndex = dgv_lop.Rows.Count - 1;

            for (int i = 0; i < dgv_lop.Rows.Count - 1; ++i)
            {
                dgv_lop.Rows[i].ReadOnly = true;
            }
        }

        private void tsbtn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.No)
                    return;

                foreach (DataGridViewRow item in dgv_lop.SelectedRows)
                    dgv_lop.Rows.Remove(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa đối tượng thất bại. Hãy thử lại!");
            }
        }

        private void tsbtn_sua_Click(object sender, EventArgs e)
        {
            dgv_lop.AllowUserToAddRows = false;
            // Mở khóa
            dgv_lop.ReadOnly = false;
            // Mở khóa từng dòng
            for (int i = 0; i < dgv_lop.Rows.Count - 1; ++i)
                dgv_lop.Rows[i].ReadOnly = false;
        }

        private void tsbtn_luu_Click(object sender, EventArgs e)
        {
                if (dgv_lop.CurrentRow != null)
                    dgv_lop.CurrentCell = dgv_lop.Rows[dgv_lop.Rows.Count - 1].Cells[dgv_lop.CurrentCell.ColumnIndex];

                DataTable dt = (DataTable)dgv_lop.DataSource; // ép kiểu dữ liệu trong dataGridView là 1 DataTable
                if (bus.Update_All(dt) == false)
                {
                    MessageBox.Show("Lưu thất bại, vui lòng thử lại!");
                    return;
                }
                else
                    MessageBox.Show("Lưu thành công! Hãy nhấn Refresh để kiểm tra lại.");
        }

        private void tsbtn_capnhat_Click(object sender, EventArgs e)
        {
            dgv_lop.DataSource = bus.LoadDataInto_DGVLop();
        }

        private void tsbtn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Xử lý Binding Source
        private void SelectRow()
        {
            dgv_lop.ClearSelection();
            dgv_lop.Rows[bs.Position].Selected = true; // Select full row 
            dgv_lop.FirstDisplayedScrollingRowIndex = donghientai;
        }
        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            donghientai = 0;
            SelectRow();
        }
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (donghientai <= dgv_lop.Rows.Count)
            {
                dgv_lop.Rows[donghientai].Selected = false;
                dgv_lop.Rows[donghientai--].Selected = true;
            }
            SelectRow();
        }
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            if (dgv_lop.Rows.Count > 1)
            {
                if (donghientai < dgv_lop.RowCount)
                {
                    dgv_lop.Rows[donghientai].Selected = false;
                    dgv_lop.Rows[donghientai++].Selected = true;
                }
            }

            SelectRow();
        }
        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            donghientai = dgv_lop.Rows.Count - 1;
            SelectRow();
        }
        #endregion
        #region Open Form
        private void btn_themkhoi_Click(object sender, EventArgs e)
        {
            if (frmKhoiLop == null || frmKhoiLop.IsDisposed)
            {
                frmKhoiLop = new Form_KhoiLop();
                frmKhoiLop.MdiParent = Form_Main.ActiveForm;
                frmKhoiLop.Show();
            }
            else
                frmKhoiLop.Activate();
        }

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
        #region Lưu dữ liệu bằng DTO
        private void btn_luuds_Click(object sender, EventArgs e)
        {
            if (bus.KT_KhoaChinh(txt_malop.Text) == false)
            {
                MessageBox.Show("Trùng khoá chính");
                return;
            }
            else
            {
                try
                {
                    if (string.IsNullOrEmpty(txt_malop.Text))
                    {
                        MessageBox.Show("Không được để rỗng mã lớp","WARNING");
                        return;
                    }
                    else if (string.IsNullOrEmpty(txt_tenlop.Text))
                    {
                        MessageBox.Show("Không được để rỗng tên lớp", "WARNING");
                        return;
                    }
                    else
                    {
                        pLopHoc.MaLop = txt_malop.Text;
                        pLopHoc.TenLop = txt_tenlop.Text;
                        pLopHoc.Khoi = cbb_khoilop.SelectedValue.ToString();
                        pLopHoc.NamHoc = cbb_namhoc.SelectedValue.ToString();
                        pLopHoc.SiSoLop = int.Parse(numeric_siso.Value.ToString());
                        pLopHoc.GiaoVienCN = cbb_giaovienchunhiem.SelectedValue.ToString();
                        // Thêm dữ liệu
                        bus.Them(pLopHoc);
                        // Msg
                        MessageBox.Show("Thêm dữ liệu thành công, tải lại để kiểm tra!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm dữ liệu thất bại, hãy kiểm tra lại!");

                }
            }
        }
        #endregion
        #region Ràng buộc không cho nhập sĩ số không phù hợp với quy định
        private void dgv_lop_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int newDouble;
            if (e.ColumnIndex == dgv_lop.Columns[4].Index)
            {
                dgv_lop.Rows[e.RowIndex].ErrorText = "";

                if (dgv_lop.Rows[e.RowIndex].IsNewRow) { return; }
                if (!int.TryParse(e.FormattedValue.ToString(),
                    out newDouble) || newDouble < 35 || newDouble > 40)
                {
                    e.Cancel = true;
                    dgv_lop.Rows[e.RowIndex].ErrorText = "Sĩ số chỉ từ 35 -> 40!";
                }
            }
        }
        #endregion
    }
}
