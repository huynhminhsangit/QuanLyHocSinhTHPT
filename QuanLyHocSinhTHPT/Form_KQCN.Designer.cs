namespace QuanLyHocSinhTHPT
{
    partial class Form_KQCN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_KQCN));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navPaneLeft = new DevComponents.DotNetBar.NavigationPane();
            this.navPanelNhapDuLieu = new DevComponents.DotNetBar.NavigationPanePanel();
            this.btn_hienthidanhsach = new DevComponents.DotNetBar.ButtonX();
            this.label01 = new System.Windows.Forms.Label();
            this.label02 = new System.Windows.Forms.Label();
            this.cbb_namhoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbb_lop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemNhapDuLieu = new DevComponents.DotNetBar.ButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_inbangdiem = new DevComponents.DotNetBar.ButtonX();
            this.lbl_gvcn = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.lbl_lop = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.lbl_namhoc = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgv_diemso = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navPaneLeft.SuspendLayout();
            this.navPanelNhapDuLieu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_diemso)).BeginInit();
            this.SuspendLayout();
            // 
            // navPaneLeft
            // 
            this.navPaneLeft.CanCollapse = true;
            this.navPaneLeft.Controls.Add(this.navPanelNhapDuLieu);
            this.navPaneLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.navPaneLeft.Font = new System.Drawing.Font("Arial", 10F);
            this.navPaneLeft.ItemPaddingBottom = 2;
            this.navPaneLeft.ItemPaddingTop = 2;
            this.navPaneLeft.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.buttonItemNhapDuLieu});
            this.navPaneLeft.Location = new System.Drawing.Point(0, 0);
            this.navPaneLeft.Margin = new System.Windows.Forms.Padding(4);
            this.navPaneLeft.Name = "navPaneLeft";
            this.navPaneLeft.NavigationBarHeight = 68;
            this.navPaneLeft.Padding = new System.Windows.Forms.Padding(1);
            this.navPaneLeft.Size = new System.Drawing.Size(201, 465);
            this.navPaneLeft.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPaneLeft.TabIndex = 5;
            // 
            // 
            // 
            this.navPaneLeft.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPaneLeft.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPaneLeft.TitlePanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navPaneLeft.TitlePanel.Location = new System.Drawing.Point(1, 1);
            this.navPaneLeft.TitlePanel.Margin = new System.Windows.Forms.Padding(4);
            this.navPaneLeft.TitlePanel.Name = "panelTitle";
            this.navPaneLeft.TitlePanel.Size = new System.Drawing.Size(199, 30);
            this.navPaneLeft.TitlePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navPaneLeft.TitlePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.navPaneLeft.TitlePanel.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.navPaneLeft.TitlePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navPaneLeft.TitlePanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.navPaneLeft.TitlePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navPaneLeft.TitlePanel.Style.GradientAngle = 90;
            this.navPaneLeft.TitlePanel.Style.MarginLeft = 4;
            this.navPaneLeft.TitlePanel.TabIndex = 0;
            this.navPaneLeft.TitlePanel.Text = "Bảng điểm cả năm";
            // 
            // navPanelNhapDuLieu
            // 
            this.navPanelNhapDuLieu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPanelNhapDuLieu.Controls.Add(this.btn_hienthidanhsach);
            this.navPanelNhapDuLieu.Controls.Add(this.label01);
            this.navPanelNhapDuLieu.Controls.Add(this.label02);
            this.navPanelNhapDuLieu.Controls.Add(this.cbb_namhoc);
            this.navPanelNhapDuLieu.Controls.Add(this.cbb_lop);
            this.navPanelNhapDuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navPanelNhapDuLieu.Font = new System.Drawing.Font("Arial", 10F);
            this.navPanelNhapDuLieu.Location = new System.Drawing.Point(1, 31);
            this.navPanelNhapDuLieu.Margin = new System.Windows.Forms.Padding(4);
            this.navPanelNhapDuLieu.Name = "navPanelNhapDuLieu";
            this.navPanelNhapDuLieu.ParentItem = this.buttonItem1;
            this.navPanelNhapDuLieu.Size = new System.Drawing.Size(199, 365);
            this.navPanelNhapDuLieu.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navPanelNhapDuLieu.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.navPanelNhapDuLieu.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.navPanelNhapDuLieu.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navPanelNhapDuLieu.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.navPanelNhapDuLieu.Style.GradientAngle = 90;
            this.navPanelNhapDuLieu.TabIndex = 1;
            // 
            // btn_hienthidanhsach
            // 
            this.btn_hienthidanhsach.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_hienthidanhsach.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btn_hienthidanhsach.Enabled = false;
            this.btn_hienthidanhsach.Location = new System.Drawing.Point(15, 153);
            this.btn_hienthidanhsach.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hienthidanhsach.Name = "btn_hienthidanhsach";
            this.btn_hienthidanhsach.Size = new System.Drawing.Size(171, 28);
            this.btn_hienthidanhsach.TabIndex = 10;
            this.btn_hienthidanhsach.Text = "Lấy danh sách";
            this.btn_hienthidanhsach.Click += new System.EventHandler(this.btn_hienthidanhsach_Click);
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.Location = new System.Drawing.Point(11, 12);
            this.label01.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(67, 16);
            this.label01.TabIndex = 0;
            this.label01.Text = "Năm học:";
            // 
            // label02
            // 
            this.label02.AutoSize = true;
            this.label02.Location = new System.Drawing.Point(11, 65);
            this.label02.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(37, 16);
            this.label02.TabIndex = 0;
            this.label02.Text = "Lớp:";
            // 
            // cbb_namhoc
            // 
            this.cbb_namhoc.DisplayMember = "Text";
            this.cbb_namhoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_namhoc.FormattingEnabled = true;
            this.cbb_namhoc.ItemHeight = 17;
            this.cbb_namhoc.Location = new System.Drawing.Point(15, 34);
            this.cbb_namhoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_namhoc.Name = "cbb_namhoc";
            this.cbb_namhoc.Size = new System.Drawing.Size(172, 23);
            this.cbb_namhoc.TabIndex = 1;
            this.cbb_namhoc.SelectedIndexChanged += new System.EventHandler(this.cbb_namhoc_SelectedIndexChanged);
            // 
            // cbb_lop
            // 
            this.cbb_lop.DisplayMember = "Text";
            this.cbb_lop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_lop.FormattingEnabled = true;
            this.cbb_lop.ItemHeight = 17;
            this.cbb_lop.Location = new System.Drawing.Point(15, 88);
            this.cbb_lop.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_lop.Name = "cbb_lop";
            this.cbb_lop.Size = new System.Drawing.Size(171, 23);
            this.cbb_lop.TabIndex = 3;
            this.cbb_lop.SelectedIndexChanged += new System.EventHandler(this.cbb_lop_SelectedIndexChanged);
            // 
            // buttonItem1
            // 
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.Checked = true;
            this.buttonItem1.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem1.Image")));
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.OptionGroup = "navBar";
            this.buttonItem1.Text = "Bảng điểm cả năm";
            // 
            // buttonItemNhapDuLieu
            // 
            this.buttonItemNhapDuLieu.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemNhapDuLieu.Image")));
            this.buttonItemNhapDuLieu.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.buttonItemNhapDuLieu.Name = "buttonItemNhapDuLieu";
            this.buttonItemNhapDuLieu.OptionGroup = "navBar";
            this.buttonItemNhapDuLieu.Text = "Nhập điểm học sinh";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_inbangdiem);
            this.panel1.Controls.Add(this.lbl_gvcn);
            this.panel1.Controls.Add(this.labelX9);
            this.panel1.Controls.Add(this.lbl_lop);
            this.panel1.Controls.Add(this.labelX5);
            this.panel1.Controls.Add(this.lbl_namhoc);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Location = new System.Drawing.Point(209, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 111);
            this.panel1.TabIndex = 11;
            // 
            // btn_inbangdiem
            // 
            this.btn_inbangdiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_inbangdiem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_inbangdiem.Location = new System.Drawing.Point(446, 61);
            this.btn_inbangdiem.Name = "btn_inbangdiem";
            this.btn_inbangdiem.Size = new System.Drawing.Size(200, 32);
            this.btn_inbangdiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_inbangdiem.TabIndex = 9;
            this.btn_inbangdiem.Text = "In bảng điểm";
            this.btn_inbangdiem.Click += new System.EventHandler(this.btn_inbangdiem_Click);
            // 
            // lbl_gvcn
            // 
            this.lbl_gvcn.AutoSize = true;
            // 
            // 
            // 
            this.lbl_gvcn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_gvcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_gvcn.Location = new System.Drawing.Point(90, 75);
            this.lbl_gvcn.Name = "lbl_gvcn";
            this.lbl_gvcn.Size = new System.Drawing.Size(56, 18);
            this.lbl_gvcn.TabIndex = 8;
            this.lbl_gvcn.Text = "_______";
            // 
            // labelX9
            // 
            this.labelX9.AutoSize = true;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(25, 75);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(45, 18);
            this.labelX9.TabIndex = 7;
            this.labelX9.Text = "GVCN:";
            // 
            // lbl_lop
            // 
            this.lbl_lop.AutoSize = true;
            // 
            // 
            // 
            this.lbl_lop.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_lop.Location = new System.Drawing.Point(240, 46);
            this.lbl_lop.Name = "lbl_lop";
            this.lbl_lop.Size = new System.Drawing.Size(56, 18);
            this.lbl_lop.TabIndex = 4;
            this.lbl_lop.Text = "_______";
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(206, 46);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(28, 18);
            this.labelX5.TabIndex = 3;
            this.labelX5.Text = "Lớp:";
            // 
            // lbl_namhoc
            // 
            this.lbl_namhoc.AutoSize = true;
            // 
            // 
            // 
            this.lbl_namhoc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_namhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_namhoc.Location = new System.Drawing.Point(90, 46);
            this.lbl_namhoc.Name = "lbl_namhoc";
            this.lbl_namhoc.Size = new System.Drawing.Size(56, 18);
            this.lbl_namhoc.TabIndex = 2;
            this.lbl_namhoc.Text = "_______";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(25, 46);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(59, 18);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Năm học:";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.labelX1.Location = new System.Drawing.Point(25, 4);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(203, 27);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "BẢNG ĐIỂM CẢ NĂM";
            // 
            // dgv_diemso
            // 
            this.dgv_diemso.AllowUserToAddRows = false;
            this.dgv_diemso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_diemso.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_diemso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_diemso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_diemso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_diemso.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_diemso.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_diemso.Location = new System.Drawing.Point(209, 114);
            this.dgv_diemso.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_diemso.Name = "dgv_diemso";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_diemso.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_diemso.Size = new System.Drawing.Size(824, 302);
            this.dgv_diemso.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaHocSinh";
            this.Column1.HeaderText = "Mã học sinh";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "HoTenHocSinh";
            this.Column2.FillWeight = 200F;
            this.Column2.HeaderText = "Họ & tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "DTBHocKy1";
            this.Column3.HeaderText = "ĐTB Học kỳ 1";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "DTBHocKy2";
            this.Column4.HeaderText = "ĐTB Học kỳ 2";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "DTBCaNam";
            this.Column5.HeaderText = "ĐTB Cả năm";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Form_KQCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 465);
            this.Controls.Add(this.dgv_diemso);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.navPaneLeft);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_KQCN";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KẾT QUẢ CẢ NĂM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_KQCN_Load);
            this.navPaneLeft.ResumeLayout(false);
            this.navPanelNhapDuLieu.ResumeLayout(false);
            this.navPanelNhapDuLieu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_diemso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.NavigationPane navPaneLeft;
        private DevComponents.DotNetBar.NavigationPanePanel navPanelNhapDuLieu;
        private DevComponents.DotNetBar.ButtonX btn_hienthidanhsach;
        private System.Windows.Forms.Label label01;
        private System.Windows.Forms.Label label02;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_namhoc;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_lop;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItemNhapDuLieu;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btn_inbangdiem;
        private DevComponents.DotNetBar.LabelX lbl_gvcn;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX lbl_lop;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX lbl_namhoc;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_diemso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}