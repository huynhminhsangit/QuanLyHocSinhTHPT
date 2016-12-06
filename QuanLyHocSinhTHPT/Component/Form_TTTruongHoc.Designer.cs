namespace QuanLyHocSinhTHPT.Component
{
    partial class Form_TTTruongHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_tentruong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_diachi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btn_dongy = new DevComponents.DotNetBar.ButtonX();
            this.btn_huybo = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(13, 56);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(71, 18);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tên trường:";
            // 
            // txt_tentruong
            // 
            this.txt_tentruong.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.txt_tentruong.Border.Class = "TextBoxBorder";
            this.txt_tentruong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_tentruong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tentruong.Location = new System.Drawing.Point(92, 55);
            this.txt_tentruong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tentruong.Name = "txt_tentruong";
            this.txt_tentruong.Size = new System.Drawing.Size(294, 23);
            this.txt_tentruong.TabIndex = 1;
            // 
            // txt_diachi
            // 
            this.txt_diachi.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.txt_diachi.Border.Class = "TextBoxBorder";
            this.txt_diachi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_diachi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_diachi.Location = new System.Drawing.Point(92, 95);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(294, 23);
            this.txt_diachi.TabIndex = 3;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(13, 96);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(47, 18);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Địa chỉ:";
            // 
            // btn_dongy
            // 
            this.btn_dongy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_dongy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_dongy.Location = new System.Drawing.Point(92, 154);
            this.btn_dongy.Name = "btn_dongy";
            this.btn_dongy.Size = new System.Drawing.Size(88, 25);
            this.btn_dongy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_dongy.TabIndex = 4;
            this.btn_dongy.Text = "Đồng ý";
            // 
            // btn_huybo
            // 
            this.btn_huybo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_huybo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_huybo.Location = new System.Drawing.Point(199, 154);
            this.btn_huybo.Name = "btn_huybo";
            this.btn_huybo.Size = new System.Drawing.Size(88, 25);
            this.btn_huybo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_huybo.TabIndex = 5;
            this.btn_huybo.Text = "Hủy bỏ";
            // 
            // Form_TTTruongHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 215);
            this.Controls.Add(this.btn_huybo);
            this.Controls.Add(this.btn_dongy);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txt_tentruong);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_TTTruongHoc";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN TRƯỜNG HỌC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_tentruong;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_diachi;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btn_dongy;
        private DevComponents.DotNetBar.ButtonX btn_huybo;
    }
}