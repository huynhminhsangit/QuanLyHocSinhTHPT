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
using System.Data.Odbc;
using Office_12 = Microsoft.Office.Interop;
using Excel_12 = Microsoft.Office.Interop.Excel;

namespace QuanLyHocSinhTHPT
{
    public partial class Form_KQCN : Office2007Form
    {
        #region Toàn cục
        BUS_KQHKTheoLop bus = new BUS_KQHKTheoLop();
        BUS_Lop busLop = new BUS_Lop();
        #endregion
        #region Load
        // Lọc lớp theo năm, tránh trùng lặp lại lớp
        private void LocDanhSachLopTheoNamHoc()
        {
            if (cbb_namhoc.SelectedValue == null)
            {
                //dgv_diemso.DataSource = null;
                return;
            }
            else
            {
                // tiến hành lấy các lớp của năm đó và hiển thị lên cbb_lop
                cbb_lop.DataSource = busLop.LayDSLop_TheoNamHoc(cbb_namhoc.SelectedValue.ToString());
                cbb_lop.DisplayMember = "TENLOP";
                cbb_lop.ValueMember = "MALOP";
            }

        }
        public void LoadDataIntoCombobox()
        {
            #region Call Bus
            BUS_NamHoc busNH = new BUS_NamHoc();
            BUS_HocKy busHK = new BUS_HocKy();
            BUS_MonHoc busMH = new BUS_MonHoc();
            #endregion
            #region Load data to cbb
            // cbb_namhoc
            cbb_namhoc.DataSource = busNH.LoadDataInto_DGVNamHoc();
            cbb_namhoc.DisplayMember = "TENNAMHOC";
            cbb_namhoc.ValueMember = "MANAMHOC";
            // cbb_lop
            LocDanhSachLopTheoNamHoc();
            #endregion
        }
        public Form_KQCN()
        {
            InitializeComponent();
        }

        private void Form_KQCN_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            // Load dữ liệu vào cbb
            LoadDataIntoCombobox();
        }
        #endregion
        #region Lấy bảng điểm cả năm
        private void LayBangDiemTrungBinhHSTheoLop_HocKy()
        {
            // Chắc chắn được lớp và học kỳ
            if (cbb_lop.SelectedValue == null)
            {
                dgv_diemso.DataSource = null;
                return;
            }
            else
                bus.LayBangDiemTB_Lop_HocKy(cbb_lop.SelectedValue.ToString());
            // Hiển thị năm học, học kỳ, lớp, giáo viên chủ nhiệm
            lbl_namhoc.Text = cbb_namhoc.Text;
            lbl_lop.Text = cbb_lop.Text;
            lbl_gvcn.Text = busLop.LayTenGiaoVien_TheoMaLop(cbb_lop.SelectedValue.ToString());
        }
        private void cbb_namhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocDanhSachLopTheoNamHoc();
            LayBangDiemTrungBinhHSTheoLop_HocKy();
        }

        private void cbb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LayBangDiemTrungBinhHSTheoLop_HocKy();
            btn_hienthidanhsach.Enabled = true;
        }

        private void btn_hienthidanhsach_Click(object sender, EventArgs e)
        {
            dgv_diemso.DataSource = bus.LayBangDiemTB_Lop_HocKy(cbb_lop.SelectedValue.ToString());
        }
        #endregion
        #region Export To Excel
        private void btn_inbangdiem_Click(object sender, EventArgs e)
        {
            try
            {
                ExportDataGridViewTo_Excel12(dgv_diemso);
            }
            catch { return; }
        }
        public static void ExportDataGridViewTo_Excel12(DataGridView myDataGridViewQuantity)
        {

            Excel_12.Application oExcel_12 = null; //Excel_12 Application 

            Excel_12.Workbook oBook = null; // Excel_12 Workbook 

            Excel_12.Sheets oSheetsColl = null; // Excel_12 Worksheets collection 

            Excel_12.Worksheet oSheet = null; // Excel_12 Worksheet 

            Excel_12.Range oRange = null; // Cell or Range in worksheet 

            Object oMissing = System.Reflection.Missing.Value;


            // Create an instance of Excel_12. 

            oExcel_12 = new Excel_12.Application();


            // Make Excel_12 visible to the user. 

            oExcel_12.Visible = true;


            // Set the UserControl property so Excel_12 won't shut down. 

            oExcel_12.UserControl = true;

            // System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("en-US"); 

            //object file = File_Name;

            //object missing = System.Reflection.Missing.Value;



            // Add a workbook. 

            oBook = oExcel_12.Workbooks.Add(oMissing);

            // Get worksheets collection 

            oSheetsColl = oExcel_12.Worksheets;

            // Get Worksheet "Sheet1" 

            oSheet = (Excel_12.Worksheet)oSheetsColl.get_Item("Sheet1");
            oSheet.Name = "BangDiemCaNam";

            // Tạo phần đầu nếu muốn

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "E1");

            head.MergeCells = true;

            head.Value2 = "BẢNG ĐIỂM CẢ NĂM";

            head.Font.Bold = true;

            head.Font.Name = "Tahoma";

            head.Font.Size = "18";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo vùng hiển thị title
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "E3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền cho dòng title

            rowHead.Interior.ColorIndex = 15;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Export titles 

            for (int j = 0; j < myDataGridViewQuantity.Columns.Count; j++)
            {

                oRange = (Excel_12.Range)oSheet.Cells[3, j + 1];

                oRange.Value2 = myDataGridViewQuantity.Columns[j].HeaderText;

            }

            // Export data 

            for (int i = 0; i < myDataGridViewQuantity.Rows.Count; i++)
            {

                for (int j = 0; j < myDataGridViewQuantity.Columns.Count; j++)
                {
                    oRange = (Excel_12.Range)oSheet.Cells[i + 4, j + 1];

                    oRange.Value2 = myDataGridViewQuantity[j, i].Value;

                }

            }
            // Lưu file 
            oBook.SaveAs("D:\\BangDiemCaNam.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            oBook = null;
            oExcel_12.Quit();
            oExcel_12 = null;
            GC.Collect();
        }
        #endregion      
    }
}
