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
    public partial class Form_NamHoc : Office2007Form
    {
        BUS_NamHoc bus = new BUS_NamHoc();
        BindingSource bs = new BindingSource();
        int donghientai;
        public Form_NamHoc()
        {
            InitializeComponent();
        }
        private void Form_NamHoc_Load(object sender, EventArgs e)
        {
            // Load dữ liệu DataGridView
            dgv_namhoc.DataSource = bus.LoadDataInto_DGVNamHoc();
            // Load Binding
            bs.DataSource = dgv_namhoc.DataSource;
            bindingNavigatorNamHoc.BindingSource = bs;

            dgv_namhoc.AllowUserToAddRows = false;
            dgv_namhoc.ReadOnly = true;

            if (dgv_namhoc.RowCount > 1)
                donghientai = dgv_namhoc.CurrentRow.Index;
            else
                donghientai = 0;
        }
        #region Xử lý btn trên Toolstrip
        private void tsbtn_themmoi_Click(object sender, EventArgs e)
        {
            // Cho phép người dùng thêm dòng mới
            dgv_namhoc.AllowUserToAddRows = true;
            // Mở khóa
            dgv_namhoc.ReadOnly = false;

            // di chuyển thanh Scroll về cuối DataGridView
            dgv_namhoc.FirstDisplayedScrollingRowIndex = dgv_namhoc.Rows.Count - 1;

            for (int i = 0; i < dgv_namhoc.Rows.Count - 1; ++i)
            {
                dgv_namhoc.Rows[i].ReadOnly = true;
            }
            bindingNavigatorNamHoc.BindingSource.MoveLast();
        }

        private void tsbtn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.No)
                    return;

                foreach (DataGridViewRow item in dgv_namhoc.SelectedRows)
                    dgv_namhoc.Rows.Remove(item);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Dữ liệu này nằm trong database. Hãy thử lại!");
            }
        }

        private void tsbtn_sua_Click(object sender, EventArgs e)
        { 
            dgv_namhoc.AllowUserToAddRows = false;
            // Mở khóa
            dgv_namhoc.ReadOnly = false;
            // Mở khóa từng dòng
            for (int i = 0; i < dgv_namhoc.Rows.Count - 1; ++i)
                dgv_namhoc.Rows[i].ReadOnly = false;
        }

        private void tsbtn_luu_Click(object sender, EventArgs e)
        {
            // Xử lý chuyển con trỏ chuột xuống dòng dưới cùng để hoàn thành dòng vừa edit
            if (dgv_namhoc.CurrentRow != null)
                dgv_namhoc.CurrentCell = dgv_namhoc.Rows[dgv_namhoc.Rows.Count - 1].Cells[dgv_namhoc.CurrentCell.ColumnIndex];

            DataTable dt = (DataTable)dgv_namhoc.DataSource; // ép kiểu dữ liệu trong dataGridView là 1 DataTable

            if (bus.Update_All(dt) == false)
            {
                MessageBox.Show("Trùng MÃ NĂM HỌC, vui lòng thử lại!");
                return;
            }
            else
                MessageBox.Show("Lưu thành công! Hãy nhấn Refresh để kiểm tra lại.");
        }

        private void tsbtn_capnhat_Click(object sender, EventArgs e)
        {
            dgv_namhoc.DataSource = bus.LoadDataInto_DGVNamHoc();
        }

        private void tsbtn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Xử lý Binding Source
        private void SelectRow()
        {
            dgv_namhoc.ClearSelection();
            dgv_namhoc.Rows[bs.Position].Selected = true; // Select full row 
            dgv_namhoc.FirstDisplayedScrollingRowIndex = donghientai;
        }
        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            donghientai = 0;
            SelectRow();
        }
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (donghientai <= dgv_namhoc.Rows.Count)
            {
                dgv_namhoc.Rows[donghientai].Selected = false;
                dgv_namhoc.Rows[donghientai--].Selected = true;
            }
            SelectRow();
        }
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            if (dgv_namhoc.Rows.Count > 1)
            {
                if (donghientai < dgv_namhoc.RowCount)
                {
                    dgv_namhoc.Rows[donghientai].Selected = false;
                    dgv_namhoc.Rows[donghientai++].Selected = true;
                }
            }

            SelectRow();
        }
        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            donghientai = dgv_namhoc.Rows.Count - 1;
            SelectRow();
        }
        #endregion

    }
}
