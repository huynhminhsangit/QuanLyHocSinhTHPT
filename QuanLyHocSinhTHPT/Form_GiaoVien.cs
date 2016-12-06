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
    public partial class Form_GiaoVien : Office2007Form
    {
        #region Toàn cục
        BUS_GiaoVien bus = new BUS_GiaoVien();
        BindingSource bs = new BindingSource();
        int donghientai;
        #endregion
        public Form_GiaoVien()
        {
            InitializeComponent();
        }
        #region Load

        private void Form_GiaoVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_LoadDataIntoDB.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.ds_LoadDataIntoDB.MONHOC);
            // TODO: This line of code loads data into the 'ds_LoadDataIntoDB.GIOITINH' table. You can move, or remove it, as needed.
            this.gIOITINHTableAdapter.Fill(this.ds_LoadDataIntoDB.GIOITINH);

            // Load dữ liệu DataGridView
            dgv_giaovien.DataSource = bus.LoadDataInto_DGVGiaoVien();

            // Load Binding
            bs.DataSource = dgv_giaovien.DataSource;
            bindingNavigatorGiaoVien.BindingSource = bs;

            dgv_giaovien.AllowUserToAddRows = false;
            dgv_giaovien.ReadOnly = true;

            if (dgv_giaovien.RowCount > 1)
                donghientai = dgv_giaovien.CurrentRow.Index;
            else
                donghientai = 0;
        }
        #endregion
        #region Xử lý btn trên Toolstrip
        private void tsbtn_themmoi_Click(object sender, EventArgs e)
        {
            // Cho phép người dùng thêm dòng mới
            dgv_giaovien.AllowUserToAddRows = true;
            // Mở khóa
            dgv_giaovien.ReadOnly = false;

            // di chuyển thanh Scroll về cuối DataGridView
            dgv_giaovien.FirstDisplayedScrollingRowIndex = dgv_giaovien.Rows.Count - 1;

            for (int i = 0; i < dgv_giaovien.Rows.Count - 1; ++i)
            {
                dgv_giaovien.Rows[i].ReadOnly = true;
            }
        }

        private void tsbtn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.No)
                    return;

                foreach (DataGridViewRow item in dgv_giaovien.SelectedRows)
                    dgv_giaovien.Rows.Remove(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu này nằm trong database. Hãy thử lại!");
            }
        }

        private void tsbtn_sua_Click(object sender, EventArgs e)
        {
            dgv_giaovien.AllowUserToAddRows = false;
            // Mở khóa
            dgv_giaovien.ReadOnly = false;
            // Mở khóa từng dòng
            for (int i = 0; i < dgv_giaovien.Rows.Count - 1; ++i)
                dgv_giaovien.Rows[i].ReadOnly = false;
        }

        private void tsbtn_luu_Click(object sender, EventArgs e)
        {
            if (dgv_giaovien.CurrentRow != null)
                dgv_giaovien.CurrentCell = dgv_giaovien.Rows[dgv_giaovien.Rows.Count - 1].Cells[dgv_giaovien.CurrentCell.ColumnIndex];

            DataTable dt = (DataTable)dgv_giaovien.DataSource; // ép kiểu dữ liệu trong dataGridView là 1 DataTable
            if (bus.Update_All(dt) == false)
            {
                MessageBox.Show("Lưu thất bại. Hãy thử lại!");
                return;
            }
            else
                MessageBox.Show("Lưu thành công! Hãy nhấn Refresh để kiểm tra lại.");
        }

        private void tsbtn_capnhat_Click(object sender, EventArgs e)
        {
            dgv_giaovien.DataSource = bus.LoadDataInto_DGVGiaoVien();
        }

        private void tsbtn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Xử lý Binding Source
        private void SelectRow()
        {
            dgv_giaovien.ClearSelection();
            dgv_giaovien.Rows[bs.Position].Selected = true; // Select full row 
            dgv_giaovien.FirstDisplayedScrollingRowIndex = donghientai;
        }
        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            donghientai = 0;
            SelectRow();
        }
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (donghientai <= dgv_giaovien.Rows.Count)
            {
                dgv_giaovien.Rows[donghientai].Selected = false;
                dgv_giaovien.Rows[donghientai--].Selected = true;
            }
            SelectRow();
        }
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            if (dgv_giaovien.Rows.Count > 1)
            {
                if (donghientai < dgv_giaovien.RowCount)
                {
                    dgv_giaovien.Rows[donghientai].Selected = false;
                    dgv_giaovien.Rows[donghientai++].Selected = true;
                }
            }

            SelectRow();
        }
        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            donghientai = dgv_giaovien.Rows.Count - 1;
            SelectRow();
        }
        #endregion
        #region Lưu bằng DTO
        private void btn_luuds_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
