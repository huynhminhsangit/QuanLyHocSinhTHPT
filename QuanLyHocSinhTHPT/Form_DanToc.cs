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
    public partial class Form_DanToc : Office2007Form
    {
        #region Toàn cục
        BUS_DanToc bus = new BUS_DanToc();
        BindingSource bs = new BindingSource();
        int donghientai;
        #endregion
        #region Form Load
        public Form_DanToc()
        {
            InitializeComponent();
        }
        private void Form_DanToc_Load(object sender, EventArgs e)
        {
            // Load dữ liệu DataGridView
            dgv_dantoc.DataSource = bus.LoadDataInto_DGVDanToc();

            // Load Binding
            bs.DataSource = dgv_dantoc.DataSource;
            bindingNavigatorDanToc.BindingSource = bs;

            dgv_dantoc.AllowUserToAddRows = false;
            dgv_dantoc.ReadOnly = true;

            if (dgv_dantoc.RowCount > 1)
                donghientai = dgv_dantoc.CurrentRow.Index;
            else
                donghientai = 0;
        }
        #endregion
        #region Xử lý btn trên Toolstrip
        private void tsbtn_themmoi_Click(object sender, EventArgs e)
        {
            // Cho phép người dùng thêm dòng mới
            dgv_dantoc.AllowUserToAddRows = true;
            // Mở khóa
            dgv_dantoc.ReadOnly = false;

            // di chuyển thanh Scroll về cuối DataGridView
            dgv_dantoc.FirstDisplayedScrollingRowIndex = dgv_dantoc.Rows.Count - 1;

            for (int i = 0; i < dgv_dantoc.Rows.Count - 1; ++i)
            {
                dgv_dantoc.Rows[i].ReadOnly = true;
            }
        }

        private void tsbtn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.No)
                    return;
                foreach (DataGridViewRow item in dgv_dantoc.SelectedRows)
                    dgv_dantoc.Rows.Remove(item);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không xóa được. Hãy thử lại!");
            }
        }

        private void tsbtn_sua_Click(object sender, EventArgs e)
        {
            dgv_dantoc.AllowUserToAddRows = false;
            // Mở khóa
            dgv_dantoc.ReadOnly = false;
            // Mở khóa từng dòng
            for (int i = 0; i < dgv_dantoc.Rows.Count - 1; ++i)
                dgv_dantoc.Rows[i].ReadOnly = false;
        }

        private void tsbtn_luu_Click(object sender, EventArgs e)
        {
            if (dgv_dantoc.CurrentRow != null)
                dgv_dantoc.CurrentCell = dgv_dantoc.Rows[dgv_dantoc.Rows.Count - 1].Cells[dgv_dantoc.CurrentCell.ColumnIndex];

            DataTable dt = (DataTable)dgv_dantoc.DataSource; // ép kiểu dữ liệu trong dataGridView là 1 DataTable
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
            dgv_dantoc.DataSource = bus.LoadDataInto_DGVDanToc();
        }

        private void tsbtn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Xử lý Binding Source
        private void SelectRow()
        {
            dgv_dantoc.ClearSelection();
            dgv_dantoc.Rows[bs.Position].Selected = true; // Select full row 
            dgv_dantoc.FirstDisplayedScrollingRowIndex = donghientai;
        }
        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            donghientai = 0;
            SelectRow();
        }
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (donghientai <= dgv_dantoc.Rows.Count)
            {
                dgv_dantoc.Rows[donghientai].Selected = false;
                dgv_dantoc.Rows[donghientai--].Selected = true;
            }
            SelectRow();
        }
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            if (dgv_dantoc.Rows.Count > 1)
            {
                if (donghientai < dgv_dantoc.RowCount)
                {
                    dgv_dantoc.Rows[donghientai].Selected = false;
                    dgv_dantoc.Rows[donghientai++].Selected = true;
                }
            }

            SelectRow();
        }
        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            donghientai = dgv_dantoc.Rows.Count - 1;
            SelectRow();
        }
        #endregion  
    }
}
