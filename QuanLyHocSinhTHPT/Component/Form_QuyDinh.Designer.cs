namespace QuanLyHocSinhTHPT.Component
{
    partial class Form_QuyDinh
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanelDoTuoi = new DevComponents.DotNetBar.TabControlPanel();
            this.iinput_dotuoitoida = new DevComponents.Editors.IntegerInput();
            this.iinput_dotuoitoithieu = new DevComponents.Editors.IntegerInput();
            this.labelX02 = new DevComponents.DotNetBar.LabelX();
            this.labelX01 = new DevComponents.DotNetBar.LabelX();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanelThangDiem = new DevComponents.DotNetBar.TabControlPanel();
            this.rdb_thangdiem100 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.rdb_thangdiem10 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX05 = new DevComponents.DotNetBar.LabelX();
            this.tabItem3 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanelSiSo = new DevComponents.DotNetBar.TabControlPanel();
            this.integerInput1 = new DevComponents.Editors.IntegerInput();
            this.integerInput2 = new DevComponents.Editors.IntegerInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_huybo = new DevComponents.DotNetBar.ButtonX();
            this.btn_dongy = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanelDoTuoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iinput_dotuoitoida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iinput_dotuoitoithieu)).BeginInit();
            this.tabControlPanelThangDiem.SuspendLayout();
            this.tabControlPanelSiSo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanelThangDiem);
            this.tabControl1.Controls.Add(this.tabControlPanelSiSo);
            this.tabControl1.Controls.Add(this.tabControlPanelDoTuoi);
            this.tabControl1.Location = new System.Drawing.Point(-4, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 2;
            this.tabControl1.Size = new System.Drawing.Size(501, 188);
            this.tabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem2);
            this.tabControl1.Tabs.Add(this.tabItem3);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabControlPanelDoTuoi
            // 
            this.tabControlPanelDoTuoi.Controls.Add(this.iinput_dotuoitoida);
            this.tabControlPanelDoTuoi.Controls.Add(this.iinput_dotuoitoithieu);
            this.tabControlPanelDoTuoi.Controls.Add(this.labelX02);
            this.tabControlPanelDoTuoi.Controls.Add(this.labelX01);
            this.tabControlPanelDoTuoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanelDoTuoi.Location = new System.Drawing.Point(0, 25);
            this.tabControlPanelDoTuoi.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlPanelDoTuoi.Name = "tabControlPanelDoTuoi";
            this.tabControlPanelDoTuoi.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanelDoTuoi.Size = new System.Drawing.Size(501, 163);
            this.tabControlPanelDoTuoi.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabControlPanelDoTuoi.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabControlPanelDoTuoi.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanelDoTuoi.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabControlPanelDoTuoi.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanelDoTuoi.Style.GradientAngle = 90;
            this.tabControlPanelDoTuoi.TabIndex = 1;
            this.tabControlPanelDoTuoi.TabItem = this.tabItem1;
            // 
            // iinput_dotuoitoida
            // 
            // 
            // 
            // 
            this.iinput_dotuoitoida.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.iinput_dotuoitoida.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.iinput_dotuoitoida.Location = new System.Drawing.Point(203, 91);
            this.iinput_dotuoitoida.Margin = new System.Windows.Forms.Padding(4);
            this.iinput_dotuoitoida.Name = "iinput_dotuoitoida";
            this.iinput_dotuoitoida.ShowUpDown = true;
            this.iinput_dotuoitoida.Size = new System.Drawing.Size(221, 23);
            this.iinput_dotuoitoida.TabIndex = 6;
            // 
            // iinput_dotuoitoithieu
            // 
            // 
            // 
            // 
            this.iinput_dotuoitoithieu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.iinput_dotuoitoithieu.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.iinput_dotuoitoithieu.Location = new System.Drawing.Point(203, 41);
            this.iinput_dotuoitoithieu.Margin = new System.Windows.Forms.Padding(4);
            this.iinput_dotuoitoithieu.Name = "iinput_dotuoitoithieu";
            this.iinput_dotuoitoithieu.ShowUpDown = true;
            this.iinput_dotuoitoithieu.Size = new System.Drawing.Size(221, 23);
            this.iinput_dotuoitoithieu.TabIndex = 5;
            // 
            // labelX02
            // 
            this.labelX02.AutoSize = true;
            this.labelX02.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX02.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX02.Location = new System.Drawing.Point(49, 91);
            this.labelX02.Margin = new System.Windows.Forms.Padding(4);
            this.labelX02.Name = "labelX02";
            this.labelX02.Size = new System.Drawing.Size(84, 18);
            this.labelX02.TabIndex = 3;
            this.labelX02.Text = "Độ tuổi tối đa:";
            // 
            // labelX01
            // 
            this.labelX01.AutoSize = true;
            this.labelX01.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX01.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX01.Location = new System.Drawing.Point(49, 41);
            this.labelX01.Margin = new System.Windows.Forms.Padding(4);
            this.labelX01.Name = "labelX01";
            this.labelX01.Size = new System.Drawing.Size(99, 18);
            this.labelX01.TabIndex = 4;
            this.labelX01.Text = "Độ tuổi tối thiểu:";
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanelDoTuoi;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "Độ tuổi";
            // 
            // tabControlPanelThangDiem
            // 
            this.tabControlPanelThangDiem.Controls.Add(this.rdb_thangdiem100);
            this.tabControlPanelThangDiem.Controls.Add(this.rdb_thangdiem10);
            this.tabControlPanelThangDiem.Controls.Add(this.labelX05);
            this.tabControlPanelThangDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanelThangDiem.Location = new System.Drawing.Point(0, 25);
            this.tabControlPanelThangDiem.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlPanelThangDiem.Name = "tabControlPanelThangDiem";
            this.tabControlPanelThangDiem.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanelThangDiem.Size = new System.Drawing.Size(501, 163);
            this.tabControlPanelThangDiem.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabControlPanelThangDiem.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabControlPanelThangDiem.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanelThangDiem.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabControlPanelThangDiem.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanelThangDiem.Style.GradientAngle = 90;
            this.tabControlPanelThangDiem.TabIndex = 3;
            this.tabControlPanelThangDiem.TabItem = this.tabItem3;
            // 
            // rdb_thangdiem100
            // 
            this.rdb_thangdiem100.AutoSize = true;
            this.rdb_thangdiem100.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.rdb_thangdiem100.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rdb_thangdiem100.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.rdb_thangdiem100.Location = new System.Drawing.Point(105, 96);
            this.rdb_thangdiem100.Name = "rdb_thangdiem100";
            this.rdb_thangdiem100.Size = new System.Drawing.Size(119, 18);
            this.rdb_thangdiem100.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rdb_thangdiem100.TabIndex = 5;
            this.rdb_thangdiem100.Text = "Thang điểm 100";
            // 
            // rdb_thangdiem10
            // 
            this.rdb_thangdiem10.AutoSize = true;
            this.rdb_thangdiem10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.rdb_thangdiem10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rdb_thangdiem10.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.rdb_thangdiem10.Location = new System.Drawing.Point(105, 72);
            this.rdb_thangdiem10.Name = "rdb_thangdiem10";
            this.rdb_thangdiem10.Size = new System.Drawing.Size(111, 18);
            this.rdb_thangdiem10.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rdb_thangdiem10.TabIndex = 4;
            this.rdb_thangdiem10.Text = "Thang điểm 10";
            // 
            // labelX05
            // 
            this.labelX05.AutoSize = true;
            this.labelX05.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX05.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX05.Location = new System.Drawing.Point(91, 36);
            this.labelX05.Name = "labelX05";
            this.labelX05.Size = new System.Drawing.Size(309, 18);
            this.labelX05.TabIndex = 3;
            this.labelX05.Text = "Thang điểm sử dụng để đánh giá kết quả học tập là:";
            // 
            // tabItem3
            // 
            this.tabItem3.AttachedControl = this.tabControlPanelThangDiem;
            this.tabItem3.Name = "tabItem3";
            this.tabItem3.Text = "Thang điểm";
            // 
            // tabControlPanelSiSo
            // 
            this.tabControlPanelSiSo.Controls.Add(this.integerInput1);
            this.tabControlPanelSiSo.Controls.Add(this.integerInput2);
            this.tabControlPanelSiSo.Controls.Add(this.labelX1);
            this.tabControlPanelSiSo.Controls.Add(this.labelX2);
            this.tabControlPanelSiSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanelSiSo.Location = new System.Drawing.Point(0, 25);
            this.tabControlPanelSiSo.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlPanelSiSo.Name = "tabControlPanelSiSo";
            this.tabControlPanelSiSo.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanelSiSo.Size = new System.Drawing.Size(501, 163);
            this.tabControlPanelSiSo.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabControlPanelSiSo.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabControlPanelSiSo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanelSiSo.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabControlPanelSiSo.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanelSiSo.Style.GradientAngle = 90;
            this.tabControlPanelSiSo.TabIndex = 2;
            this.tabControlPanelSiSo.TabItem = this.tabItem2;
            // 
            // integerInput1
            // 
            // 
            // 
            // 
            this.integerInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInput1.Location = new System.Drawing.Point(203, 97);
            this.integerInput1.Margin = new System.Windows.Forms.Padding(4);
            this.integerInput1.Name = "integerInput1";
            this.integerInput1.ShowUpDown = true;
            this.integerInput1.Size = new System.Drawing.Size(221, 23);
            this.integerInput1.TabIndex = 10;
            // 
            // integerInput2
            // 
            // 
            // 
            // 
            this.integerInput2.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInput2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerInput2.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInput2.Location = new System.Drawing.Point(203, 47);
            this.integerInput2.Margin = new System.Windows.Forms.Padding(4);
            this.integerInput2.Name = "integerInput2";
            this.integerInput2.ShowUpDown = true;
            this.integerInput2.Size = new System.Drawing.Size(221, 23);
            this.integerInput2.TabIndex = 9;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(27, 97);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(138, 18);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "Sĩ số tối đa trong 1 lớp:";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(27, 47);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(152, 18);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "Sĩ số tối thiểu trong 1 lớp:";
            // 
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tabControlPanelSiSo;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "Sĩ số";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_huybo);
            this.panel1.Controls.Add(this.btn_dongy);
            this.panel1.Location = new System.Drawing.Point(-4, 188);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 73);
            this.panel1.TabIndex = 1;
            // 
            // btn_huybo
            // 
            this.btn_huybo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_huybo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_huybo.Location = new System.Drawing.Point(335, 21);
            this.btn_huybo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_huybo.Name = "btn_huybo";
            this.btn_huybo.Size = new System.Drawing.Size(116, 32);
            this.btn_huybo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_huybo.TabIndex = 1;
            this.btn_huybo.Text = "Hủy bỏ";
            // 
            // btn_dongy
            // 
            this.btn_dongy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_dongy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_dongy.Location = new System.Drawing.Point(203, 21);
            this.btn_dongy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dongy.Name = "btn_dongy";
            this.btn_dongy.Size = new System.Drawing.Size(116, 32);
            this.btn_dongy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_dongy.TabIndex = 0;
            this.btn_dongy.Text = "Đồng ý";
            // 
            // Form_QuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 263);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_QuyDinh";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUY ĐỊNH";
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanelDoTuoi.ResumeLayout(false);
            this.tabControlPanelDoTuoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iinput_dotuoitoida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iinput_dotuoitoithieu)).EndInit();
            this.tabControlPanelThangDiem.ResumeLayout(false);
            this.tabControlPanelThangDiem.PerformLayout();
            this.tabControlPanelSiSo.ResumeLayout(false);
            this.tabControlPanelSiSo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanelDoTuoi;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanelSiSo;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanelThangDiem;
        private DevComponents.DotNetBar.TabItem tabItem3;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btn_huybo;
        private DevComponents.DotNetBar.ButtonX btn_dongy;
        private DevComponents.Editors.IntegerInput iinput_dotuoitoida;
        private DevComponents.Editors.IntegerInput iinput_dotuoitoithieu;
        private DevComponents.DotNetBar.LabelX labelX02;
        private DevComponents.DotNetBar.LabelX labelX01;
        private DevComponents.Editors.IntegerInput integerInput1;
        private DevComponents.Editors.IntegerInput integerInput2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX05;
        private DevComponents.DotNetBar.Controls.CheckBoxX rdb_thangdiem100;
        private DevComponents.DotNetBar.Controls.CheckBoxX rdb_thangdiem10;
    }
}