using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using QuanLyHocSinhTHPT.Component;
using BUS;
using DTO;

namespace QuanLyHocSinhTHPT
{
    public partial class Form_DangNhap : Office2007Form
    {
        BUS_NguoiDung bus = new BUS_NguoiDung();
        DTO_NguoiDung dto = new DTO_NguoiDung();
        public Form_DangNhap()
        {
            InitializeComponent();
        }

        private void Form_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string tendangnhap = txt_tendangnhap.Text;
            string matkhau = txt_matkhau.Text;
            int count = bus.ReadUserName_PassWord(tendangnhap,matkhau).Rows.Count;

            if (string.IsNullOrEmpty(tendangnhap))
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!");
            else if (string.IsNullOrEmpty(matkhau))
                MessageBox.Show("Bạn chưa nhập mật khẩu!");


            if (count != 0)
            {

                Form_Main.userName = tendangnhap;
                this.Close();
            }

            //if (userName == "admin" && passWord == "admin")
            //{
            //    Form_Main.userName = userName;
            //    this.Close();
            //}
            //else if(userName =="giaovu" && passWord == "giaovu")
            //{
            //    Form_Main.userName = userName;
            //    this.Close();
            //}
            //else
            //    MessageBox.Show("Đăng nhập thất bại!");
        }

        private void btn_huybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
