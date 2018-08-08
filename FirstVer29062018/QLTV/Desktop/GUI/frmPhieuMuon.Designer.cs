namespace Desktop.GUI
{
    partial class frmPhieuMuon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuMuon));
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.groupControl_TTDG = new DevExpress.XtraEditors.GroupControl();
            this.btn_TimSach = new DevExpress.XtraEditors.SimpleButton();
            this.btn_XoaSachRaKhoiList = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ChonSachVaoList = new DevExpress.XtraEditors.SimpleButton();
            this.listbox_TenDauSach = new System.Windows.Forms.ListBox();
            this.dgv_DuLieuSach = new System.Windows.Forms.DataGridView();
            this.tb_PhieuMuon = new System.Windows.Forms.TextBox();
            this.dt_NgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_TenTacGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Lamlai = new System.Windows.Forms.Button();
            this.bt_CNDL = new System.Windows.Forms.Button();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.bt_TimKiem = new System.Windows.Forms.Button();
            this.tb_NhapTT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbb_ThongTinTimKiem = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripBt_Luu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBt_SuaTT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBt_Xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBt_XuatCSV = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBt_Reset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBt_Thoat = new System.Windows.Forms.ToolStripButton();
            this.dgv_DuLieu = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cl_TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_HanTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_TenDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_IDTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_TTDG)).BeginInit();
            this.groupControl_TTDG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DuLieuSach)).BeginInit();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DuLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Appearance.BackColor = System.Drawing.Color.White;
            this.navigationPane1.Appearance.Options.UseBackColor = true;
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage2,
            this.navigationPage1});
            this.navigationPane1.RegularSize = new System.Drawing.Size(621, 610);
            this.navigationPane1.SelectedPage = this.navigationPage2;
            this.navigationPane1.Size = new System.Drawing.Size(621, 610);
            this.navigationPane1.TabIndex = 3;
            this.navigationPane1.Text = "Tìm kiếm thông tin độc giả";
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Thêm phiếu mượn";
            this.navigationPage2.Controls.Add(this.navigationFrame1);
            this.navigationPage2.Controls.Add(this.groupControl_TTDG);
            this.navigationPage2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage2.ImageOptions.Image")));
            this.navigationPage2.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(523, 550);
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationFrame1.Location = new System.Drawing.Point(0, 0);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.SelectedPage = null;
            this.navigationFrame1.Size = new System.Drawing.Size(523, 0);
            this.navigationFrame1.TabIndex = 2;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // groupControl_TTDG
            // 
            this.groupControl_TTDG.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl_TTDG.Appearance.Options.UseFont = true;
            this.groupControl_TTDG.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl_TTDG.AppearanceCaption.Options.UseFont = true;
            this.groupControl_TTDG.AutoSize = true;
            this.groupControl_TTDG.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl_TTDG.CaptionImageOptions.Image")));
            this.groupControl_TTDG.Controls.Add(this.label3);
            this.groupControl_TTDG.Controls.Add(this.btn_TimSach);
            this.groupControl_TTDG.Controls.Add(this.btn_XoaSachRaKhoiList);
            this.groupControl_TTDG.Controls.Add(this.btn_ChonSachVaoList);
            this.groupControl_TTDG.Controls.Add(this.listbox_TenDauSach);
            this.groupControl_TTDG.Controls.Add(this.dgv_DuLieuSach);
            this.groupControl_TTDG.Controls.Add(this.tb_PhieuMuon);
            this.groupControl_TTDG.Controls.Add(this.dt_NgayMuon);
            this.groupControl_TTDG.Controls.Add(this.label1);
            this.groupControl_TTDG.Controls.Add(this.tb_TenTacGia);
            this.groupControl_TTDG.Controls.Add(this.label2);
            this.groupControl_TTDG.Controls.Add(this.bt_Lamlai);
            this.groupControl_TTDG.Controls.Add(this.bt_CNDL);
            this.groupControl_TTDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_TTDG.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl_TTDG.Location = new System.Drawing.Point(0, 0);
            this.groupControl_TTDG.Name = "groupControl_TTDG";
            this.groupControl_TTDG.Size = new System.Drawing.Size(523, 550);
            this.groupControl_TTDG.TabIndex = 0;
            this.groupControl_TTDG.Text = "Thông tin phiếu mượn";
            // 
            // btn_TimSach
            // 
            this.btn_TimSach.Location = new System.Drawing.Point(415, 130);
            this.btn_TimSach.Name = "btn_TimSach";
            this.btn_TimSach.Size = new System.Drawing.Size(108, 33);
            this.btn_TimSach.TabIndex = 29;
            this.btn_TimSach.Text = "Tìm sách";
            // 
            // btn_XoaSachRaKhoiList
            // 
            this.btn_XoaSachRaKhoiList.Location = new System.Drawing.Point(415, 284);
            this.btn_XoaSachRaKhoiList.Name = "btn_XoaSachRaKhoiList";
            this.btn_XoaSachRaKhoiList.Size = new System.Drawing.Size(108, 31);
            this.btn_XoaSachRaKhoiList.TabIndex = 28;
            this.btn_XoaSachRaKhoiList.Text = "Xóa khỏi danh sách";
            // 
            // btn_ChonSachVaoList
            // 
            this.btn_ChonSachVaoList.Location = new System.Drawing.Point(415, 189);
            this.btn_ChonSachVaoList.Name = "btn_ChonSachVaoList";
            this.btn_ChonSachVaoList.Size = new System.Drawing.Size(108, 26);
            this.btn_ChonSachVaoList.TabIndex = 27;
            this.btn_ChonSachVaoList.Text = "Chọn sách";
            // 
            // listbox_TenDauSach
            // 
            this.listbox_TenDauSach.FormattingEnabled = true;
            this.listbox_TenDauSach.ItemHeight = 23;
            this.listbox_TenDauSach.Location = new System.Drawing.Point(15, 333);
            this.listbox_TenDauSach.Name = "listbox_TenDauSach";
            this.listbox_TenDauSach.Size = new System.Drawing.Size(394, 142);
            this.listbox_TenDauSach.TabIndex = 26;
            // 
            // dgv_DuLieuSach
            // 
            this.dgv_DuLieuSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DuLieuSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_STT,
            this.cl_TenSach,
            this.cl_TrangThai});
            this.dgv_DuLieuSach.Location = new System.Drawing.Point(15, 166);
            this.dgv_DuLieuSach.Name = "dgv_DuLieuSach";
            this.dgv_DuLieuSach.Size = new System.Drawing.Size(394, 161);
            this.dgv_DuLieuSach.TabIndex = 25;
            // 
            // tb_PhieuMuon
            // 
            this.tb_PhieuMuon.Location = new System.Drawing.Point(151, 130);
            this.tb_PhieuMuon.Name = "tb_PhieuMuon";
            this.tb_PhieuMuon.Size = new System.Drawing.Size(258, 30);
            this.tb_PhieuMuon.TabIndex = 23;
            this.tb_PhieuMuon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_PhieuMuon_KeyPress);
            // 
            // dt_NgayMuon
            // 
            this.dt_NgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_NgayMuon.Location = new System.Drawing.Point(151, 93);
            this.dt_NgayMuon.Name = "dt_NgayMuon";
            this.dt_NgayMuon.Size = new System.Drawing.Size(258, 30);
            this.dt_NgayMuon.TabIndex = 22;
            this.dt_NgayMuon.ValueChanged += new System.EventHandler(this.dt_NgaySinh_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(11, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ngày mượn:";
            // 
            // tb_TenTacGia
            // 
            this.tb_TenTacGia.Location = new System.Drawing.Point(151, 55);
            this.tb_TenTacGia.Name = "tb_TenTacGia";
            this.tb_TenTacGia.Size = new System.Drawing.Size(258, 30);
            this.tb_TenTacGia.TabIndex = 20;
            this.tb_TenTacGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_TenTacGia_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên:";
            // 
            // bt_Lamlai
            // 
            this.bt_Lamlai.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Lamlai.Image = ((System.Drawing.Image)(resources.GetObject("bt_Lamlai.Image")));
            this.bt_Lamlai.Location = new System.Drawing.Point(268, 490);
            this.bt_Lamlai.Name = "bt_Lamlai";
            this.bt_Lamlai.Size = new System.Drawing.Size(94, 42);
            this.bt_Lamlai.TabIndex = 15;
            this.bt_Lamlai.Text = "Làm lại";
            this.bt_Lamlai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Lamlai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Lamlai.UseVisualStyleBackColor = true;
            // 
            // bt_CNDL
            // 
            this.bt_CNDL.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CNDL.Image = ((System.Drawing.Image)(resources.GetObject("bt_CNDL.Image")));
            this.bt_CNDL.Location = new System.Drawing.Point(29, 490);
            this.bt_CNDL.Name = "bt_CNDL";
            this.bt_CNDL.Size = new System.Drawing.Size(142, 42);
            this.bt_CNDL.TabIndex = 14;
            this.bt_CNDL.Text = "Cập nhật dữ liệu";
            this.bt_CNDL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_CNDL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_CNDL.UseVisualStyleBackColor = true;
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Tìm kiếm thông tin sách";
            this.navigationPage1.Controls.Add(this.groupControl3);
            this.navigationPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage1.ImageOptions.Image")));
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(526, 550);
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.Appearance.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl3.CaptionImageOptions.Image")));
            this.groupControl3.Controls.Add(this.bt_TimKiem);
            this.groupControl3.Controls.Add(this.tb_NhapTT);
            this.groupControl3.Controls.Add(this.label9);
            this.groupControl3.Controls.Add(this.cbb_ThongTinTimKiem);
            this.groupControl3.Controls.Add(this.label8);
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(520, 550);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Tìm kiếm thông tin:";
            // 
            // bt_TimKiem
            // 
            this.bt_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("bt_TimKiem.Image")));
            this.bt_TimKiem.Location = new System.Drawing.Point(160, 226);
            this.bt_TimKiem.Name = "bt_TimKiem";
            this.bt_TimKiem.Size = new System.Drawing.Size(150, 43);
            this.bt_TimKiem.TabIndex = 4;
            this.bt_TimKiem.Text = "Tìm kiếm";
            this.bt_TimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_TimKiem.UseVisualStyleBackColor = true;
            // 
            // tb_NhapTT
            // 
            this.tb_NhapTT.Location = new System.Drawing.Point(211, 158);
            this.tb_NhapTT.Name = "tb_NhapTT";
            this.tb_NhapTT.Size = new System.Drawing.Size(267, 30);
            this.tb_NhapTT.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(14, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nhập thông tin:";
            // 
            // cbb_ThongTinTimKiem
            // 
            this.cbb_ThongTinTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_ThongTinTimKiem.FormattingEnabled = true;
            this.cbb_ThongTinTimKiem.Items.AddRange(new object[] {
            "Tên đầu sách",
            "Nhà xuất bản",
            "Năm xuất bản",
            "Số lượng",
            "Số lượng tồn",
            "Giá tiền"});
            this.cbb_ThongTinTimKiem.Location = new System.Drawing.Point(211, 95);
            this.cbb_ThongTinTimKiem.Name = "cbb_ThongTinTimKiem";
            this.cbb_ThongTinTimKiem.Size = new System.Drawing.Size(267, 31);
            this.cbb_ThongTinTimKiem.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(14, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thông tin tìm kiếm:";
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.bindingNavigator1);
            this.groupControl2.Controls.Add(this.dgv_DuLieu);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl2.Location = new System.Drawing.Point(627, 52);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(613, 558);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Dữ liệu độc giả";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBt_Luu,
            this.toolStripSeparator1,
            this.toolStripBt_SuaTT,
            this.toolStripSeparator2,
            this.toolStripBt_Xoa,
            this.toolStripSeparator3,
            this.toolStripBt_XuatCSV,
            this.toolStripSeparator4,
            this.toolStripBt_Reset,
            this.toolStripSeparator5,
            this.toolStripBt_Thoat});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 38);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(613, 31);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripBt_Luu
            // 
            this.toolStripBt_Luu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBt_Luu.ForeColor = System.Drawing.Color.Red;
            this.toolStripBt_Luu.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBt_Luu.Image")));
            this.toolStripBt_Luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBt_Luu.Name = "toolStripBt_Luu";
            this.toolStripBt_Luu.Size = new System.Drawing.Size(67, 28);
            this.toolStripBt_Luu.Text = "Lưu";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripBt_SuaTT
            // 
            this.toolStripBt_SuaTT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBt_SuaTT.ForeColor = System.Drawing.Color.Red;
            this.toolStripBt_SuaTT.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBt_SuaTT.Image")));
            this.toolStripBt_SuaTT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBt_SuaTT.Name = "toolStripBt_SuaTT";
            this.toolStripBt_SuaTT.Size = new System.Drawing.Size(142, 28);
            this.toolStripBt_SuaTT.Text = "Sữa thông tin";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripBt_Xoa
            // 
            this.toolStripBt_Xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBt_Xoa.ForeColor = System.Drawing.Color.Red;
            this.toolStripBt_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBt_Xoa.Image")));
            this.toolStripBt_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBt_Xoa.Name = "toolStripBt_Xoa";
            this.toolStripBt_Xoa.Size = new System.Drawing.Size(67, 28);
            this.toolStripBt_Xoa.Text = "Xóa";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripBt_XuatCSV
            // 
            this.toolStripBt_XuatCSV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBt_XuatCSV.ForeColor = System.Drawing.Color.Red;
            this.toolStripBt_XuatCSV.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBt_XuatCSV.Image")));
            this.toolStripBt_XuatCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBt_XuatCSV.Name = "toolStripBt_XuatCSV";
            this.toolStripBt_XuatCSV.Size = new System.Drawing.Size(107, 28);
            this.toolStripBt_XuatCSV.Text = "Xuất CSV";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripBt_Reset
            // 
            this.toolStripBt_Reset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBt_Reset.ForeColor = System.Drawing.Color.Red;
            this.toolStripBt_Reset.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBt_Reset.Image")));
            this.toolStripBt_Reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBt_Reset.Name = "toolStripBt_Reset";
            this.toolStripBt_Reset.Size = new System.Drawing.Size(137, 28);
            this.toolStripBt_Reset.Text = "Reset dữ liệu";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripBt_Thoat
            // 
            this.toolStripBt_Thoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBt_Thoat.ForeColor = System.Drawing.Color.Red;
            this.toolStripBt_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBt_Thoat.Image")));
            this.toolStripBt_Thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBt_Thoat.Name = "toolStripBt_Thoat";
            this.toolStripBt_Thoat.Size = new System.Drawing.Size(82, 28);
            this.toolStripBt_Thoat.Text = "Thoát";
            // 
            // dgv_DuLieu
            // 
            this.dgv_DuLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DuLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_IDTacGia,
            this.Column1,
            this.cl_TenDauSach,
            this.cl_NgayMuon,
            this.cl_HanTra});
            this.dgv_DuLieu.Location = new System.Drawing.Point(0, 66);
            this.dgv_DuLieu.Name = "dgv_DuLieu";
            this.dgv_DuLieu.Size = new System.Drawing.Size(613, 492);
            this.dgv_DuLieu.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(11, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tên sách:";
            // 
            // cl_TrangThai
            // 
            this.cl_TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_TrangThai.HeaderText = "Trạng thái ";
            this.cl_TrangThai.Name = "cl_TrangThai";
            this.cl_TrangThai.Width = 139;
            // 
            // cl_TenSach
            // 
            this.cl_TenSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_TenSach.HeaderText = "Tên Sách";
            this.cl_TenSach.Name = "cl_TenSach";
            this.cl_TenSach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cl_TenSach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_TenSach.Width = 102;
            // 
            // cl_STT
            // 
            this.cl_STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_STT.HeaderText = "STT";
            this.cl_STT.Name = "cl_STT";
            this.cl_STT.Width = 71;
            // 
            // cl_HanTra
            // 
            this.cl_HanTra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cl_HanTra.DataPropertyName = "HanTra";
            this.cl_HanTra.HeaderText = "ngày trả";
            this.cl_HanTra.Name = "cl_HanTra";
            this.cl_HanTra.Width = 130;
            // 
            // cl_NgayMuon
            // 
            this.cl_NgayMuon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cl_NgayMuon.DataPropertyName = "NgayMuon";
            this.cl_NgayMuon.FillWeight = 35.7868F;
            this.cl_NgayMuon.HeaderText = "Ngày mượn";
            this.cl_NgayMuon.Name = "cl_NgayMuon";
            this.cl_NgayMuon.Width = 150;
            // 
            // cl_TenDauSach
            // 
            this.cl_TenDauSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cl_TenDauSach.HeaderText = "Tên sách";
            this.cl_TenDauSach.Name = "cl_TenDauSach";
            this.cl_TenDauSach.Width = 120;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Tên người mượn";
            this.Column1.Name = "Column1";
            this.Column1.Width = 220;
            // 
            // cl_IDTacGia
            // 
            this.cl_IDTacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cl_IDTacGia.DataPropertyName = "IDTacGia";
            this.cl_IDTacGia.FillWeight = 228.4264F;
            this.cl_IDTacGia.HeaderText = "STT";
            this.cl_IDTacGia.Name = "cl_IDTacGia";
            this.cl_IDTacGia.Width = 120;
            // 
            // frmPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 610);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.navigationPane1);
            this.Name = "frmPhieuMuon";
            this.Text = "frmPhieuMuon";
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_TTDG)).EndInit();
            this.groupControl_TTDG.ResumeLayout(false);
            this.groupControl_TTDG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DuLieuSach)).EndInit();
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DuLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraEditors.GroupControl groupControl_TTDG;
        private System.Windows.Forms.DateTimePicker dt_NgayMuon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_TenTacGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Lamlai;
        private System.Windows.Forms.Button bt_CNDL;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Button bt_TimKiem;
        private System.Windows.Forms.TextBox tb_NhapTT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbb_ThongTinTimKiem;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripBt_Luu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBt_SuaTT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBt_Xoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripBt_XuatCSV;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripBt_Reset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripBt_Thoat;
        private System.Windows.Forms.DataGridView dgv_DuLieu;
        private DevExpress.XtraEditors.SimpleButton btn_TimSach;
        private DevExpress.XtraEditors.SimpleButton btn_XoaSachRaKhoiList;
        private DevExpress.XtraEditors.SimpleButton btn_ChonSachVaoList;
        private System.Windows.Forms.ListBox listbox_TenDauSach;
        private System.Windows.Forms.DataGridView dgv_DuLieuSach;
        private System.Windows.Forms.TextBox tb_PhieuMuon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_IDTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_TenDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_HanTra;
    }
}