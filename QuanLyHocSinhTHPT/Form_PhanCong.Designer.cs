namespace QuanLyHocSinhTHPT
{
    partial class Form_PhanCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PhanCong));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navigationPane = new DevComponents.DotNetBar.NavigationPane();
            this.navigationPanePanel = new DevComponents.DotNetBar.NavigationPanePanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_stt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_themmonhoc = new DevComponents.DotNetBar.ButtonX();
            this.btn_themlop = new DevComponents.DotNetBar.ButtonX();
            this.btn_themnamhoc = new DevComponents.DotNetBar.ButtonX();
            this.cbb_monhoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbb_lop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbb_namhoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cbb_giaovien = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btn_luuds = new DevComponents.DotNetBar.ButtonX();
            this.btn_themgiaovien = new DevComponents.DotNetBar.ButtonX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.ctx_menu = new DevComponents.DotNetBar.ContextMenuBar();
            this.dgv_phancong = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nAMHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_LoadDataIntoDB = new QuanLyHocSinhTHPT.ds_LoadDataIntoDB();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gIAOVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_menu = new DevComponents.DotNetBar.ButtonItem();
            this.btn_themmoi = new DevComponents.DotNetBar.ButtonItem();
            this.btn_xoa = new DevComponents.DotNetBar.ButtonItem();
            this.btn_sua = new DevComponents.DotNetBar.ButtonItem();
            this.btn_luu = new DevComponents.DotNetBar.ButtonItem();
            this.btn_thoat = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorPhanCong = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.nAMHOCTableAdapter = new QuanLyHocSinhTHPT.ds_LoadDataIntoDBTableAdapters.NAMHOCTableAdapter();
            this.lOPTableAdapter = new QuanLyHocSinhTHPT.ds_LoadDataIntoDBTableAdapters.LOPTableAdapter();
            this.mONHOCTableAdapter = new QuanLyHocSinhTHPT.ds_LoadDataIntoDBTableAdapters.MONHOCTableAdapter();
            this.gIAOVIENTableAdapter = new QuanLyHocSinhTHPT.ds_LoadDataIntoDBTableAdapters.GIAOVIENTableAdapter();
            this.navigationPane.SuspendLayout();
            this.navigationPanePanel.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctx_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phancong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_LoadDataIntoDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPhanCong)).BeginInit();
            this.bindingNavigatorPhanCong.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPane
            // 
            this.navigationPane.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.navigationPane.Controls.Add(this.navigationPanePanel);
            this.navigationPane.ItemPaddingBottom = 2;
            this.navigationPane.ItemPaddingTop = 2;
            this.navigationPane.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.navigationPane.Location = new System.Drawing.Point(7, 0);
            this.navigationPane.Name = "navigationPane";
            this.navigationPane.NavigationBarHeight = 33;
            this.navigationPane.Padding = new System.Windows.Forms.Padding(1);
            this.navigationPane.Size = new System.Drawing.Size(189, 495);
            this.navigationPane.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.navigationPane.TabIndex = 2;
            // 
            // 
            // 
            this.navigationPane.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPane.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPane.TitlePanel.Name = "panelTitle";
            this.navigationPane.TitlePanel.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            this.navigationPane.TitlePanel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(148)))));
            this.navigationPane.TitlePanel.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.navigationPane.TitlePanel.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            this.navigationPane.TitlePanel.Style.ForeColor.Color = System.Drawing.Color.White;
            this.navigationPane.TitlePanel.TabIndex = 0;
            this.navigationPane.TitlePanel.Text = "Thêm mới dữ liệu";
            // 
            // navigationPanePanel
            // 
            this.navigationPanePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPanePanel.Controls.Add(this.labelX1);
            this.navigationPanePanel.Controls.Add(this.txt_stt);
            this.navigationPanePanel.Controls.Add(this.btn_themmonhoc);
            this.navigationPanePanel.Controls.Add(this.btn_themlop);
            this.navigationPanePanel.Controls.Add(this.btn_themnamhoc);
            this.navigationPanePanel.Controls.Add(this.cbb_monhoc);
            this.navigationPanePanel.Controls.Add(this.cbb_lop);
            this.navigationPanePanel.Controls.Add(this.cbb_namhoc);
            this.navigationPanePanel.Controls.Add(this.labelX4);
            this.navigationPanePanel.Controls.Add(this.labelX3);
            this.navigationPanePanel.Controls.Add(this.cbb_giaovien);
            this.navigationPanePanel.Controls.Add(this.btn_luuds);
            this.navigationPanePanel.Controls.Add(this.btn_themgiaovien);
            this.navigationPanePanel.Controls.Add(this.labelX6);
            this.navigationPanePanel.Controls.Add(this.labelX2);
            this.navigationPanePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel.Location = new System.Drawing.Point(1, 1);
            this.navigationPanePanel.Name = "navigationPanePanel";
            this.navigationPanePanel.ParentItem = this.buttonItem1;
            this.navigationPanePanel.Size = new System.Drawing.Size(187, 460);
            this.navigationPanePanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPanePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.navigationPanePanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.navigationPanePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPanePanel.Style.GradientAngle = 90;
            this.navigationPanePanel.TabIndex = 2;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(5, 26);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(59, 18);
            this.labelX1.TabIndex = 34;
            this.labelX1.Text = "Số thứ tự:";
            // 
            // txt_stt
            // 
            // 
            // 
            // 
            this.txt_stt.Border.Class = "TextBoxBorder";
            this.txt_stt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_stt.Location = new System.Drawing.Point(4, 50);
            this.txt_stt.Name = "txt_stt";
            this.txt_stt.Size = new System.Drawing.Size(147, 23);
            this.txt_stt.TabIndex = 33;
            // 
            // btn_themmonhoc
            // 
            this.btn_themmonhoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_themmonhoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_themmonhoc.Image = global::QuanLyHocSinhTHPT.Properties.Resources.add;
            this.btn_themmonhoc.Location = new System.Drawing.Point(156, 213);
            this.btn_themmonhoc.Name = "btn_themmonhoc";
            this.btn_themmonhoc.Size = new System.Drawing.Size(20, 20);
            this.btn_themmonhoc.TabIndex = 28;
            this.btn_themmonhoc.Click += new System.EventHandler(this.btn_themmonhoc_Click);
            // 
            // btn_themlop
            // 
            this.btn_themlop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_themlop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_themlop.Image = global::QuanLyHocSinhTHPT.Properties.Resources.add;
            this.btn_themlop.Location = new System.Drawing.Point(156, 160);
            this.btn_themlop.Name = "btn_themlop";
            this.btn_themlop.Size = new System.Drawing.Size(20, 20);
            this.btn_themlop.TabIndex = 27;
            this.btn_themlop.Click += new System.EventHandler(this.btn_themlop_Click);
            // 
            // btn_themnamhoc
            // 
            this.btn_themnamhoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_themnamhoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_themnamhoc.Image = global::QuanLyHocSinhTHPT.Properties.Resources.add;
            this.btn_themnamhoc.Location = new System.Drawing.Point(156, 106);
            this.btn_themnamhoc.Name = "btn_themnamhoc";
            this.btn_themnamhoc.Size = new System.Drawing.Size(20, 20);
            this.btn_themnamhoc.TabIndex = 26;
            this.btn_themnamhoc.Click += new System.EventHandler(this.btn_themnamhoc_Click);
            // 
            // cbb_monhoc
            // 
            this.cbb_monhoc.DisplayMember = "Text";
            this.cbb_monhoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_monhoc.FormattingEnabled = true;
            this.cbb_monhoc.ItemHeight = 17;
            this.cbb_monhoc.Location = new System.Drawing.Point(3, 210);
            this.cbb_monhoc.Name = "cbb_monhoc";
            this.cbb_monhoc.Size = new System.Drawing.Size(147, 23);
            this.cbb_monhoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbb_monhoc.TabIndex = 25;
            // 
            // cbb_lop
            // 
            this.cbb_lop.DisplayMember = "Text";
            this.cbb_lop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_lop.FormattingEnabled = true;
            this.cbb_lop.ItemHeight = 17;
            this.cbb_lop.Location = new System.Drawing.Point(3, 157);
            this.cbb_lop.Name = "cbb_lop";
            this.cbb_lop.Size = new System.Drawing.Size(147, 23);
            this.cbb_lop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbb_lop.TabIndex = 24;
            // 
            // cbb_namhoc
            // 
            this.cbb_namhoc.DisplayMember = "Text";
            this.cbb_namhoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_namhoc.FormattingEnabled = true;
            this.cbb_namhoc.ItemHeight = 17;
            this.cbb_namhoc.Location = new System.Drawing.Point(3, 103);
            this.cbb_namhoc.Name = "cbb_namhoc";
            this.cbb_namhoc.Size = new System.Drawing.Size(147, 23);
            this.cbb_namhoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbb_namhoc.TabIndex = 23;
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(3, 186);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(57, 18);
            this.labelX4.TabIndex = 22;
            this.labelX4.Text = "Môn học:";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(3, 133);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(28, 18);
            this.labelX3.TabIndex = 20;
            this.labelX3.Text = "Lớp:";
            // 
            // cbb_giaovien
            // 
            this.cbb_giaovien.DisplayMember = "Text";
            this.cbb_giaovien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_giaovien.FormattingEnabled = true;
            this.cbb_giaovien.ItemHeight = 17;
            this.cbb_giaovien.Location = new System.Drawing.Point(3, 263);
            this.cbb_giaovien.Name = "cbb_giaovien";
            this.cbb_giaovien.Size = new System.Drawing.Size(147, 23);
            this.cbb_giaovien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbb_giaovien.TabIndex = 19;
            // 
            // btn_luuds
            // 
            this.btn_luuds.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_luuds.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btn_luuds.Location = new System.Drawing.Point(3, 302);
            this.btn_luuds.Name = "btn_luuds";
            this.btn_luuds.Size = new System.Drawing.Size(163, 23);
            this.btn_luuds.TabIndex = 16;
            this.btn_luuds.Text = "Lưu danh sách";
            this.btn_luuds.Click += new System.EventHandler(this.btn_luuds_Click);
            // 
            // btn_themgiaovien
            // 
            this.btn_themgiaovien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_themgiaovien.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_themgiaovien.Image = global::QuanLyHocSinhTHPT.Properties.Resources.add;
            this.btn_themgiaovien.Location = new System.Drawing.Point(156, 266);
            this.btn_themgiaovien.Name = "btn_themgiaovien";
            this.btn_themgiaovien.Size = new System.Drawing.Size(20, 20);
            this.btn_themgiaovien.TabIndex = 15;
            this.btn_themgiaovien.Click += new System.EventHandler(this.btn_themgiaovien_Click);
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(3, 239);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(63, 18);
            this.labelX6.TabIndex = 13;
            this.labelX6.Text = "Giáo viên:";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(3, 79);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(59, 18);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Năm học:";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Checked = true;
            this.buttonItem1.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem1.Image")));
            this.buttonItem1.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.OptionGroup = "navBar";
            this.buttonItem1.Text = "Thêm mới dữ liệu";
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.ctx_menu);
            this.groupBox.Controls.Add(this.bindingNavigatorPhanCong);
            this.groupBox.Controls.Add(this.dgv_phancong);
            this.groupBox.Location = new System.Drawing.Point(203, 0);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(664, 495);
            this.groupBox.TabIndex = 6;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Danh sách phân công giáo viên giảng dạy";
            // 
            // ctx_menu
            // 
            this.ctx_menu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctx_menu.Location = new System.Drawing.Point(0, 0);
            this.ctx_menu.Name = "ctx_menu";
            this.ctx_menu.Size = new System.Drawing.Size(0, 24);
            this.ctx_menu.Stretch = true;
            this.ctx_menu.TabIndex = 0;
            this.ctx_menu.TabStop = false;
            // 
            // dgv_phancong
            // 
            this.dgv_phancong.AllowUserToAddRows = false;
            this.dgv_phancong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_phancong.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_phancong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_phancong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phancong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.ctx_menu.SetContextMenuEx(this.dgv_phancong, this.btn_menu);
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_phancong.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_phancong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_phancong.Location = new System.Drawing.Point(2, 51);
            this.dgv_phancong.Name = "dgv_phancong";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_phancong.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_phancong.Size = new System.Drawing.Size(658, 437);
            this.dgv_phancong.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "STT";
            this.Column1.HeaderText = "STT";
            this.Column1.MaxInputLength = 0;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "MANAMHOC";
            this.Column2.DataSource = this.nAMHOCBindingSource;
            this.Column2.DisplayMember = "TENNAMHOC";
            this.Column2.HeaderText = "Năm Học";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.ValueMember = "MANAMHOC";
            // 
            // nAMHOCBindingSource
            // 
            this.nAMHOCBindingSource.DataMember = "NAMHOC";
            this.nAMHOCBindingSource.DataSource = this.ds_LoadDataIntoDB;
            // 
            // ds_LoadDataIntoDB
            // 
            this.ds_LoadDataIntoDB.DataSetName = "ds_LoadDataIntoDB";
            this.ds_LoadDataIntoDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "MALOP";
            this.Column3.DataSource = this.lOPBindingSource;
            this.Column3.DisplayMember = "TENLOP";
            this.Column3.HeaderText = "Lớp Học";
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.ValueMember = "MALOP";
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.ds_LoadDataIntoDB;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "MAMONHOC";
            this.Column4.DataSource = this.mONHOCBindingSource;
            this.Column4.DisplayMember = "TENMONHOC";
            this.Column4.HeaderText = "Môn Học";
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.ValueMember = "MAMONHOC";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.ds_LoadDataIntoDB;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "MAGIAOVIEN";
            this.Column5.DataSource = this.gIAOVIENBindingSource;
            this.Column5.DisplayMember = "MAGIAOVIEN";
            this.Column5.HeaderText = "Giáo Viên";
            this.Column5.Name = "Column5";
            this.Column5.ValueMember = "MAGIAOVIEN";
            // 
            // gIAOVIENBindingSource
            // 
            this.gIAOVIENBindingSource.DataMember = "GIAOVIEN";
            this.gIAOVIENBindingSource.DataSource = this.ds_LoadDataIntoDB;
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
            // bindingNavigatorPhanCong
            // 
            this.bindingNavigatorPhanCong.AddNewItem = null;
            this.bindingNavigatorPhanCong.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorPhanCong.CountItemFormat = "của {0}";
            this.bindingNavigatorPhanCong.DeleteItem = null;
            this.bindingNavigatorPhanCong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorPhanCong.Location = new System.Drawing.Point(4, 20);
            this.bindingNavigatorPhanCong.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorPhanCong.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorPhanCong.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorPhanCong.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorPhanCong.Name = "bindingNavigatorPhanCong";
            this.bindingNavigatorPhanCong.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorPhanCong.Size = new System.Drawing.Size(656, 25);
            this.bindingNavigatorPhanCong.TabIndex = 6;
            this.bindingNavigatorPhanCong.Text = "bindingNavigatorPhanCong";
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
            // nAMHOCTableAdapter
            // 
            this.nAMHOCTableAdapter.ClearBeforeFill = true;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // Form_PhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 556);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.navigationPane);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_PhanCong";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHÂN CÔNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_PhanCong_Load);
            this.navigationPane.ResumeLayout(false);
            this.navigationPanePanel.ResumeLayout(false);
            this.navigationPanePanel.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctx_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phancong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_LoadDataIntoDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPhanCong)).EndInit();
            this.bindingNavigatorPhanCong.ResumeLayout(false);
            this.bindingNavigatorPhanCong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.NavigationPane navigationPane;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_giaovien;
        private DevComponents.DotNetBar.ButtonX btn_luuds;
        private DevComponents.DotNetBar.ButtonX btn_themgiaovien;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private System.Windows.Forms.GroupBox groupBox;
        private DevComponents.DotNetBar.ContextMenuBar ctx_menu;
        private DevComponents.DotNetBar.ButtonItem btn_menu;
        private DevComponents.DotNetBar.ButtonItem btn_themmoi;
        private DevComponents.DotNetBar.ButtonItem btn_xoa;
        private DevComponents.DotNetBar.ButtonItem btn_sua;
        private DevComponents.DotNetBar.ButtonItem btn_luu;
        private DevComponents.DotNetBar.ButtonItem btn_thoat;
        private System.Windows.Forms.BindingNavigator bindingNavigatorPhanCong;
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
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_phancong;
        private ds_LoadDataIntoDB ds_LoadDataIntoDB;
        private System.Windows.Forms.BindingSource nAMHOCBindingSource;
        private ds_LoadDataIntoDBTableAdapters.NAMHOCTableAdapter nAMHOCTableAdapter;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private ds_LoadDataIntoDBTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private ds_LoadDataIntoDBTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource gIAOVIENBindingSource;
        private ds_LoadDataIntoDBTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_monhoc;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_lop;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_namhoc;
        private DevComponents.DotNetBar.ButtonX btn_themmonhoc;
        private DevComponents.DotNetBar.ButtonX btn_themlop;
        private DevComponents.DotNetBar.ButtonX btn_themnamhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column4;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column5;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_stt;
    }
}