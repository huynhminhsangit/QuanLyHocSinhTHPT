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
    public partial class Form_HocKy : Office2007Form
    {
        #region Toàn cục
        BUS_HocKy bus = new BUS_HocKy();
        BindingSource bs = new BindingSource();
        int donghientai;
        #endregion
        public Form_HocKy()
        {
            InitializeComponent();
        }

        private void Form_HocKy_Load(object sender, EventArgs e)
        {
            // Load dữ liệu DataGridView
            dgv_hocky.DataSource = bus.LoadDataInto_DGVHocKy();
            // Load Binding
            bs.DataSource = dgv_hocky.DataSource;
            bindingNavigatorHocKy.BindingSource = bs;

            dgv_hocky.AllowUserToAddRows = false;
            dgv_hocky.ReadOnly = true;

            if (dgv_hocky.RowCount > 1)
                donghientai = dgv_hocky.CurrentRow.Index;
            else
                donghientai = 0;
        }
        #region Xử lý btn trên Toolstrip
        private void tsbtn_themmoi_Click(object sender, EventArgs e)
        {
            // Cho phép người dùng thêm dòng mới
            dgv_hocky.AllowUserToAddRows = true;
            // Mở khóa
            dgv_hocky.ReadOnly = false;

            // di chuyển thanh Scroll về cuối DataGridView
            dgv_hocky.FirstDisplayedScrollingRowIndex = dgv_hocky.Rows.Count - 1;

            for (int i = 0; i < dgv_hocky.Rows.Count - 1; ++i)
            {
                dgv_hocky.Rows[i].ReadOnly = true;
            }
            bindingNavigatorHocKy.BindingSource.MoveLast();
        }

        private void tsbtn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.No)
                    return;

                foreach (DataGridViewRow item in dgv_hocky.SelectedRows)
                    dgv_hocky.Rows.Remove(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu này nằm trong database. Hãy thử lại!");
            }
        }

        private void tsbtn_sua_Click(object sender, EventArgs e)
        {
            dgv_hocky.AllowUserToAddRows = false;
            // Mở khóa
            dgv_hocky.ReadOnly = false;
            // Mở khóa từng dòng
            for (int i = 0; i < dgv_hocky.Rows.Count - 1; ++i)
                dgv_hocky.Rows[i].ReadOnly = false;
        }

        private void tsbtn_luu_Click(object sender, EventArgs e)
        {
            if (dgv_hocky.CurrentRow != null)
                dgv_hocky.CurrentCell = dgv_hocky.Rows[dgv_hocky.Rows.Count - 1].Cells[dgv_hocky.CurrentCell.ColumnIndex];

            DataTable dt = (DataTable)dgv_hocky.DataSource; // ép kiểu dữ liệu trong dataGridView là 1 DataTable

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
            dgv_hocky.DataSource = bus.LoadDataInto_DGVHocKy();
        }

        private void tsbtn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
#endregion
        #region Xử lý Binding Source
        private void SelectRow()
        {
            dgv_hocky.ClearSelection();
            dgv_hocky.Rows[bs.Position].Selected = true; // Select full row 
            dgv_hocky.FirstDisplayedScrollingRowIndex = donghientai;
        }
        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            donghientai = 0;
            SelectRow();
        }
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (donghientai <= dgv_hocky.Rows.Count)
            {
                dgv_hocky.Rows[donghientai].Selected = false;
                dgv_hocky.Rows[donghientai--].Selected = true;
            }
            SelectRow();
        }
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            if (dgv_hocky.Rows.Count > 1)
            {
                if (donghientai < dgv_hocky.RowCount)
                {
                    dgv_hocky.Rows[donghientai].Selected = false;
                    dgv_hocky.Rows[donghientai++].Selected = true;
                }
            }

            SelectRow();
        }
        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            donghientai = dgv_hocky.Rows.Count - 1;
            SelectRow();
        }
        #endregion
    }
}
