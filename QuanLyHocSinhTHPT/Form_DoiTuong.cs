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
    public partial class Form_DoiTuong : Office2007Form
    {
        #region Toàn cục
        BUS_DoiTuong bus = new BUS_DoiTuong();
        BindingSource bs = new BindingSource();
        int donghientai;
        #endregion
        public Form_DoiTuong()
        {
            InitializeComponent();
        }
        private void Form_DoiTuong_Load(object sender, EventArgs e)
        {
            // Load dữ liệu DataGridView
            dgv_doituong.DataSource = bus.LoadDataInto_DGVDoiTuong();

            // Load Binding
            bs.DataSource = dgv_doituong.DataSource;
            bindingNavigatorDoiTuong.BindingSource = bs;

            dgv_doituong.AllowUserToAddRows = false;
            dgv_doituong.ReadOnly = true;

            if (dgv_doituong.RowCount > 1)
                donghientai = dgv_doituong.CurrentRow.Index;
            else
                donghientai = 0;
        }
        #region Xử lý btn trên Toolstrip
        private void tsbtn_themmoi_Click(object sender, EventArgs e)
        {
            // Cho phép người dùng thêm dòng mới
            dgv_doituong.AllowUserToAddRows = true;
            // Mở khóa
            dgv_doituong.ReadOnly = false;

            // di chuyển thanh Scroll về cuối DataGridView
            dgv_doituong.FirstDisplayedScrollingRowIndex = dgv_doituong.Rows.Count - 1;

            for (int i = 0; i < dgv_doituong.Rows.Count - 1; ++i)
            {
                dgv_doituong.Rows[i].ReadOnly = true;
            }
        }

        private void tsbtn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.No)
                    return;

                foreach (DataGridViewRow item in dgv_doituong.SelectedRows)
                    dgv_doituong.Rows.Remove(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không xóa được. Hãy thử lại!");
            }
        }

        private void tsbtn_sua_Click(object sender, EventArgs e)
        {
            dgv_doituong.AllowUserToAddRows = false;
            // Mở khóa
            dgv_doituong.ReadOnly = false;
            // Mở khóa từng dòng
            for (int i = 0; i < dgv_doituong.Rows.Count - 1; ++i)
                dgv_doituong.Rows[i].ReadOnly = false;
        }

        private void tsbtn_luu_Click(object sender, EventArgs e)
        {
            if (dgv_doituong.CurrentRow != null)
                dgv_doituong.CurrentCell = dgv_doituong.Rows[dgv_doituong.Rows.Count - 1].Cells[dgv_doituong.CurrentCell.ColumnIndex];

            DataTable dt = (DataTable)dgv_doituong.DataSource; // ép kiểu dữ liệu trong dataGridView là 1 DataTable
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
            dgv_doituong.DataSource = bus.LoadDataInto_DGVDoiTuong();
        }

        private void tsbtn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Xử lý Binding Source
        private void SelectRow()
        {
            dgv_doituong.ClearSelection();
            dgv_doituong.Rows[bs.Position].Selected = true; // Select full row 
            dgv_doituong.FirstDisplayedScrollingRowIndex = donghientai;
        }
        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            donghientai = 0;
            SelectRow();
        }
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (donghientai <= dgv_doituong.Rows.Count)
            {
                dgv_doituong.Rows[donghientai].Selected = false;
                dgv_doituong.Rows[donghientai--].Selected = true;
            }
            SelectRow();
        }
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            if (dgv_doituong.Rows.Count > 1)
            {
                if (donghientai < dgv_doituong.RowCount)
                {
                    dgv_doituong.Rows[donghientai].Selected = false;
                    dgv_doituong.Rows[donghientai++].Selected = true;
                }
            }

            SelectRow();
        }
        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            donghientai = dgv_doituong.Rows.Count - 1;
            SelectRow();
        }
        #endregion  
    }
}
