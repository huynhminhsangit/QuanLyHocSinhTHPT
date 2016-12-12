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
    public partial class Form_PhuHuynh : Office2007Form
    {
        #region Toàn cục
        BUS_PhuHuynh bus = new BUS_PhuHuynh();
        BindingSource bs = new BindingSource();
        int donghientai;
        #endregion
        #region Load
        public Form_PhuHuynh()
        {
            InitializeComponent();
        }
        private void Form_PhuHuynh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_LoadDataIntoDB.GIOITINH' table. You can move, or remove it, as needed.
            this.gIOITINHTableAdapter.Fill(this.ds_LoadDataIntoDB.GIOITINH);
            // Load dữ liệu DataGridView
            dgv_phuhuynh.DataSource = bus.LoadDataInto_DGVPhuHuynh();

            // Load Binding
            bs.DataSource = dgv_phuhuynh.DataSource;
            bindingNavigatorPhuHuynh.BindingSource = bs;

            dgv_phuhuynh.AllowUserToAddRows = false;
            dgv_phuhuynh.ReadOnly = true;

            if (dgv_phuhuynh.RowCount > 1)
                donghientai = dgv_phuhuynh.CurrentRow.Index;
            else
                donghientai = 0;
        }
        #endregion
        #region Xử lý btn trên Toolstrip
        private void tsbtn_themmoi_Click(object sender, EventArgs e)
        {
            // Cho phép người dùng thêm dòng mới
            dgv_phuhuynh.AllowUserToAddRows = true;
            // Mở khóa
            dgv_phuhuynh.ReadOnly = false;

            // di chuyển thanh Scroll về cuối DataGridView
            dgv_phuhuynh.FirstDisplayedScrollingRowIndex = dgv_phuhuynh.Rows.Count - 1;

            for (int i = 0; i < dgv_phuhuynh.Rows.Count - 1; ++i)
            {
                dgv_phuhuynh.Rows[i].ReadOnly = true;
            }
        }
        private void tsbtn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.No)
                    return;

                foreach (DataGridViewRow item in dgv_phuhuynh.SelectedRows)
                    dgv_phuhuynh.Rows.Remove(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa đối tượng thất bại. Hãy thử lại!");
            }
        }
        private void tsbtn_sua_Click(object sender, EventArgs e)
        {
            dgv_phuhuynh.AllowUserToAddRows = false;
            // Mở khóa
            dgv_phuhuynh.ReadOnly = false;
            // Mở khóa từng dòng
            for (int i = 0; i < dgv_phuhuynh.Rows.Count - 1; ++i)
                dgv_phuhuynh.Rows[i].ReadOnly = false;
        }
        private void tsbtn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_phuhuynh.CurrentRow != null)
                    dgv_phuhuynh.CurrentCell = dgv_phuhuynh.Rows[dgv_phuhuynh.Rows.Count - 1].Cells[dgv_phuhuynh.CurrentCell.ColumnIndex];

                DataTable dt = (DataTable)dgv_phuhuynh.DataSource; // ép kiểu dữ liệu trong dataGridView là 1 DataTable
                if (bus.Update_All(dt) == false)
                {
                    MessageBox.Show("Lưu lại thất bại!");
                    return;
                }
                else
                    MessageBox.Show("Lưu thành công! Hãy nhấn Refresh để kiểm tra lại.");
            }
            catch
            {
                return;
            }
        }
        private void tsbtn_capnhat_Click(object sender, EventArgs e)
        {
            dgv_phuhuynh.DataSource = bus.LoadDataInto_DGVPhuHuynh();
        }
        private void tsbtn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Xử lý Binding Source
        private void SelectRow()
        {
            dgv_phuhuynh.ClearSelection();
            dgv_phuhuynh.Rows[bs.Position].Selected = true; // Select full row 
            dgv_phuhuynh.FirstDisplayedScrollingRowIndex = donghientai;
        }
        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            donghientai = 0;
            SelectRow();
        }
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (donghientai <= dgv_phuhuynh.Rows.Count)
            {
                dgv_phuhuynh.Rows[donghientai].Selected = false;
                dgv_phuhuynh.Rows[donghientai--].Selected = true;
            }
            SelectRow();
        }
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            if (dgv_phuhuynh.Rows.Count > 1)
            {
                if (donghientai < dgv_phuhuynh.RowCount)
                {
                    dgv_phuhuynh.Rows[donghientai].Selected = false;
                    dgv_phuhuynh.Rows[donghientai++].Selected = true;
                }
            }

            SelectRow();
        }
        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            donghientai = dgv_phuhuynh.Rows.Count - 1;
            SelectRow();
        }
        #endregion  
        #region Kiểm tra sđt hợp lệ
        private void dgv_phuhuynh_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgv_phuhuynh.Columns[3].Index)
                {
                    dgv_phuhuynh.Rows[e.RowIndex].ErrorText = "";

                    if (dgv_phuhuynh.Rows[e.RowIndex].IsNewRow) { return; }
                    if (e.FormattedValue.ToString().Length < 10 || e.FormattedValue.ToString().Length > 11)
                    {
                        e.Cancel = true;
                        dgv_phuhuynh.Rows[e.RowIndex].ErrorText = "SĐT chỉ từ 10 - 11 số";
                    }
                }
            }
            catch
            {
                return;
            }
        }
        #endregion
    }
}
