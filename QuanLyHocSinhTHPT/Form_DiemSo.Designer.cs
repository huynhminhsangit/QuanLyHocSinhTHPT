namespace QuanLyHocSinhTHPT
{
    partial class Form_DiemSo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DiemSo));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.ctx_menu = new DevComponents.DotNetBar.ContextMenuBar();
            this.btn_menu = new DevComponents.DotNetBar.ButtonItem();
            this.btn_themmoi = new DevComponents.DotNetBar.ButtonItem();
            this.btn_xoa = new DevComponents.DotNetBar.ButtonItem();
            this.btn_sua = new DevComponents.DotNetBar.ButtonItem();
            this.btn_luu = new DevComponents.DotNetBar.ButtonItem();
            this.btn_thoat = new DevComponents.DotNetBar.ButtonItem();
            this.dgv_diemso = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorDiemSo = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtn_xoa = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_sua = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_luu = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_thoat = new System.Windows.Forms.ToolStripButton();
            this.buttonItemNhapDuLieu = new DevComponents.DotNetBar.ButtonItem();
            this.navPaneLeft = new DevComponents.DotNetBar.NavigationPane();
            this.navPanelNhapDuLieu = new DevComponents.DotNetBar.NavigationPanePanel();
            this.btn_hienthidanhsach = new DevComponents.DotNetBar.ButtonX();
            this.label01 = new System.Windows.Forms.Label();
            this.label02 = new System.Windows.Forms.Label();
            this.label04 = new System.Windows.Forms.Label();
            this.cbb_monhoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbb_namhoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbb_hocky = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbb_lop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label03 = new System.Windows.Forms.Label();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctx_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_diemso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDiemSo)).BeginInit();
            this.bindingNavigatorDiemSo.SuspendLayout();
            this.navPaneLeft.SuspendLayout();
            this.navPanelNhapDuLieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.ctx_menu);
            this.groupBox.Controls.Add(this.dgv_diemso);
            this.groupBox.Controls.Add(this.bindingNavigatorDiemSo);
            this.groupBox.Location = new System.Drawing.Point(196, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(896, 480);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Danh sách học sinh";
            // 
            // ctx_menu
            // 
            this.ctx_menu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ctx_menu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_menu});
            this.ctx_menu.Location = new System.Drawing.Point(162, 183);
            this.ctx_menu.Name = "ctx_menu";
            this.ctx_menu.Size = new System.Drawing.Size(90, 27);
            this.ctx_menu.Stretch = true;
            this.ctx_menu.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ctx_menu.TabIndex = 9;
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
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = global::QuanLyHocSinhTHPT.Properties.Resources.delete;
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.btn_xoa.Text = "Xóa dòng được chọn";
            // 
            // btn_sua
            // 
            this.btn_sua.Image = global::QuanLyHocSinhTHPT.Properties.Resources.edit;
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlE);
            this.btn_sua.Text = "Sửa dòng này";
            // 
            // btn_luu
            // 
            this.btn_luu.Image = global::QuanLyHocSinhTHPT.Properties.Resources.save;
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btn_luu.Text = "Lưu danh sách";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Image = global::QuanLyHocSinhTHPT.Properties.Resources.exit;
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltF4);
            this.btn_thoat.Text = "Đóng cửa sổ này";
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
            this.Column5,
            this.Column6,
            this.Column7});
            this.ctx_menu.SetContextMenuEx(this.dgv_diemso, this.btn_menu);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_diemso.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_diemso.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_diemso.Location = new System.Drawing.Point(3, 44);
            this.dgv_diemso.Name = "dgv_diemso";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_diemso.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_diemso.Size = new System.Drawing.Size(890, 426);
            this.dgv_diemso.TabIndex = 8;
            this.dgv_diemso.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_diemso_CellEndEdit);
            this.dgv_diemso.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv_diemso_CellValidating);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MAHOCSINH";
            this.Column1.FillWeight = 45F;
            this.Column1.HeaderText = "Mã học sinh";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "HOTENHOCSINH";
            this.Column2.FillWeight = 80F;
            this.Column2.HeaderText = "Họ tên học sinh";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "DIEMKTMIENG";
            this.Column3.FillWeight = 75.21151F;
            this.Column3.HeaderText = "Điểm miệng";
            this.Column3.MaxInputLength = 4;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "DIEMKT15PH";
            this.Column4.FillWeight = 75.21151F;
            this.Column4.HeaderText = "Điểm 15 phút";
            this.Column4.MaxInputLength = 4;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "DIEMKT45P";
            this.Column5.FillWeight = 75.21151F;
            this.Column5.HeaderText = "Điểm 45 phút";
            this.Column5.MaxInputLength = 4;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "DIEMTHICUOIKY";
            this.Column6.FillWeight = 75.21151F;
            this.Column6.HeaderText = "Điểm thi";
            this.Column6.MaxInputLength = 4;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "DTB";
            this.Column7.FillWeight = 75.21151F;
            this.Column7.HeaderText = "Điểm trung bình";
            this.Column7.MaxInputLength = 4;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // bindingNavigatorDiemSo
            // 
            this.bindingNavigatorDiemSo.AddNewItem = null;
            this.bindingNavigatorDiemSo.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorDiemSo.CountItemFormat = "của {0}";
            this.bindingNavigatorDiemSo.DeleteItem = null;
            this.bindingNavigatorDiemSo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.tsbtn_xoa,
            this.tsbtn_sua,
            this.tsbtn_luu,
            this.tsbtn_thoat});
            this.bindingNavigatorDiemSo.Location = new System.Drawing.Point(3, 19);
            this.bindingNavigatorDiemSo.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorDiemSo.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorDiemSo.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorDiemSo.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorDiemSo.Name = "bindingNavigatorDiemSo";
            this.bindingNavigatorDiemSo.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorDiemSo.Size = new System.Drawing.Size(890, 25);
            this.bindingNavigatorDiemSo.TabIndex = 7;
            this.bindingNavigatorDiemSo.Text = "bindingNavigatorDiemSo";
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
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Trở lại dòng trước";
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
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Đến cuối danh sách";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // buttonItemNhapDuLieu
            // 
            this.buttonItemNhapDuLieu.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemNhapDuLieu.Checked = true;
            this.buttonItemNhapDuLieu.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemNhapDuLieu.Image")));
            this.buttonItemNhapDuLieu.Name = "buttonItemNhapDuLieu";
            this.buttonItemNhapDuLieu.OptionGroup = "navBar";
            this.buttonItemNhapDuLieu.Text = "Nhập điểm học sinh";
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
            this.buttonItem1});
            this.navPaneLeft.Location = new System.Drawing.Point(0, 0);
            this.navPaneLeft.Name = "navPaneLeft";
            this.navPaneLeft.NavigationBarHeight = 67;
            this.navPaneLeft.Padding = new System.Windows.Forms.Padding(1);
            this.navPaneLeft.Size = new System.Drawing.Size(190, 586);
            this.navPaneLeft.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPaneLeft.TabIndex = 3;
            // 
            // 
            // 
            this.navPaneLeft.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPaneLeft.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPaneLeft.TitlePanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navPaneLeft.TitlePanel.Location = new System.Drawing.Point(1, 1);
            this.navPaneLeft.TitlePanel.Name = "panelTitle";
            this.navPaneLeft.TitlePanel.Size = new System.Drawing.Size(188, 24);
            this.navPaneLeft.TitlePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navPaneLeft.TitlePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.navPaneLeft.TitlePanel.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.navPaneLeft.TitlePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navPaneLeft.TitlePanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.navPaneLeft.TitlePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navPaneLeft.TitlePanel.Style.GradientAngle = 90;
            this.navPaneLeft.TitlePanel.Style.MarginLeft = 4;
            this.navPaneLeft.TitlePanel.TabIndex = 0;
            this.navPaneLeft.TitlePanel.Text = "Nhập điểm học sinh";
            // 
            // navPanelNhapDuLieu
            // 
            this.navPanelNhapDuLieu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPanelNhapDuLieu.Controls.Add(this.btn_hienthidanhsach);
            this.navPanelNhapDuLieu.Controls.Add(this.label01);
            this.navPanelNhapDuLieu.Controls.Add(this.label02);
            this.navPanelNhapDuLieu.Controls.Add(this.label04);
            this.navPanelNhapDuLieu.Controls.Add(this.cbb_monhoc);
            this.navPanelNhapDuLieu.Controls.Add(this.cbb_namhoc);
            this.navPanelNhapDuLieu.Controls.Add(this.cbb_hocky);
            this.navPanelNhapDuLieu.Controls.Add(this.cbb_lop);
            this.navPanelNhapDuLieu.Controls.Add(this.label03);
            this.navPanelNhapDuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navPanelNhapDuLieu.Font = new System.Drawing.Font("Arial", 10F);
            this.navPanelNhapDuLieu.Location = new System.Drawing.Point(1, 25);
            this.navPanelNhapDuLieu.Name = "navPanelNhapDuLieu";
            this.navPanelNhapDuLieu.ParentItem = this.buttonItem1;
            this.navPanelNhapDuLieu.Size = new System.Drawing.Size(188, 493);
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
            this.btn_hienthidanhsach.Location = new System.Drawing.Point(11, 206);
            this.btn_hienthidanhsach.Name = "btn_hienthidanhsach";
            this.btn_hienthidanhsach.Size = new System.Drawing.Size(164, 23);
            this.btn_hienthidanhsach.TabIndex = 10;
            this.btn_hienthidanhsach.Text = "Lấy danh sách";
            this.btn_hienthidanhsach.Click += new System.EventHandler(this.btn_hienthidanhsach_Click);
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.Location = new System.Drawing.Point(8, 10);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(67, 16);
            this.label01.TabIndex = 0;
            this.label01.Text = "Năm học:";
            // 
            // label02
            // 
            this.label02.AutoSize = true;
            this.label02.Location = new System.Drawing.Point(9, 98);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(37, 16);
            this.label02.TabIndex = 0;
            this.label02.Text = "Lớp:";
            // 
            // label04
            // 
            this.label04.AutoSize = true;
            this.label04.Location = new System.Drawing.Point(8, 143);
            this.label04.Name = "label04";
            this.label04.Size = new System.Drawing.Size(66, 16);
            this.label04.TabIndex = 0;
            this.label04.Text = "Môn học:";
            // 
            // cbb_monhoc
            // 
            this.cbb_monhoc.DisplayMember = "Text";
            this.cbb_monhoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_monhoc.FormattingEnabled = true;
            this.cbb_monhoc.ItemHeight = 17;
            this.cbb_monhoc.Location = new System.Drawing.Point(11, 162);
            this.cbb_monhoc.Name = "cbb_monhoc";
            this.cbb_monhoc.Size = new System.Drawing.Size(164, 23);
            this.cbb_monhoc.TabIndex = 7;
            this.cbb_monhoc.SelectedIndexChanged += new System.EventHandler(this.cbb_monhoc_SelectedIndexChanged);
            // 
            // cbb_namhoc
            // 
            this.cbb_namhoc.DisplayMember = "Text";
            this.cbb_namhoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_namhoc.FormattingEnabled = true;
            this.cbb_namhoc.ItemHeight = 17;
            this.cbb_namhoc.Location = new System.Drawing.Point(11, 28);
            this.cbb_namhoc.Name = "cbb_namhoc";
            this.cbb_namhoc.Size = new System.Drawing.Size(164, 23);
            this.cbb_namhoc.TabIndex = 1;
            this.cbb_namhoc.SelectedIndexChanged += new System.EventHandler(this.cbb_namhoc_SelectedIndexChanged);
            // 
            // cbb_hocky
            // 
            this.cbb_hocky.DisplayMember = "Text";
            this.cbb_hocky.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_hocky.FormattingEnabled = true;
            this.cbb_hocky.ItemHeight = 17;
            this.cbb_hocky.Location = new System.Drawing.Point(11, 72);
            this.cbb_hocky.Name = "cbb_hocky";
            this.cbb_hocky.Size = new System.Drawing.Size(164, 23);
            this.cbb_hocky.TabIndex = 5;
            this.cbb_hocky.SelectedIndexChanged += new System.EventHandler(this.cbb_hocky_SelectedIndexChanged);
            // 
            // cbb_lop
            // 
            this.cbb_lop.DisplayMember = "Text";
            this.cbb_lop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_lop.FormattingEnabled = true;
            this.cbb_lop.ItemHeight = 17;
            this.cbb_lop.Location = new System.Drawing.Point(12, 117);
            this.cbb_lop.Name = "cbb_lop";
            this.cbb_lop.Size = new System.Drawing.Size(164, 23);
            this.cbb_lop.TabIndex = 3;
            this.cbb_lop.SelectedIndexChanged += new System.EventHandler(this.cbb_lop_SelectedIndexChanged);
            // 
            // label03
            // 
            this.label03.AutoSize = true;
            this.label03.Location = new System.Drawing.Point(8, 53);
            this.label03.Name = "label03";
            this.label03.Size = new System.Drawing.Size(54, 16);
            this.label03.TabIndex = 0;
            this.label03.Text = "Học kỳ:";
            // 
            // buttonItem1
            // 
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.Checked = true;
            this.buttonItem1.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem1.Image")));
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.OptionGroup = "navBar";
            this.buttonItem1.Text = "Nhập điểm học sinh";
            // 
            // Form_DiemSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 586);
            this.Controls.Add(this.navPaneLeft);
            this.Controls.Add(this.groupBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_DiemSo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHẬP ĐIỂM/ CẬP NHẬT ĐIỂM CHUNG";
            this.Load += new System.EventHandler(this.Form_DiemSo_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctx_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_diemso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDiemSo)).EndInit();
            this.bindingNavigatorDiemSo.ResumeLayout(false);
            this.bindingNavigatorDiemSo.PerformLayout();
            this.navPaneLeft.ResumeLayout(false);
            this.navPanelNhapDuLieu.ResumeLayout(false);
            this.navPanelNhapDuLieu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.BindingNavigator bindingNavigatorDiemSo;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtn_xoa;
        private System.Windows.Forms.ToolStripButton tsbtn_sua;
        private System.Windows.Forms.ToolStripButton tsbtn_luu;
        private System.Windows.Forms.ToolStripButton tsbtn_thoat;
        private DevComponents.DotNetBar.ButtonItem buttonItemNhapDuLieu;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_diemso;
        private DevComponents.DotNetBar.ContextMenuBar ctx_menu;
        private DevComponents.DotNetBar.ButtonItem btn_menu;
        private DevComponents.DotNetBar.ButtonItem btn_themmoi;
        private DevComponents.DotNetBar.ButtonItem btn_xoa;
        private DevComponents.DotNetBar.ButtonItem btn_sua;
        private DevComponents.DotNetBar.ButtonItem btn_luu;
        private DevComponents.DotNetBar.ButtonItem btn_thoat;
        private DevComponents.DotNetBar.NavigationPane navPaneLeft;
        private DevComponents.DotNetBar.NavigationPanePanel navPanelNhapDuLieu;
        private System.Windows.Forms.Label label01;
        private System.Windows.Forms.Label label02;
        private System.Windows.Forms.Label label04;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_monhoc;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_namhoc;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_hocky;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_lop;
        private System.Windows.Forms.Label label03;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonX btn_hienthidanhsach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}