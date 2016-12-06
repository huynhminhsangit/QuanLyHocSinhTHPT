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
    public partial class Form_PhanLop : Office2007Form
    {
        #region Toàn cục
        BUS_PhanLop bus = new BUS_PhanLop();
        BindingSource bs = new BindingSource();
        int donghientai;
        #endregion
        public Form_PhanLop()
        {
            InitializeComponent();
        }

        private void Form_PhanLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_LoadDataIntoDB.NAMHOC' table. You can move, or remove it, as needed.
            this.nAMHOCTableAdapter.Fill(this.ds_LoadDataIntoDB.NAMHOC);
            // TODO: This line of code loads data into the 'ds_LoadDataIntoDB.HOCSINH' table. You can move, or remove it, as needed.
            this.hOCSINHTableAdapter.Fill(this.ds_LoadDataIntoDB.HOCSINH);
            // TODO: This line of code loads data into the 'ds_LoadDataIntoDB.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.ds_LoadDataIntoDB.LOP);
            // Load dữ liệu DataGridView
            dgv_phanlop.DataSource = bus.LoadDataInto_DGVPhanLop();
            // Load Binding
            bs.DataSource = dgv_phanlop.DataSource;
            bindingNavigatorPhanLop.BindingSource = bs;

            dgv_phanlop.AllowUserToAddRows = false;
            dgv_phanlop.ReadOnly = true;

            if (dgv_phanlop.RowCount > 1)
                donghientai = dgv_phanlop.CurrentRow.Index;
            else
                donghientai = 0;
        }
        #region Xử lý btn trên Toolstrip
        private void tsbtn_themmoi_Click(object sender, EventArgs e)
        {
            // Cho phép người dùng thêm dòng mới
            dgv_phanlop.AllowUserToAddRows = true;
            // Mở khóa
            dgv_phanlop.ReadOnly = false;

            // di chuyển thanh Scroll về cuối DataGridView
            dgv_phanlop.FirstDisplayedScrollingRowIndex = dgv_phanlop.Rows.Count - 1;

            for (int i = 0; i < dgv_phanlop.Rows.Count - 1; ++i)
            {
                dgv_phanlop.Rows[i].ReadOnly = true;
            }
        }

        private void tsbtn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.No)
                    return;

                foreach (DataGridViewRow item in dgv_phanlop.SelectedRows)
                    dgv_phanlop.Rows.Remove(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không xóa được. Hãy thử lại!");
            }
        }

        private void tsbtn_sua_Click(object sender, EventArgs e)
        {
            dgv_phanlop.AllowUserToAddRows = false;
            // Mở khóa
            dgv_phanlop.ReadOnly = false;
            // Mở khóa từng dòng
            for (int i = 0; i < dgv_phanlop.Rows.Count - 1; ++i)
                dgv_phanlop.Rows[i].ReadOnly = false;
        }

        private void tsbtn_luu_Click(object sender, EventArgs e)
        {
            if (dgv_phanlop.CurrentRow != null)
                dgv_phanlop.CurrentCell = dgv_phanlop.Rows[dgv_phanlop.Rows.Count - 1].Cells[dgv_phanlop.CurrentCell.ColumnIndex];

            DataTable dt = (DataTable)dgv_phanlop.DataSource; // ép kiểu dữ liệu trong dataGridView là 1 DataTable
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
            dgv_phanlop.DataSource = bus.LoadDataInto_DGVPhanLop();
        }

        private void tsbtn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Xử lý Binding Source
        private void SelectRow()
        {
            dgv_phanlop.ClearSelection();
            dgv_phanlop.Rows[bs.Position].Selected = true; // Select full row 
            dgv_phanlop.FirstDisplayedScrollingRowIndex = donghientai;
        }
        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            donghientai = 0;
            SelectRow();
        }
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (donghientai <= dgv_phanlop.Rows.Count)
            {
                dgv_phanlop.Rows[donghientai].Selected = false;
                dgv_phanlop.Rows[donghientai--].Selected = true;
            }
            SelectRow();
        }
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            if (dgv_phanlop.Rows.Count > 1)
            {
                if (donghientai < dgv_phanlop.RowCount)
                {
                    dgv_phanlop.Rows[donghientai].Selected = false;
                    dgv_phanlop.Rows[donghientai++].Selected = true;
                }
            }

            SelectRow();
        }
        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            donghientai = dgv_phanlop.Rows.Count - 1;
            SelectRow();
        }
        #endregion  
    }
}
