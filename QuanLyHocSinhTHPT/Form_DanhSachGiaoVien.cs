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
    public partial class Form_DanhSachGiaoVien : Office2007Form
    {
        BUS_GiaoVien bus_giaovien = new BUS_GiaoVien();
        BUS_MonHoc bus_monhoc = new BUS_MonHoc();
        public Form_DanhSachGiaoVien()
        {
            InitializeComponent();
        }

    

       private void Form_DanhSachGiaoVien_Load(object sender, EventArgs e)
       {
          
           //load ten mon hoc trong combobox mon hoc
           cbb_monday.DataSource = bus_monhoc.LoadDataInto_DGVMonHoc();
           cbb_monday.DisplayMember = "TENMONHOC";
           cbb_monday.ValueMember = "MAMONHOC";

       }

       private void cbb_monday_SelectedIndexChanged(object sender, EventArgs e)
       {
           dgv_giaovien.DataSource = bus_monhoc.timkiem_monday(cbb_monday.SelectedValue.ToString());
       }

     

     
    }
}
