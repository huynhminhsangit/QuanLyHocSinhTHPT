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
    public partial class Form_KetQuaHocTap : Office2007Form
    {
        #region Toàn cục
        BUS_KetQuaHocTap bus = new BUS_KetQuaHocTap();
        BindingSource bs = new BindingSource();
        int donghientai;
        #endregion
        public Form_KetQuaHocTap()
        {
            InitializeComponent();
        }

        private void Form_KetQuaHocTap_Load(object sender, EventArgs e)
        {
            // Load dữ liệu DataGridView
            dgv_ketquahoctap.DataSource = bus.LoadDataInto_DGVKetQuaHocTap();
            // Load Binding
            bs.DataSource = dgv_ketquahoctap.DataSource;
            bindingNavigatorKetQuaHocTap.BindingSource = bs;

            dgv_ketquahoctap.AllowUserToAddRows = false;
            dgv_ketquahoctap.ReadOnly = true;

            if (dgv_ketquahoctap.RowCount > 1)
                donghientai = dgv_ketquahoctap.CurrentRow.Index;
            else
                donghientai = 0;
        }
        #region Xử lý btn trên Toolstrip
        private void tsbtn_themmoi_Click(object sender, EventArgs e)
        {
            // Cho phép người dùng thêm dòng mới
            dgv_ketquahoctap.AllowUserToAddRows = true;
            // Mở khóa
            dgv_ketquahoctap.ReadOnly = false;

            // di chuyển thanh Scroll về cuối DataGridView
            dgv_ketquahoctap.FirstDisplayedScrollingRowIndex = dgv_ketquahoctap.Rows.Count - 1;

            for (int i = 0; i < dgv_ketquahoctap.Rows.Count - 1; ++i)
            {
                dgv_ketquahoctap.Rows[i].ReadOnly = true;
            }
            bindingNavigatorKetQuaHocTap.BindingSource.MoveLast();
        }

        private void tsbtn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.No)
                    return;

                foreach (DataGridViewRow item in dgv_ketquahoctap.SelectedRows)
                    dgv_ketquahoctap.Rows.Remove(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu này nằm trong database. Hãy thử lại!");
            }
        }

        private void tsbtn_sua_Click(object sender, EventArgs e)
        {
            dgv_ketquahoctap.AllowUserToAddRows = false;
            // Mở khóa
            dgv_ketquahoctap.ReadOnly = false;
            // Mở khóa từng dòng
            for (int i = 0; i < dgv_ketquahoctap.Rows.Count - 1; ++i)
                dgv_ketquahoctap.Rows[i].ReadOnly = false;
        }

        private void tsbtn_luu_Click(object sender, EventArgs e)
        {
            if (dgv_ketquahoctap.CurrentRow != null)
                dgv_ketquahoctap.CurrentCell = dgv_ketquahoctap.Rows[dgv_ketquahoctap.Rows.Count - 1].Cells[dgv_ketquahoctap.CurrentCell.ColumnIndex];

            DataTable dt = (DataTable)dgv_ketquahoctap.DataSource; // ép kiểu dữ liệu trong dataGridView là 1 DataTable

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
            dgv_ketquahoctap.DataSource = bus.LoadDataInto_DGVKetQuaHocTap();
        }

        private void tsbtn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Xử lý Binding Source
        private void SelectRow()
        {
            dgv_ketquahoctap.ClearSelection();
            dgv_ketquahoctap.Rows[bs.Position].Selected = true; // Select full row 
            dgv_ketquahoctap.FirstDisplayedScrollingRowIndex = donghientai;
        }
        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            donghientai = 0;
            SelectRow();
        }
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (donghientai <= dgv_ketquahoctap.Rows.Count)
            {
                dgv_ketquahoctap.Rows[donghientai].Selected = false;
                dgv_ketquahoctap.Rows[donghientai--].Selected = true;
            }
            SelectRow();
        }
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            if (dgv_ketquahoctap.Rows.Count > 1)
            {
                if (donghientai < dgv_ketquahoctap.RowCount)
                {
                    dgv_ketquahoctap.Rows[donghientai].Selected = false;
                    dgv_ketquahoctap.Rows[donghientai++].Selected = true;
                }
            }

            SelectRow();
        }
        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            donghientai = dgv_ketquahoctap.Rows.Count - 1;
            SelectRow();
        }
        #endregion
    }
}
