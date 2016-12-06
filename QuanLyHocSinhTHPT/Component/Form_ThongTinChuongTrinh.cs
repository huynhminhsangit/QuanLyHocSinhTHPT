using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using BUS;
using DTO;

namespace QuanLyHocSinhTHPT.Component
{
    public partial class Form_ThongTinChuongTrinh : Office2007Form
    {
        public Form_ThongTinChuongTrinh()
        {
            InitializeComponent();
        }

        private void Form_ThongTinChuongTrinh_Load(object sender, EventArgs e)
        {
            this.linkLabel1.Links.Add(0, 25, "mailto:huynhminhsangit@gmail.com");
            this.linkLabel2.Links.Add(0, 25, "mailto:vubingboong0310@gmail.com");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("mailto:"))
                Process.Start(strURL + "?subject=Feedback for program QuanLyHocSinhTHPT");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("mailto:"))
                Process.Start(strURL + "?subject=Feedback for program QuanLyHocSinhTHPT");
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
