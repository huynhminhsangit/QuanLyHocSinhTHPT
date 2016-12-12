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
    public partial class Form_HocLuc : Office2007Form
    {
        #region Toàn cục
        BUS_HocLuc bus = new BUS_HocLuc();
        BindingSource bs = new BindingSource();
        int donghientai;
        #endregion
        #region Load
        public Form_HocLuc()
        {
            InitializeComponent();
        }

        private void Form_HocLuc_Load(object sender, EventArgs e)
        {
            // Load dữ liệu DataGridView
            dgv_hocluc.DataSource = bus.LoadDataInto_DGVHocLuc();
            // Load Binding
            bs.DataSource = dgv_hocluc.DataSource;
            bindingNavigatorHocLuc.BindingSource = bs;

            dgv_hocluc.AllowUserToAddRows = false;
            dgv_hocluc.ReadOnly = true;

            if (dgv_hocluc.RowCount > 1)
                donghientai = dgv_hocluc.CurrentRow.Index;
            else
                donghientai = 0;
        }
        #endregion
        #region Xử lý btn trên Toolstrip
        private void tsbtn_themmoi_Click(object sender, EventArgs e)
        {
            // Cho phép người dùng thêm dòng mới
            dgv_hocluc.AllowUserToAddRows = true;
            // Mở khóa
            dgv_hocluc.ReadOnly = false;

            // di chuyển thanh Scroll về cuối DataGridView
            dgv_hocluc.FirstDisplayedScrollingRowIndex = dgv_hocluc.Rows.Count - 1;

            for (int i = 0; i < dgv_hocluc.Rows.Count - 1; ++i)
            {
                dgv_hocluc.Rows[i].ReadOnly = true;
            }
            bindingNavigatorHocLuc.BindingSource.MoveLast();
        }

        private void tsbtn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.No)
                    return;

                foreach (DataGridViewRow item in dgv_hocluc.SelectedRows)
                    dgv_hocluc.Rows.Remove(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa đối tượng thất bại. Hãy thử lại!");
            }
        }

        private void tsbtn_sua_Click(object sender, EventArgs e)
        {
            dgv_hocluc.AllowUserToAddRows = false;
            // Mở khóa
            dgv_hocluc.ReadOnly = false;
            // Mở khóa từng dòng
            for (int i = 0; i < dgv_hocluc.Rows.Count - 1; ++i)
                dgv_hocluc.Rows[i].ReadOnly = false;
        }

        private void tsbtn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_hocluc.CurrentRow != null)
                    dgv_hocluc.CurrentCell = dgv_hocluc.Rows[dgv_hocluc.Rows.Count - 1].Cells[dgv_hocluc.CurrentCell.ColumnIndex];

                DataTable dt = (DataTable)dgv_hocluc.DataSource; // ép kiểu dữ liệu trong dataGridView là 1 DataTable

                if (bus.Update_All(dt) == false)
                {
                    MessageBox.Show("Lưu thất bại, vui lòng thử lại!");
                    return;
                }
                else
                    MessageBox.Show("Lưu thành công! Hãy nhấn Refresh để kiểm tra lại.");
            }
            catch { return; }
        }

        private void tsbtn_capnhat_Click(object sender, EventArgs e)
        {
            dgv_hocluc.DataSource = bus.LoadDataInto_DGVHocLuc();
        }

        private void tsbtn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Xử lý Binding Source
        private void SelectRow()
        {
            dgv_hocluc.ClearSelection();
            dgv_hocluc.Rows[bs.Position].Selected = true; // Select full row 
            dgv_hocluc.FirstDisplayedScrollingRowIndex = donghientai;
        }
        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            donghientai = 0;
            SelectRow();
        }
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (donghientai <= dgv_hocluc.Rows.Count)
            {
                dgv_hocluc.Rows[donghientai].Selected = false;
                dgv_hocluc.Rows[donghientai--].Selected = true;
            }
            SelectRow();
        }
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            if (dgv_hocluc.Rows.Count > 1)
            {
                if (donghientai < dgv_hocluc.RowCount)
                {
                    dgv_hocluc.Rows[donghientai].Selected = false;
                    dgv_hocluc.Rows[donghientai++].Selected = true;
                }
            }

            SelectRow();
        }
        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            donghientai = dgv_hocluc.Rows.Count - 1;
            SelectRow();
        }
        #endregion
    }
}
