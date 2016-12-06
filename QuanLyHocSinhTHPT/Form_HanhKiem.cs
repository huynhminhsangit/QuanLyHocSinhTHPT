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
    public partial class Form_HanhKiem : Office2007Form
    {
        #region Toàn cục
        BUS_HanhKiem bus = new BUS_HanhKiem();
        BindingSource bs = new BindingSource();
        int donghientai;
        #endregion
        #region Load
        public Form_HanhKiem()
        {
            InitializeComponent();
        }

        private void Form_HanhKiem_Load(object sender, EventArgs e)
        {
            // Load dữ liệu DataGridView
            dgv_hanhkiem.DataSource = bus.LoadDataInto_DGVHanhKiem();
            // Load Binding
            bs.DataSource = dgv_hanhkiem.DataSource;
            bindingNavigatorHanhKiem.BindingSource = bs;

            dgv_hanhkiem.AllowUserToAddRows = false;
            dgv_hanhkiem.ReadOnly = true;

            if (dgv_hanhkiem.RowCount > 1)
                donghientai = dgv_hanhkiem.CurrentRow.Index;
            else
                donghientai = 0;
        }
        #endregion
        #region Xử lý btn trên Toolstrip
        private void tsbtn_themmoi_Click(object sender, EventArgs e)
        {
            // Cho phép người dùng thêm dòng mới
            dgv_hanhkiem.AllowUserToAddRows = true;
            // Mở khóa
            dgv_hanhkiem.ReadOnly = false;

            // di chuyển thanh Scroll về cuối DataGridView
            dgv_hanhkiem.FirstDisplayedScrollingRowIndex = dgv_hanhkiem.Rows.Count - 1;

            for (int i = 0; i < dgv_hanhkiem.Rows.Count - 1; ++i)
            {
                dgv_hanhkiem.Rows[i].ReadOnly = true;
            }
            bindingNavigatorHanhKiem.BindingSource.MoveLast();
        }

        private void tsbtn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.No)
                    return;

                foreach (DataGridViewRow item in dgv_hanhkiem.SelectedRows)
                    dgv_hanhkiem.Rows.Remove(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa đối tượng thất bại. Hãy thử lại!");
            }
        }

        private void tsbtn_sua_Click(object sender, EventArgs e)
        {
            dgv_hanhkiem.AllowUserToAddRows = false;
            // Mở khóa
            dgv_hanhkiem.ReadOnly = false;
            // Mở khóa từng dòng
            for (int i = 0; i < dgv_hanhkiem.Rows.Count - 1; ++i)
                dgv_hanhkiem.Rows[i].ReadOnly = false;
        }

        private void tsbtn_luu_Click(object sender, EventArgs e)
        {
            if (dgv_hanhkiem.CurrentRow != null)
                dgv_hanhkiem.CurrentCell = dgv_hanhkiem.Rows[dgv_hanhkiem.Rows.Count - 1].Cells[dgv_hanhkiem.CurrentCell.ColumnIndex];

            DataTable dt = (DataTable)dgv_hanhkiem.DataSource; // ép kiểu dữ liệu trong dataGridView là 1 DataTable

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
            dgv_hanhkiem.DataSource = bus.LoadDataInto_DGVHanhKiem();
        }

        private void tsbtn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Xử lý Binding Source
        private void SelectRow()
        {
            dgv_hanhkiem.ClearSelection();
            dgv_hanhkiem.Rows[bs.Position].Selected = true; // Select full row 
            dgv_hanhkiem.FirstDisplayedScrollingRowIndex = donghientai;
        }
        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            donghientai = 0;
            SelectRow();
        }
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (donghientai <= dgv_hanhkiem.Rows.Count)
            {
                dgv_hanhkiem.Rows[donghientai].Selected = false;
                dgv_hanhkiem.Rows[donghientai--].Selected = true;
            }
            SelectRow();
        }
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            if (dgv_hanhkiem.Rows.Count > 1)
            {
                if (donghientai < dgv_hanhkiem.RowCount)
                {
                    dgv_hanhkiem.Rows[donghientai].Selected = false;
                    dgv_hanhkiem.Rows[donghientai++].Selected = true;
                }
            }

            SelectRow();
        }
        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            donghientai = dgv_hanhkiem.Rows.Count - 1;
            SelectRow();
        }
        #endregion
    }
}
