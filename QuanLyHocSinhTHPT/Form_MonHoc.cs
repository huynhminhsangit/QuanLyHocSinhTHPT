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
    public partial class Form_MonHoc : Office2007Form
    {
        #region Toàn cục
        BUS_MonHoc bus = new BUS_MonHoc();
        BindingSource bs = new BindingSource();
        int donghientai;
        #endregion
        #region Load
        public Form_MonHoc()
        {
            InitializeComponent();
        }

        private void Form_MonHoc_Load(object sender, EventArgs e)
        {
            // Load dữ liệu DataGridView
            dgv_hocsinh.DataSource = bus.LoadDataInto_DGVMonHoc();

            // Load Binding
            bs.DataSource = dgv_hocsinh.DataSource;
            bindingNavigatorMonHoc.BindingSource = bs;

            dgv_hocsinh.AllowUserToAddRows = false;
            dgv_hocsinh.ReadOnly = true;

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
                MessageBox.Show("Dữ liệu này nằm trong database. Hãy thử lại!");
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

        private void tsbtn_capnhat_Click(object sender, EventArgs e)
        {
            dgv_hocsinh.DataSource = bus.LoadDataInto_DGVMonHoc();
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
    }
}
