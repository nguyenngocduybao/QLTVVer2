﻿namespace Desktop.GUI
{
    partial class frmSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSach));
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.groupControl_TTDG = new DevExpress.XtraEditors.GroupControl();
            this.tb_DonGia = new System.Windows.Forms.TextBox();
            this.tb_SoLuong = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_TenTacGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_NamXuatBan = new System.Windows.Forms.ComboBox();
            this.tb_NhaXuatBan = new System.Windows.Forms.TextBox();
            this.tb_GiaTien = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbb_TheLoaiSach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_TenDauSach = new System.Windows.Forms.TextBox();
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
            this.cl_IDSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_TenDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_TenLoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_NhaXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_NamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_TTDG)).BeginInit();
            this.groupControl_TTDG.SuspendLayout();
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
            this.navigationPane1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage2,
            this.navigationPage1});
            this.navigationPane1.RegularSize = new System.Drawing.Size(927, 1103);
            this.navigationPane1.SelectedPage = this.navigationPage2;
            this.navigationPane1.Size = new System.Drawing.Size(927, 1103);
            this.navigationPane1.TabIndex = 1;
            this.navigationPane1.Text = "Tìm kiếm thông tin độc giả";
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Thêm sách";
            this.navigationPage2.Controls.Add(this.navigationFrame1);
            this.navigationPage2.Controls.Add(this.groupControl_TTDG);
            this.navigationPage2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage2.ImageOptions.Image")));
            this.navigationPage2.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.navigationPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(813, 1023);
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationFrame1.Location = new System.Drawing.Point(0, 0);
            this.navigationFrame1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.SelectedPage = null;
            this.navigationFrame1.Size = new System.Drawing.Size(813, 0);
            this.navigationFrame1.TabIndex = 2;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // groupControl_TTDG
            // 
            this.groupControl_TTDG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl_TTDG.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl_TTDG.Appearance.Options.UseFont = true;
            this.groupControl_TTDG.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl_TTDG.AppearanceCaption.Options.UseFont = true;
            this.groupControl_TTDG.AutoSize = true;
            this.groupControl_TTDG.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl_TTDG.CaptionImageOptions.Image")));
            this.groupControl_TTDG.Controls.Add(this.cbb_TheLoaiSach);
            this.groupControl_TTDG.Controls.Add(this.tb_TenTacGia);
            this.groupControl_TTDG.Controls.Add(this.label1);
            this.groupControl_TTDG.Controls.Add(this.tb_DonGia);
            this.groupControl_TTDG.Controls.Add(this.tb_TenDauSach);
            this.groupControl_TTDG.Controls.Add(this.label3);
            this.groupControl_TTDG.Controls.Add(this.label2);
            this.groupControl_TTDG.Controls.Add(this.cbb_NamXuatBan);
            this.groupControl_TTDG.Controls.Add(this.tb_SoLuong);
            this.groupControl_TTDG.Controls.Add(this.tb_NhaXuatBan);
            this.groupControl_TTDG.Controls.Add(this.label14);
            this.groupControl_TTDG.Controls.Add(this.label19);
            this.groupControl_TTDG.Controls.Add(this.label13);
            this.groupControl_TTDG.Controls.Add(this.tb_GiaTien);
            this.groupControl_TTDG.Controls.Add(this.label18);
            this.groupControl_TTDG.Controls.Add(this.label16);
            this.groupControl_TTDG.Controls.Add(this.bt_Lamlai);
            this.groupControl_TTDG.Controls.Add(this.bt_CNDL);
            this.groupControl_TTDG.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl_TTDG.Location = new System.Drawing.Point(0, 0);
            this.groupControl_TTDG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupControl_TTDG.Name = "groupControl_TTDG";
            this.groupControl_TTDG.Size = new System.Drawing.Size(780, 1125);
            this.groupControl_TTDG.TabIndex = 0;
            this.groupControl_TTDG.Text = "Thông tin sách";
            // 
            // tb_DonGia
            // 
            this.tb_DonGia.Location = new System.Drawing.Point(227, 503);
            this.tb_DonGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_DonGia.Name = "tb_DonGia";
            this.tb_DonGia.Size = new System.Drawing.Size(508, 42);
            this.tb_DonGia.TabIndex = 29;
            this.tb_DonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_DonGia_KeyPress);
            // 
            // tb_SoLuong
            // 
            this.tb_SoLuong.Location = new System.Drawing.Point(227, 445);
            this.tb_SoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_SoLuong.Name = "tb_SoLuong";
            this.tb_SoLuong.Size = new System.Drawing.Size(508, 42);
            this.tb_SoLuong.TabIndex = 21;
            this.tb_SoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_SoLuong_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(16, 506);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(124, 35);
            this.label19.TabIndex = 22;
            this.label19.Text = "Đơn giá:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(16, 448);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(139, 35);
            this.label18.TabIndex = 27;
            this.label18.Text = "Số lượng:";
            // 
            // tb_TenTacGia
            // 
            this.tb_TenTacGia.Location = new System.Drawing.Point(227, 205);
            this.tb_TenTacGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_TenTacGia.Name = "tb_TenTacGia";
            this.tb_TenTacGia.Size = new System.Drawing.Size(508, 42);
            this.tb_TenTacGia.TabIndex = 33;
            this.tb_TenTacGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_TenTacGia_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(16, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 35);
            this.label3.TabIndex = 32;
            this.label3.Text = "Tên tác giả:";
            // 
            // cbb_NamXuatBan
            // 
            this.cbb_NamXuatBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_NamXuatBan.FormattingEnabled = true;
            this.cbb_NamXuatBan.Location = new System.Drawing.Point(227, 325);
            this.cbb_NamXuatBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbb_NamXuatBan.Name = "cbb_NamXuatBan";
            this.cbb_NamXuatBan.Size = new System.Drawing.Size(508, 43);
            this.cbb_NamXuatBan.TabIndex = 31;
            // 
            // tb_NhaXuatBan
            // 
            this.tb_NhaXuatBan.Location = new System.Drawing.Point(227, 265);
            this.tb_NhaXuatBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_NhaXuatBan.Name = "tb_NhaXuatBan";
            this.tb_NhaXuatBan.Size = new System.Drawing.Size(508, 42);
            this.tb_NhaXuatBan.TabIndex = 30;
            this.tb_NhaXuatBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_NhaXuatBan_KeyPress);
            // 
            // tb_GiaTien
            // 
            this.tb_GiaTien.Location = new System.Drawing.Point(227, 385);
            this.tb_GiaTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_GiaTien.Name = "tb_GiaTien";
            this.tb_GiaTien.Size = new System.Drawing.Size(508, 42);
            this.tb_GiaTien.TabIndex = 21;
            this.tb_GiaTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_GiaTien_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(16, 388);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 35);
            this.label16.TabIndex = 25;
            this.label16.Text = "Giá tiền:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(16, 328);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(203, 35);
            this.label14.TabIndex = 23;
            this.label14.Text = "Năm xuất bản:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(16, 268);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(195, 35);
            this.label13.TabIndex = 22;
            this.label13.Text = "Nhà xuất bản:";
            // 
            // cbb_TheLoaiSach
            // 
            this.cbb_TheLoaiSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TheLoaiSach.FormattingEnabled = true;
            this.cbb_TheLoaiSach.Location = new System.Drawing.Point(227, 145);
            this.cbb_TheLoaiSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbb_TheLoaiSach.Name = "cbb_TheLoaiSach";
            this.cbb_TheLoaiSach.Size = new System.Drawing.Size(508, 43);
            this.cbb_TheLoaiSach.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 35);
            this.label1.TabIndex = 21;
            this.label1.Text = "Thẻ loại sách:";
            // 
            // tb_TenDauSach
            // 
            this.tb_TenDauSach.Location = new System.Drawing.Point(227, 85);
            this.tb_TenDauSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_TenDauSach.Name = "tb_TenDauSach";
            this.tb_TenDauSach.Size = new System.Drawing.Size(508, 42);
            this.tb_TenDauSach.TabIndex = 20;
            this.tb_TenDauSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_TenDauSach_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đầu sách:";
            // 
            // bt_Lamlai
            // 
            this.bt_Lamlai.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Lamlai.Image = ((System.Drawing.Image)(resources.GetObject("bt_Lamlai.Image")));
            this.bt_Lamlai.Location = new System.Drawing.Point(406, 608);
            this.bt_Lamlai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_Lamlai.Name = "bt_Lamlai";
            this.bt_Lamlai.Size = new System.Drawing.Size(141, 65);
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
            this.bt_CNDL.Location = new System.Drawing.Point(111, 608);
            this.bt_CNDL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_CNDL.Name = "bt_CNDL";
            this.bt_CNDL.Size = new System.Drawing.Size(213, 65);
            this.bt_CNDL.TabIndex = 14;
            this.bt_CNDL.Text = "Cập nhật dữ liệu";
            this.bt_CNDL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_CNDL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_CNDL.UseVisualStyleBackColor = true;
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Tìm kiếm thông tin độc giả";
            this.navigationPage1.Controls.Add(this.groupControl3);
            this.navigationPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage1.ImageOptions.Image")));
            this.navigationPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(813, 1023);
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
            this.groupControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(780, 1023);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Tìm kiếm thông tin:";
            // 
            // bt_TimKiem
            // 
            this.bt_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("bt_TimKiem.Image")));
            this.bt_TimKiem.Location = new System.Drawing.Point(240, 348);
            this.bt_TimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_TimKiem.Name = "bt_TimKiem";
            this.bt_TimKiem.Size = new System.Drawing.Size(225, 66);
            this.bt_TimKiem.TabIndex = 4;
            this.bt_TimKiem.Text = "Tìm kiếm";
            this.bt_TimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_TimKiem.UseVisualStyleBackColor = true;
            // 
            // tb_NhapTT
            // 
            this.tb_NhapTT.Location = new System.Drawing.Point(316, 243);
            this.tb_NhapTT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_NhapTT.Name = "tb_NhapTT";
            this.tb_NhapTT.Size = new System.Drawing.Size(398, 42);
            this.tb_NhapTT.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(21, 243);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 35);
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
            this.cbb_ThongTinTimKiem.Location = new System.Drawing.Point(316, 146);
            this.cbb_ThongTinTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbb_ThongTinTimKiem.Name = "cbb_ThongTinTimKiem";
            this.cbb_ThongTinTimKiem.Size = new System.Drawing.Size(398, 43);
            this.cbb_ThongTinTimKiem.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(21, 145);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 35);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thông tin tìm kiếm:";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.bindingNavigator1);
            this.groupControl2.Controls.Add(this.dgv_DuLieu);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl2.Location = new System.Drawing.Point(936, 80);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(992, 1023);
            this.groupControl2.TabIndex = 2;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 43);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(992, 39);
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
            this.toolStripBt_Luu.Size = new System.Drawing.Size(86, 36);
            this.toolStripBt_Luu.Text = "Lưu";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripBt_SuaTT
            // 
            this.toolStripBt_SuaTT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBt_SuaTT.ForeColor = System.Drawing.Color.Red;
            this.toolStripBt_SuaTT.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBt_SuaTT.Image")));
            this.toolStripBt_SuaTT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBt_SuaTT.Name = "toolStripBt_SuaTT";
            this.toolStripBt_SuaTT.Size = new System.Drawing.Size(198, 36);
            this.toolStripBt_SuaTT.Text = "Sữa thông tin";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripBt_Xoa
            // 
            this.toolStripBt_Xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBt_Xoa.ForeColor = System.Drawing.Color.Red;
            this.toolStripBt_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBt_Xoa.Image")));
            this.toolStripBt_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBt_Xoa.Name = "toolStripBt_Xoa";
            this.toolStripBt_Xoa.Size = new System.Drawing.Size(87, 36);
            this.toolStripBt_Xoa.Text = "Xóa";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripBt_XuatCSV
            // 
            this.toolStripBt_XuatCSV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBt_XuatCSV.ForeColor = System.Drawing.Color.Red;
            this.toolStripBt_XuatCSV.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBt_XuatCSV.Image")));
            this.toolStripBt_XuatCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBt_XuatCSV.Name = "toolStripBt_XuatCSV";
            this.toolStripBt_XuatCSV.Size = new System.Drawing.Size(147, 36);
            this.toolStripBt_XuatCSV.Text = "Xuất CSV";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripBt_Reset
            // 
            this.toolStripBt_Reset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBt_Reset.ForeColor = System.Drawing.Color.Red;
            this.toolStripBt_Reset.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBt_Reset.Image")));
            this.toolStripBt_Reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBt_Reset.Name = "toolStripBt_Reset";
            this.toolStripBt_Reset.Size = new System.Drawing.Size(191, 36);
            this.toolStripBt_Reset.Text = "Reset dữ liệu";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripBt_Thoat
            // 
            this.toolStripBt_Thoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBt_Thoat.ForeColor = System.Drawing.Color.Red;
            this.toolStripBt_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBt_Thoat.Image")));
            this.toolStripBt_Thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBt_Thoat.Name = "toolStripBt_Thoat";
            this.toolStripBt_Thoat.Size = new System.Drawing.Size(108, 36);
            this.toolStripBt_Thoat.Text = "Thoát";
            // 
            // dgv_DuLieu
            // 
            this.dgv_DuLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DuLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_IDSach,
            this.cl_TenDauSach,
            this.cl_TenTacGia,
            this.cl_TenLoaiSach,
            this.cl_NhaXB,
            this.cl_NamXB,
            this.cl_SoLuongTon,
            this.cl_DonGia,
            this.cl_GiaTien,
            this.cl_ThanhTien});
            this.dgv_DuLieu.Location = new System.Drawing.Point(0, 102);
            this.dgv_DuLieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_DuLieu.Name = "dgv_DuLieu";
            this.dgv_DuLieu.Size = new System.Drawing.Size(992, 922);
            this.dgv_DuLieu.TabIndex = 0;
            // 
            // cl_IDSach
            // 
            this.cl_IDSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_IDSach.DataPropertyName = "IDSach";
            this.cl_IDSach.HeaderText = "STT";
            this.cl_IDSach.Name = "cl_IDSach";
            this.cl_IDSach.Width = 105;
            // 
            // cl_TenDauSach
            // 
            this.cl_TenDauSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_TenDauSach.DataPropertyName = "TenDauSach";
            this.cl_TenDauSach.HeaderText = "Tên sách";
            this.cl_TenDauSach.Name = "cl_TenDauSach";
            this.cl_TenDauSach.Width = 180;
            // 
            // cl_TenTacGia
            // 
            this.cl_TenTacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_TenTacGia.DataPropertyName = "TenTacGia";
            this.cl_TenTacGia.HeaderText = "Tên tác giả";
            this.cl_TenTacGia.Name = "cl_TenTacGia";
            this.cl_TenTacGia.Width = 211;
            // 
            // cl_TenLoaiSach
            // 
            this.cl_TenLoaiSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_TenLoaiSach.DataPropertyName = "TenLoaiSach";
            this.cl_TenLoaiSach.HeaderText = "Thể loại";
            this.cl_TenLoaiSach.Name = "cl_TenLoaiSach";
            this.cl_TenLoaiSach.Width = 167;
            // 
            // cl_NhaXB
            // 
            this.cl_NhaXB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_NhaXB.DataPropertyName = "NhaXB";
            this.cl_NhaXB.HeaderText = "Nhà xuất bản";
            this.cl_NhaXB.Name = "cl_NhaXB";
            this.cl_NhaXB.Width = 225;
            // 
            // cl_NamXB
            // 
            this.cl_NamXB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_NamXB.DataPropertyName = "NamXB";
            this.cl_NamXB.HeaderText = "Năm xuất bản";
            this.cl_NamXB.Name = "cl_NamXB";
            this.cl_NamXB.Width = 185;
            // 
            // cl_SoLuongTon
            // 
            this.cl_SoLuongTon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_SoLuongTon.DataPropertyName = "SoLuongTon";
            this.cl_SoLuongTon.HeaderText = "Số lượng tồn";
            this.cl_SoLuongTon.Name = "cl_SoLuongTon";
            this.cl_SoLuongTon.Width = 218;
            // 
            // cl_DonGia
            // 
            this.cl_DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_DonGia.DataPropertyName = "DonGia";
            this.cl_DonGia.HeaderText = "Đơn giá";
            this.cl_DonGia.Name = "cl_DonGia";
            this.cl_DonGia.Width = 110;
            // 
            // cl_GiaTien
            // 
            this.cl_GiaTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_GiaTien.DataPropertyName = "GiaTien";
            this.cl_GiaTien.HeaderText = "Giá tiền";
            this.cl_GiaTien.Name = "cl_GiaTien";
            this.cl_GiaTien.Width = 152;
            // 
            // cl_ThanhTien
            // 
            this.cl_ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_ThanhTien.DataPropertyName = "TongTien";
            this.cl_ThanhTien.HeaderText = "Tổng tiền";
            this.cl_ThanhTien.Name = "cl_ThanhTien";
            this.cl_ThanhTien.Width = 174;
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1941, 1103);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.navigationPane1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSach";
            this.Text = "frmSach";
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_TTDG)).EndInit();
            this.groupControl_TTDG.ResumeLayout(false);
            this.groupControl_TTDG.PerformLayout();
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
        private System.Windows.Forms.Button bt_Lamlai;
        private System.Windows.Forms.Button bt_CNDL;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Button bt_TimKiem;
        private System.Windows.Forms.TextBox tb_NhapTT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbb_ThongTinTimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_TenDauSach;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_GiaTien;
        private System.Windows.Forms.TextBox tb_NhaXuatBan;
        private System.Windows.Forms.TextBox tb_DonGia;
        private System.Windows.Forms.TextBox tb_SoLuong;
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
        private System.Windows.Forms.ComboBox cbb_NamXuatBan;
        private System.Windows.Forms.TextBox tb_TenTacGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_TheLoaiSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_IDSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_TenDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_TenTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_TenLoaiSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_NhaXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_NamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_SoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_ThanhTien;
    }
}