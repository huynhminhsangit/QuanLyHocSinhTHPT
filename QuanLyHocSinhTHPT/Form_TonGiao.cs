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
    public partial class Form_TonGiao : Office2007Form
    {
        #region Toàn cục
        BUS_TonGiao bus = new BUS_TonGiao();
        BindingSource bs = new BindingSource();
        int donghientai;
        #endregion
        public Form_TonGiao()
        {
            InitializeComponent();
        }
        private void Form_TonGiao_Load(object sender, EventArgs e)
        {
            // Load dữ liệu DataGridView
            dgv_tongiao.DataSource = bus.LoadDataInto_DGVTonGiao();

            // Load Binding
            bs.DataSource = dgv_tongiao.DataSource;
            bindingNavigatorDanToc.BindingSource = bs;

            dgv_tongiao.AllowUserToAddRows = false;
            dgv_tongiao.ReadOnly = true;

            if (dgv_tongiao.RowCount > 1)
                donghientai = dgv_tongiao.CurrentRow.Index;
            else
                donghientai = 0;
        }
        #region Xử lý btn trên Toolstrip
        private void tsbtn_themmoi_Click(object sender, EventArgs e)
        {
            // Cho phép người dùng thêm dòng mới
            dgv_tongiao.AllowUserToAddRows = true;
            // Mở khóa
            dgv_tongiao.ReadOnly = false;

            // di chuyển thanh Scroll về cuối DataGridView
            dgv_tongiao.FirstDisplayedScrollingRowIndex = dgv_tongiao.Rows.Count - 1;

            for (int i = 0; i < dgv_tongiao.Rows.Count - 1; ++i)
            {
                dgv_tongiao.Rows[i].ReadOnly = true;
            }
        }

        private void tsbtn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.No)
                    return;

                foreach (DataGridViewRow item in dgv_tongiao.SelectedRows)
                    dgv_tongiao.Rows.Remove(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa đối tượng thất bại. Hãy thử lại!");
            }
        }

        private void tsbtn_sua_Click(object sender, EventArgs e)
        {
            dgv_tongiao.AllowUserToAddRows = false;
            // Mở khóa
            dgv_tongiao.ReadOnly = false;
            // Mở khóa từng dòng
            for (int i = 0; i < dgv_tongiao.Rows.Count - 1; ++i)
                dgv_tongiao.Rows[i].ReadOnly = false;
        }

        private void tsbtn_luu_Click(object sender, EventArgs e)
        {
            if (dgv_tongiao.CurrentRow != null)
                dgv_tongiao.CurrentCell = dgv_tongiao.Rows[dgv_tongiao.Rows.Count - 1].Cells[dgv_tongiao.CurrentCell.ColumnIndex];

            DataTable dt = (DataTable)dgv_tongiao.DataSource; // ép kiểu dữ liệu trong dataGridView là 1 DataTable
            if (bus.Update_All(dt) == false)
            {
                MessageBox.Show("Lưu lại thất bại! Hãy kiểm tra lại.");
                return;
            }
            else
                MessageBox.Show("Lưu thành công! Hãy nhấn Refresh để kiểm tra lại.");
        }

        private void tsbtn_capnhat_Click(object sender, EventArgs e)
        {
            dgv_tongiao.DataSource = bus.LoadDataInto_DGVTonGiao();
        }

        private void tsbtn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Xử lý Binding Source
        private void SelectRow()
        {
            dgv_tongiao.ClearSelection();
            dgv_tongiao.Rows[bs.Position].Selected = true; // Select full row 
            dgv_tongiao.FirstDisplayedScrollingRowIndex = donghientai;
        }
        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            donghientai = 0;
            SelectRow();
        }
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (donghientai <= dgv_tongiao.Rows.Count)
            {
                dgv_tongiao.Rows[donghientai].Selected = false;
                dgv_tongiao.Rows[donghientai--].Selected = true;
            }
            SelectRow();
        }
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            if (dgv_tongiao.Rows.Count > 1)
            {
                if (donghientai < dgv_tongiao.RowCount)
                {
                    dgv_tongiao.Rows[donghientai].Selected = false;
                    dgv_tongiao.Rows[donghientai++].Selected = true;
                }
            }

            SelectRow();
        }
        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            donghientai = dgv_tongiao.Rows.Count - 1;
            SelectRow();
        }
        #endregion  



    }
}
