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
    public partial class Form_KhoiLop : Office2007Form
    {
        #region Toàn cục
        BUS_KhoiLop bus = new BUS_KhoiLop();
        BindingSource bs = new BindingSource();
        int donghientai;
        #endregion
        #region Load
        public Form_KhoiLop()
        {
            InitializeComponent();
        }
        private void Form_KhoiLop_Load(object sender, EventArgs e)
        {
            // Load dữ liệu DataGridView
            dgv_khoilop.DataSource = bus.LoadDataInto_DGVKhoiLop();
            // Load Binding
            bs.DataSource = dgv_khoilop.DataSource;
            bindingNavigatorKhoiLop.BindingSource = bs;

            dgv_khoilop.AllowUserToAddRows = false;
            dgv_khoilop.ReadOnly = true;

            if (dgv_khoilop.RowCount > 1)
                donghientai = dgv_khoilop.CurrentRow.Index;
            else
                donghientai = 0; 
        }
        #endregion
        #region Xử lý btn trên Toolstrip
        private void tsbtn_themmoi_Click(object sender, EventArgs e)
        {
            // Cho phép người dùng thêm dòng mới
            dgv_khoilop.AllowUserToAddRows = true;
            // Mở khóa
            dgv_khoilop.ReadOnly = false;

            // di chuyển thanh Scroll về cuối DataGridView
            dgv_khoilop.FirstDisplayedScrollingRowIndex = dgv_khoilop.Rows.Count - 1;

            for (int i = 0; i < dgv_khoilop.Rows.Count - 1; ++i)
            {
                dgv_khoilop.Rows[i].ReadOnly = true;
            }
        }

        private void tsbtn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.No)
                    return;

                foreach (DataGridViewRow item in dgv_khoilop.SelectedRows)
                    dgv_khoilop.Rows.Remove(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu này nằm trong database. Hãy thử lại!");
            }
        }

        private void tsbtn_sua_Click(object sender, EventArgs e)
        {
            dgv_khoilop.AllowUserToAddRows = false;
            // Mở khóa
            dgv_khoilop.ReadOnly = false;
            // Mở khóa từng dòng
            for (int i = 0; i < dgv_khoilop.Rows.Count - 1; ++i)
                dgv_khoilop.Rows[i].ReadOnly = false;
        }

        private void tsbtn_luu_Click(object sender, EventArgs e)
        {
            if (dgv_khoilop.CurrentRow != null)
                dgv_khoilop.CurrentCell = dgv_khoilop.Rows[dgv_khoilop.Rows.Count - 1].Cells[dgv_khoilop.CurrentCell.ColumnIndex];

            DataTable dt = (DataTable)dgv_khoilop.DataSource; // ép kiểu dữ liệu trong dataGridView là 1 DataTable
            if (bus.Update_All(dt) == false)
            {
                MessageBox.Show("Trùng MÃ KHỐI, vui lòng thử lại!");
                return;
            }
            else
                MessageBox.Show("Lưu thành công! Hãy nhấn Refresh để kiểm tra lại.");
        }

        private void tsbtn_capnhat_Click(object sender, EventArgs e)
        {
            dgv_khoilop.DataSource = bus.LoadDataInto_DGVKhoiLop();
        }

        private void tsbtn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Xử lý Binding Source
        private void SelectRow()
        {
            dgv_khoilop.ClearSelection();
            dgv_khoilop.Rows[bs.Position].Selected = true; // Select full row 
            dgv_khoilop.FirstDisplayedScrollingRowIndex = donghientai;
        }
        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            donghientai = 0;
            SelectRow();
        }
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (donghientai <= dgv_khoilop.Rows.Count)
            {
                dgv_khoilop.Rows[donghientai].Selected = false;
                dgv_khoilop.Rows[donghientai--].Selected = true;
            }
            SelectRow();
        }
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            if (dgv_khoilop.Rows.Count > 1)
            {
                if (donghientai < dgv_khoilop.RowCount)
                {
                    dgv_khoilop.Rows[donghientai].Selected = false;
                    dgv_khoilop.Rows[donghientai++].Selected = true;
                }
            }

            SelectRow();
        }
        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            donghientai = dgv_khoilop.Rows.Count - 1;
            SelectRow();
        }
        #endregion
    }
}
