namespace QuanLyHocSinhTHPT
{
    partial class Form_HocSinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_HocSinh));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navPaneLeft = new DevComponents.DotNetBar.NavigationPane();
            this.navPanelNhapDuLieu = new DevComponents.DotNetBar.NavigationPanePanel();
            this.cbb_gioitinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.cbb_doituong = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txt_mahocsinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lblBuffer = new System.Windows.Forms.Label();
            this.dt_ngaysinh = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnLuuVaoDS = new DevComponents.DotNetBar.ButtonX();
            this.cbb_phuhuynh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbb_dantoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbb_tongiao = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txt_noisinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_hoten = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonItemNhapDuLieu = new DevComponents.DotNetBar.ButtonItem();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.ctx_menu = new DevComponents.DotNetBar.ContextMenuBar();
            this.btn_menu = new DevComponents.DotNetBar.ButtonItem();
            this.btn_themmoi = new DevComponents.DotNetBar.ButtonItem();
            this.btn_xoa = new DevComponents.DotNetBar.ButtonItem();
            this.btn_sua = new DevComponents.DotNetBar.ButtonItem();
            this.btn_luu = new DevComponents.DotNetBar.ButtonItem();
            this.btn_thoat = new DevComponents.DotNetBar.ButtonItem();
            this.dgv_hocsinh = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gIOITINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_LoadDataIntoDB = new QuanLyHocSinhTHPT.ds_LoadDataIntoDB();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dANTOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tONGIAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dOITUONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pHUHUYNHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorHocSinh = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtn_themmoi = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_xoa = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_sua = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_luu = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_capnhat = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_thoat = new System.Windows.Forms.ToolStripButton();
            this.gIOITINHTableAdapter = new QuanLyHocSinhTHPT.ds_LoadDataIntoDBTableAdapters.GIOITINHTableAdapter();
            this.dANTOCTableAdapter = new QuanLyHocSinhTHPT.ds_LoadDataIntoDBTableAdapters.DANTOCTableAdapter();
            this.tONGIAOTableAdapter = new QuanLyHocSinhTHPT.ds_LoadDataIntoDBTableAdapters.TONGIAOTableAdapter();
            this.dOITUONGTableAdapter = new QuanLyHocSinhTHPT.ds_LoadDataIntoDBTableAdapters.DOITUONGTableAdapter();
            this.pHUHUYNHTableAdapter = new QuanLyHocSinhTHPT.ds_LoadDataIntoDBTableAdapters.PHUHUYNHTableAdapter();
            this.navPaneLeft.SuspendLayout();
            this.navPanelNhapDuLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaysinh)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctx_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hocsinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIOITINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_LoadDataIntoDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANTOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tONGIAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOITUONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUHUYNHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocSinh)).BeginInit();
            this.bindingNavigatorHocSinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPaneLeft
            // 
            this.navPaneLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.navPaneLeft.CanCollapse = true;
            this.navPaneLeft.Controls.Add(this.navPanelNhapDuLieu);
            this.navPaneLeft.ItemPaddingBottom = 2;
            this.navPaneLeft.ItemPaddingTop = 2;
            this.navPaneLeft.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemNhapDuLieu});
            this.navPaneLeft.Location = new System.Drawing.Point(0, 0);
            this.navPaneLeft.Name = "navPaneLeft";
            this.navPaneLeft.NavigationBarHeight = 67;
            this.navPaneLeft.Padding = new System.Windows.Forms.Padding(1);
            this.navPaneLeft.Size = new System.Drawing.Size(195, 617);
            this.navPaneLeft.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPaneLeft.TabIndex = 1;
            // 
            // 
            // 
            this.navPaneLeft.TitlePanel.AntiAlias = false;
            this.navPaneLeft.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPaneLeft.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPaneLeft.TitlePanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navPaneLeft.TitlePanel.Location = new System.Drawing.Point(1, 1);
            this.navPaneLeft.TitlePanel.Name = "panelTitle";
            this.navPaneLeft.TitlePanel.Size = new System.Drawing.Size(193, 24);
            this.navPaneLeft.TitlePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navPaneLeft.TitlePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.navPaneLeft.TitlePanel.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.navPaneLeft.TitlePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navPaneLeft.TitlePanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.navPaneLeft.TitlePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navPaneLeft.TitlePanel.Style.GradientAngle = 90;
            this.navPaneLeft.TitlePanel.Style.MarginLeft = 4;
            this.navPaneLeft.TitlePanel.TabIndex = 0;
            this.navPaneLeft.TitlePanel.Text = "Thêm mới thông tin";
            // 
            // navPanelNhapDuLieu
            // 
            this.navPanelNhapDuLieu.AutoScroll = true;
            this.navPanelNhapDuLieu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPanelNhapDuLieu.Controls.Add(this.cbb_gioitinh);
            this.navPanelNhapDuLieu.Controls.Add(this.labelX9);
            this.navPanelNhapDuLieu.Controls.Add(this.labelX8);
            this.navPanelNhapDuLieu.Controls.Add(this.cbb_doituong);
            this.navPanelNhapDuLieu.Controls.Add(this.labelX7);
            this.navPanelNhapDuLieu.Controls.Add(this.labelX6);
            this.navPanelNhapDuLieu.Controls.Add(this.labelX5);
            this.navPanelNhapDuLieu.Controls.Add(this.labelX4);
            this.navPanelNhapDuLieu.Controls.Add(this.labelX3);
            this.navPanelNhapDuLieu.Controls.Add(this.txt_mahocsinh);
            this.navPanelNhapDuLieu.Controls.Add(this.labelX2);
            this.navPanelNhapDuLieu.Controls.Add(this.labelX1);
            this.navPanelNhapDuLieu.Controls.Add(this.lblBuffer);
            this.navPanelNhapDuLieu.Controls.Add(this.dt_ngaysinh);
            this.navPanelNhapDuLieu.Controls.Add(this.btnLuuVaoDS);
            this.navPanelNhapDuLieu.Controls.Add(this.cbb_phuhuynh);
            this.navPanelNhapDuLieu.Controls.Add(this.cbb_dantoc);
            this.navPanelNhapDuLieu.Controls.Add(this.cbb_tongiao);
            this.navPanelNhapDuLieu.Controls.Add(this.txt_noisinh);
            this.navPanelNhapDuLieu.Controls.Add(this.txt_hoten);
            this.navPanelNhapDuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navPanelNhapDuLieu.Location = new System.Drawing.Point(1, 25);
            this.navPanelNhapDuLieu.Name = "navPanelNhapDuLieu";
            this.navPanelNhapDuLieu.ParentItem = this.buttonItemNhapDuLieu;
            this.navPanelNhapDuLieu.Size = new System.Drawing.Size(193, 524);
            this.navPanelNhapDuLieu.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navPanelNhapDuLieu.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.navPanelNhapDuLieu.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.navPanelNhapDuLieu.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navPanelNhapDuLieu.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.navPanelNhapDuLieu.Style.GradientAngle = 90;
            this.navPanelNhapDuLieu.TabIndex = 1;
            // 
            // cbb_gioitinh
            // 
            this.cbb_gioitinh.DisplayMember = "Text";
            this.cbb_gioitinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_gioitinh.FormattingEnabled = true;
            this.cbb_gioitinh.ItemHeight = 17;
            this.cbb_gioitinh.Location = new System.Drawing.Point(11, 127);
            this.cbb_gioitinh.Name = "cbb_gioitinh";
            this.cbb_gioitinh.Size = new System.Drawing.Size(125, 23);
            this.cbb_gioitinh.TabIndex = 19;
            // 
            // labelX9
            // 
            this.labelX9.AutoSize = true;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(11, 402);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(70, 18);
            this.labelX9.TabIndex = 16;
            this.labelX9.Text = "Phụ huynh:";
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(11, 351);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(63, 18);
            this.labelX8.TabIndex = 14;
            this.labelX8.Text = "Đối tượng:";
            // 
            // cbb_doituong
            // 
            this.cbb_doituong.DisplayMember = "Text";
            this.cbb_doituong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_doituong.FormattingEnabled = true;
            this.cbb_doituong.ItemHeight = 17;
            this.cbb_doituong.Location = new System.Drawing.Point(11, 373);
            this.cbb_doituong.Name = "cbb_doituong";
            this.cbb_doituong.Size = new System.Drawing.Size(125, 23);
            this.cbb_doituong.TabIndex = 15;
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(11, 300);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(58, 18);
            this.labelX7.TabIndex = 12;
            this.labelX7.Text = "Tôn giáo:";
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(11, 252);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(52, 18);
            this.labelX6.TabIndex = 10;
            this.labelX6.Text = "Dân tộc:";
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(11, 204);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(54, 18);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "Nơi sinh:";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(11, 156);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(65, 18);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "Ngày sinh:";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(11, 110);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(55, 18);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Giới tính:";
            // 
            // txt_mahocsinh
            // 
            // 
            // 
            // 
            this.txt_mahocsinh.Border.Class = "TextBoxBorder";
            this.txt_mahocsinh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_mahocsinh.Location = new System.Drawing.Point(11, 33);
            this.txt_mahocsinh.MaxLength = 30;
            this.txt_mahocsinh.Name = "txt_mahocsinh";
            this.txt_mahocsinh.Size = new System.Drawing.Size(125, 23);
            this.txt_mahocsinh.TabIndex = 1;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(11, 62);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(45, 18);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Họ tên:";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(11, 14);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(78, 18);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã học sinh:";
            // 
            // lblBuffer
            // 
            this.lblBuffer.AutoSize = true;
            this.lblBuffer.Enabled = false;
            this.lblBuffer.Location = new System.Drawing.Point(8, 850);
            this.lblBuffer.Name = "lblBuffer";
            this.lblBuffer.Size = new System.Drawing.Size(0, 17);
            this.lblBuffer.TabIndex = 0;
            // 
            // dt_ngaysinh
            // 
            // 
            // 
            // 
            this.dt_ngaysinh.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dt_ngaysinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_ngaysinh.ButtonDropDown.Visible = true;
            this.dt_ngaysinh.IsPopupCalendarOpen = false;
            this.dt_ngaysinh.Location = new System.Drawing.Point(11, 175);
            this.dt_ngaysinh.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dt_ngaysinh.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dt_ngaysinh.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dt_ngaysinh.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dt_ngaysinh.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_ngaysinh.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dt_ngaysinh.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dt_ngaysinh.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dt_ngaysinh.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dt_ngaysinh.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dt_ngaysinh.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dt_ngaysinh.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dt_ngaysinh.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_ngaysinh.MonthCalendar.DisplayMonth = new System.DateTime(2008, 11, 1, 0, 0, 0, 0);
            this.dt_ngaysinh.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dt_ngaysinh.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dt_ngaysinh.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dt_ngaysinh.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dt_ngaysinh.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dt_ngaysinh.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_ngaysinh.MonthCalendar.TodayButtonVisible = true;
            this.dt_ngaysinh.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dt_ngaysinh.Name = "dt_ngaysinh";
            this.dt_ngaysinh.Size = new System.Drawing.Size(125, 23);
            this.dt_ngaysinh.TabIndex = 7;
            // 
            // btnLuuVaoDS
            // 
            this.btnLuuVaoDS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuuVaoDS.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnLuuVaoDS.Location = new System.Drawing.Point(11, 475);
            this.btnLuuVaoDS.Name = "btnLuuVaoDS";
            this.btnLuuVaoDS.Size = new System.Drawing.Size(160, 23);
            this.btnLuuVaoDS.TabIndex = 18;
            this.btnLuuVaoDS.Text = "Lưu vào danh sách";
            this.btnLuuVaoDS.Click += new System.EventHandler(this.btnLuuVaoDS_Click);
            // 
            // cbb_phuhuynh
            // 
            this.cbb_phuhuynh.DisplayMember = "Text";
            this.cbb_phuhuynh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_phuhuynh.FormattingEnabled = true;
            this.cbb_phuhuynh.ItemHeight = 17;
            this.cbb_phuhuynh.Location = new System.Drawing.Point(11, 426);
            this.cbb_phuhuynh.Name = "cbb_phuhuynh";
            this.cbb_phuhuynh.Size = new System.Drawing.Size(125, 23);
            this.cbb_phuhuynh.TabIndex = 17;
            // 
            // cbb_dantoc
            // 
            this.cbb_dantoc.DisplayMember = "Text";
            this.cbb_dantoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_dantoc.FormattingEnabled = true;
            this.cbb_dantoc.ItemHeight = 17;
            this.cbb_dantoc.Location = new System.Drawing.Point(11, 271);
            this.cbb_dantoc.Name = "cbb_dantoc";
            this.cbb_dantoc.Size = new System.Drawing.Size(125, 23);
            this.cbb_dantoc.TabIndex = 11;
            // 
            // cbb_tongiao
            // 
            this.cbb_tongiao.DisplayMember = "Text";
            this.cbb_tongiao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_tongiao.FormattingEnabled = true;
            this.cbb_tongiao.ItemHeight = 17;
            this.cbb_tongiao.Location = new System.Drawing.Point(11, 322);
            this.cbb_tongiao.Name = "cbb_tongiao";
            this.cbb_tongiao.Size = new System.Drawing.Size(125, 23);
            this.cbb_tongiao.TabIndex = 13;
            // 
            // txt_noisinh
            // 
            // 
            // 
            // 
            this.txt_noisinh.Border.Class = "TextBoxBorder";
            this.txt_noisinh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_noisinh.Location = new System.Drawing.Point(11, 223);
            this.txt_noisinh.MaxLength = 50;
            this.txt_noisinh.Name = "txt_noisinh";
            this.txt_noisinh.Size = new System.Drawing.Size(160, 23);
            this.txt_noisinh.TabIndex = 9;
            // 
            // txt_hoten
            // 
            // 
            // 
            // 
            this.txt_hoten.Border.Class = "TextBoxBorder";
            this.txt_hoten.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_hoten.Location = new System.Drawing.Point(11, 81);
            this.txt_hoten.MaxLength = 30;
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(160, 23);
            this.txt_hoten.TabIndex = 3;
            // 
            // buttonItemNhapDuLieu
            // 
            this.buttonItemNhapDuLieu.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemNhapDuLieu.Checked = true;
            this.buttonItemNhapDuLieu.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemNhapDuLieu.Image")));
            this.buttonItemNhapDuLieu.Name = "buttonItemNhapDuLieu";
            this.buttonItemNhapDuLieu.OptionGroup = "navBar";
            this.buttonItemNhapDuLieu.Text = "Thêm mới thông tin";
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.ctx_menu);
            this.groupBox.Controls.Add(this.bindingNavigatorHocSinh);
            this.groupBox.Controls.Add(this.dgv_hocsinh);
            this.groupBox.Location = new System.Drawing.Point(202, 0);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(978, 515);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Danh sách học sinh";
            // 
            // ctx_menu
            // 
            this.ctx_menu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ctx_menu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_menu});
            this.ctx_menu.Location = new System.Drawing.Point(376, 147);
            this.ctx_menu.Name = "ctx_menu";
            this.ctx_menu.Size = new System.Drawing.Size(90, 27);
            this.ctx_menu.Stretch = true;
            this.ctx_menu.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ctx_menu.TabIndex = 7;
            this.ctx_menu.TabStop = false;
            this.ctx_menu.Text = "ctxMenu";
            // 
            // btn_menu
            // 
            this.btn_menu.AutoExpandOnClick = true;
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btn_menu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_themmoi,
            this.btn_xoa,
            this.btn_sua,
            this.btn_luu,
            this.btn_thoat});
            this.btn_menu.Text = "Menu";
            // 
            // btn_themmoi
            // 
            this.btn_themmoi.Image = global::QuanLyHocSinhTHPT.Properties.Resources.add;
            this.btn_themmoi.Name = "btn_themmoi";
            this.btn_themmoi.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.btn_themmoi.Text = "Thêm mới";
            this.btn_themmoi.Click += new System.EventHandler(this.tsbtn_themmoi_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = global::QuanLyHocSinhTHPT.Properties.Resources.delete;
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.btn_xoa.Text = "Xóa dòng được chọn";
            this.btn_xoa.Click += new System.EventHandler(this.tsbtn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Image = global::QuanLyHocSinhTHPT.Properties.Resources.edit;
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlE);
            this.btn_sua.Text = "Sửa dòng này";
            this.btn_sua.Click += new System.EventHandler(this.tsbtn_sua_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Image = global::QuanLyHocSinhTHPT.Properties.Resources.save;
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btn_luu.Text = "Lưu danh sách";
            this.btn_luu.Click += new System.EventHandler(this.tsbtn_luu_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Image = global::QuanLyHocSinhTHPT.Properties.Resources.exit;
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltF4);
            this.btn_thoat.Text = "Đóng cửa sổ này";
            this.btn_thoat.Click += new System.EventHandler(this.tsbtn_thoat_Click);
            // 
            // dgv_hocsinh
            // 
            this.dgv_hocsinh.AllowUserToAddRows = false;
            this.dgv_hocsinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_hocsinh.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hocsinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_hocsinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hocsinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.ctx_menu.SetContextMenuEx(this.dgv_hocsinh, this.btn_menu);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_hocsinh.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_hocsinh.EnableHeadersVisualStyles = false;
            this.dgv_hocsinh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_hocsinh.Location = new System.Drawing.Point(4, 48);
            this.dgv_hocsinh.Name = "dgv_hocsinh";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hocsinh.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_hocsinh.Size = new System.Drawing.Size(970, 450);
            this.dgv_hocsinh.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MAHOCSINH";
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Mã học sinh";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "HOTENHOCSINH";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "MAGIOITINH";
            this.Column3.DataSource = this.gIOITINHBindingSource;
            this.Column3.DisplayMember = "TENGIOITINH";
            this.Column3.FillWeight = 50F;
            this.Column3.HeaderText = "Giới tính";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.ValueMember = "MAGIOITINH";
            // 
            // gIOITINHBindingSource
            // 
            this.gIOITINHBindingSource.DataMember = "GIOITINH";
            this.gIOITINHBindingSource.DataSource = this.ds_LoadDataIntoDB;
            // 
            // ds_LoadDataIntoDB
            // 
            this.ds_LoadDataIntoDB.DataSetName = "ds_LoadDataIntoDB";
            this.ds_LoadDataIntoDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "NGAYSINH";
            this.Column4.HeaderText = "Ngày sinh";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "NOISINH";
            this.Column5.HeaderText = "Nơi sinh";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "MADANTOC";
            this.Column6.DataSource = this.dANTOCBindingSource;
            this.Column6.DisplayMember = "TENDANTOC";
            this.Column6.FillWeight = 70F;
            this.Column6.HeaderText = "Dân tộc";
            this.Column6.Name = "Column6";
            this.Column6.ValueMember = "MADANTOC";
            // 
            // dANTOCBindingSource
            // 
            this.dANTOCBindingSource.DataMember = "DANTOC";
            this.dANTOCBindingSource.DataSource = this.ds_LoadDataIntoDB;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "MATONGIAO";
            this.Column7.DataSource = this.tONGIAOBindingSource;
            this.Column7.DisplayMember = "TENTONGIAO";
            this.Column7.FillWeight = 70F;
            this.Column7.HeaderText = "Tôn giáo";
            this.Column7.Name = "Column7";
            this.Column7.ValueMember = "MATONGIAO";
            // 
            // tONGIAOBindingSource
            // 
            this.tONGIAOBindingSource.DataMember = "TONGIAO";
            this.tONGIAOBindingSource.DataSource = this.ds_LoadDataIntoDB;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "MADOITUONG";
            this.Column8.DataSource = this.dOITUONGBindingSource;
            this.Column8.DisplayMember = "TENDOITUONG";
            this.Column8.FillWeight = 70F;
            this.Column8.HeaderText = "Loại đối tượng";
            this.Column8.Name = "Column8";
            this.Column8.ValueMember = "MADOITUONG";
            // 
            // dOITUONGBindingSource
            // 
            this.dOITUONGBindingSource.DataMember = "DOITUONG";
            this.dOITUONGBindingSource.DataSource = this.ds_LoadDataIntoDB;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.DataPropertyName = "MAPHUHUYNH";
            this.Column9.DataSource = this.pHUHUYNHBindingSource;
            this.Column9.DisplayMember = "HOTENPHUHUYNH";
            this.Column9.HeaderText = "Phụ huynh";
            this.Column9.Name = "Column9";
            this.Column9.ValueMember = "MAPHUHUYNH";
            // 
            // pHUHUYNHBindingSource
            // 
            this.pHUHUYNHBindingSource.DataMember = "PHUHUYNH";
            this.pHUHUYNHBindingSource.DataSource = this.ds_LoadDataIntoDB;
            // 
            // bindingNavigatorHocSinh
            // 
            this.bindingNavigatorHocSinh.AddNewItem = null;
            this.bindingNavigatorHocSinh.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorHocSinh.CountItemFormat = "của {0}";
            this.bindingNavigatorHocSinh.DeleteItem = null;
            this.bindingNavigatorHocSinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.tsbtn_themmoi,
            this.tsbtn_xoa,
            this.tsbtn_sua,
            this.tsbtn_luu,
            this.tsbtn_capnhat,
            this.tsbtn_thoat});
            this.bindingNavigatorHocSinh.Location = new System.Drawing.Point(4, 20);
            this.bindingNavigatorHocSinh.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorHocSinh.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorHocSinh.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorHocSinh.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorHocSinh.Name = "bindingNavigatorHocSinh";
            this.bindingNavigatorHocSinh.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorHocSinh.Size = new System.Drawing.Size(970, 25);
            this.bindingNavigatorHocSinh.TabIndex = 6;
            this.bindingNavigatorHocSinh.Text = "bindingNavigatorHocSinh";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "của {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Tổng số dòng trong danh sách";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Đến đầu danh sách";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Trở lại dòng trước";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Vị trí hiện tại";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Tới dòng kế tiếp";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Đến cuối danh sách";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtn_themmoi
            // 
            this.tsbtn_themmoi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_themmoi.Image = global::QuanLyHocSinhTHPT.Properties.Resources.add;
            this.tsbtn_themmoi.Name = "tsbtn_themmoi";
            this.tsbtn_themmoi.RightToLeftAutoMirrorImage = true;
            this.tsbtn_themmoi.Size = new System.Drawing.Size(23, 22);
            this.tsbtn_themmoi.Text = "Thêm mới";
            this.tsbtn_themmoi.Click += new System.EventHandler(this.tsbtn_themmoi_Click);
            // 
            // tsbtn_xoa
            // 
            this.tsbtn_xoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_xoa.Image = global::QuanLyHocSinhTHPT.Properties.Resources.delete;
            this.tsbtn_xoa.Name = "tsbtn_xoa";
            this.tsbtn_xoa.RightToLeftAutoMirrorImage = true;
            this.tsbtn_xoa.Size = new System.Drawing.Size(23, 22);
            this.tsbtn_xoa.Text = "Xóa";
            this.tsbtn_xoa.Click += new System.EventHandler(this.tsbtn_xoa_Click);
            // 
            // tsbtn_sua
            // 
            this.tsbtn_sua.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_sua.Image = global::QuanLyHocSinhTHPT.Properties.Resources.edit;
            this.tsbtn_sua.Name = "tsbtn_sua";
            this.tsbtn_sua.RightToLeftAutoMirrorImage = true;
            this.tsbtn_sua.Size = new System.Drawing.Size(23, 22);
            this.tsbtn_sua.Text = "Sửa";
            this.tsbtn_sua.Click += new System.EventHandler(this.tsbtn_sua_Click);
            // 
            // tsbtn_luu
            // 
            this.tsbtn_luu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_luu.Image = global::QuanLyHocSinhTHPT.Properties.Resources.save;
            this.tsbtn_luu.Name = "tsbtn_luu";
            this.tsbtn_luu.RightToLeftAutoMirrorImage = true;
            this.tsbtn_luu.Size = new System.Drawing.Size(23, 22);
            this.tsbtn_luu.Text = "Lưu lại";
            this.tsbtn_luu.Click += new System.EventHandler(this.tsbtn_luu_Click);
            // 
            // tsbtn_capnhat
            // 
            this.tsbtn_capnhat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_capnhat.Image = global::QuanLyHocSinhTHPT.Properties.Resources.refresh;
            this.tsbtn_capnhat.Name = "tsbtn_capnhat";
            this.tsbtn_capnhat.RightToLeftAutoMirrorImage = true;
            this.tsbtn_capnhat.Size = new System.Drawing.Size(23, 22);
            this.tsbtn_capnhat.Text = "Tải lại";
            this.tsbtn_capnhat.Click += new System.EventHandler(this.tsbtn_capnhat_Click);
            // 
            // tsbtn_thoat
            // 
            this.tsbtn_thoat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_thoat.Image = global::QuanLyHocSinhTHPT.Properties.Resources.exit;
            this.tsbtn_thoat.Name = "tsbtn_thoat";
            this.tsbtn_thoat.RightToLeftAutoMirrorImage = true;
            this.tsbtn_thoat.Size = new System.Drawing.Size(23, 22);
            this.tsbtn_thoat.Text = "Thoát";
            this.tsbtn_thoat.Click += new System.EventHandler(this.tsbtn_thoat_Click);
            // 
            // gIOITINHTableAdapter
            // 
            this.gIOITINHTableAdapter.ClearBeforeFill = true;
            // 
            // dANTOCTableAdapter
            // 
            this.dANTOCTableAdapter.ClearBeforeFill = true;
            // 
            // tONGIAOTableAdapter
            // 
            this.tONGIAOTableAdapter.ClearBeforeFill = true;
            // 
            // dOITUONGTableAdapter
            // 
            this.dOITUONGTableAdapter.ClearBeforeFill = true;
            // 
            // pHUHUYNHTableAdapter
            // 
            this.pHUHUYNHTableAdapter.ClearBeforeFill = true;
            // 
            // Form_HocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 683);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.navPaneLeft);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_HocSinh";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỌC SINH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_HocSinh_Load);
            this.navPaneLeft.ResumeLayout(false);
            this.navPanelNhapDuLieu.ResumeLayout(false);
            this.navPanelNhapDuLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaysinh)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctx_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hocsinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIOITINHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_LoadDataIntoDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANTOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tONGIAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOITUONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUHUYNHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocSinh)).EndInit();
            this.bindingNavigatorHocSinh.ResumeLayout(false);
            this.bindingNavigatorHocSinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.NavigationPane navPaneLeft;
        private DevComponents.DotNetBar.NavigationPanePanel navPanelNhapDuLieu;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_mahocsinh;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Label lblBuffer;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dt_ngaysinh;
        private DevComponents.DotNetBar.ButtonX btnLuuVaoDS;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_phuhuynh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_dantoc;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_tongiao;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_noisinh;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_hoten;
        private DevComponents.DotNetBar.ButtonItem buttonItemNhapDuLieu;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_doituong;
        private DevComponents.DotNetBar.LabelX labelX9;
        private System.Windows.Forms.GroupBox groupBox;
        private DevComponents.DotNetBar.ContextMenuBar ctx_menu;
        private DevComponents.DotNetBar.ButtonItem btn_menu;
        private DevComponents.DotNetBar.ButtonItem btn_themmoi;
        private DevComponents.DotNetBar.ButtonItem btn_xoa;
        private DevComponents.DotNetBar.ButtonItem btn_sua;
        private DevComponents.DotNetBar.ButtonItem btn_luu;
        private DevComponents.DotNetBar.ButtonItem btn_thoat;
        private System.Windows.Forms.BindingNavigator bindingNavigatorHocSinh;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtn_themmoi;
        private System.Windows.Forms.ToolStripButton tsbtn_xoa;
        private System.Windows.Forms.ToolStripButton tsbtn_sua;
        private System.Windows.Forms.ToolStripButton tsbtn_luu;
        private System.Windows.Forms.ToolStripButton tsbtn_capnhat;
        private System.Windows.Forms.ToolStripButton tsbtn_thoat;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_hocsinh;
        private ds_LoadDataIntoDB ds_LoadDataIntoDB;
        private System.Windows.Forms.BindingSource gIOITINHBindingSource;
        private ds_LoadDataIntoDBTableAdapters.GIOITINHTableAdapter gIOITINHTableAdapter;
        private System.Windows.Forms.BindingSource dANTOCBindingSource;
        private ds_LoadDataIntoDBTableAdapters.DANTOCTableAdapter dANTOCTableAdapter;
        private System.Windows.Forms.BindingSource tONGIAOBindingSource;
        private ds_LoadDataIntoDBTableAdapters.TONGIAOTableAdapter tONGIAOTableAdapter;
        private System.Windows.Forms.BindingSource dOITUONGBindingSource;
        private ds_LoadDataIntoDBTableAdapters.DOITUONGTableAdapter dOITUONGTableAdapter;
        private System.Windows.Forms.BindingSource pHUHUYNHBindingSource;
        private ds_LoadDataIntoDBTableAdapters.PHUHUYNHTableAdapter pHUHUYNHTableAdapter;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column6;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column7;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column8;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column9;
    }
}