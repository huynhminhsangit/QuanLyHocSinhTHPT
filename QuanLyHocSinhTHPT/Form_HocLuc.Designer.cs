namespace QuanLyHocSinhTHPT
{
    partial class Form_HocLuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_HocLuc));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.ctx_menu = new DevComponents.DotNetBar.ContextMenuBar();
            this.btn_menu = new DevComponents.DotNetBar.ButtonItem();
            this.btn_themmoi = new DevComponents.DotNetBar.ButtonItem();
            this.btn_xoa = new DevComponents.DotNetBar.ButtonItem();
            this.btn_sua = new DevComponents.DotNetBar.ButtonItem();
            this.btn_luu = new DevComponents.DotNetBar.ButtonItem();
            this.btn_thoat = new DevComponents.DotNetBar.ButtonItem();
            this.dgv_hocluc = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorHocLuc = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctx_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hocluc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocLuc)).BeginInit();
            this.bindingNavigatorHocLuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.ctx_menu);
            this.groupBox.Controls.Add(this.bindingNavigatorHocLuc);
            this.groupBox.Controls.Add(this.dgv_hocluc);
            this.groupBox.Location = new System.Drawing.Point(13, 13);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(844, 246);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Xếp loại học lực";
            // 
            // ctx_menu
            // 
            this.ctx_menu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ctx_menu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_menu});
            this.ctx_menu.Location = new System.Drawing.Point(276, 136);
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
            // dgv_hocluc
            // 
            this.dgv_hocluc.AllowUserToAddRows = false;
            this.dgv_hocluc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_hocluc.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hocluc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_hocluc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hocluc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.ctx_menu.SetContextMenuEx(this.dgv_hocluc, this.btn_menu);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_hocluc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_hocluc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_hocluc.Location = new System.Drawing.Point(4, 48);
            this.dgv_hocluc.Name = "dgv_hocluc";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hocluc.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_hocluc.Size = new System.Drawing.Size(836, 194);
            this.dgv_hocluc.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MAHOCLUC";
            this.Column1.HeaderText = "Mã loại học lực";
            this.Column1.MaxInputLength = 10;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TENHOCLUC";
            this.Column2.HeaderText = "Tên loại học lực";
            this.Column2.MaxInputLength = 30;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "DIEMCANDUOI";
            this.Column3.HeaderText = "Điểm cận dưới";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "DIEMCANTREN";
            this.Column4.HeaderText = "Điểm cận trên";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "DIEMKHONGCHE";
            this.Column5.HeaderText = "Điểm khống chế";
            this.Column5.Name = "Column5";
            // 
            // bindingNavigatorHocLuc
            // 
            this.bindingNavigatorHocLuc.AddNewItem = null;
            this.bindingNavigatorHocLuc.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorHocLuc.CountItemFormat = "của {0}";
            this.bindingNavigatorHocLuc.DeleteItem = null;
            this.bindingNavigatorHocLuc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorHocLuc.Location = new System.Drawing.Point(4, 20);
            this.bindingNavigatorHocLuc.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorHocLuc.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorHocLuc.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorHocLuc.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorHocLuc.Name = "bindingNavigatorHocLuc";
            this.bindingNavigatorHocLuc.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorHocLuc.Size = new System.Drawing.Size(836, 25);
            this.bindingNavigatorHocLuc.TabIndex = 6;
            this.bindingNavigatorHocLuc.Text = "bindingNavigatorHocLuc";
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
            // Form_HocLuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 304);
            this.Controls.Add(this.groupBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_HocLuc";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỌC LỰC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_HocLuc_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctx_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hocluc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocLuc)).EndInit();
            this.bindingNavigatorHocLuc.ResumeLayout(false);
            this.bindingNavigatorHocLuc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private DevComponents.DotNetBar.ContextMenuBar ctx_menu;
        private DevComponents.DotNetBar.ButtonItem btn_menu;
        private DevComponents.DotNetBar.ButtonItem btn_themmoi;
        private DevComponents.DotNetBar.ButtonItem btn_xoa;
        private DevComponents.DotNetBar.ButtonItem btn_sua;
        private DevComponents.DotNetBar.ButtonItem btn_luu;
        private DevComponents.DotNetBar.ButtonItem btn_thoat;
        private System.Windows.Forms.BindingNavigator bindingNavigatorHocLuc;
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
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_hocluc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}