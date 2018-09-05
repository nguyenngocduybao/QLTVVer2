﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop.HelperUI;
using Data.DAO;
using Data.BUS;
using Data.DTO;
using Data.Dtos;
using Service.ABSTRACT;

namespace Desktop.GUI
{
    public partial class frmPhieuMuon : Form
    {
        public frmPhieuMuon()
        {
            InitializeComponent();
        }
        #region Value
        public string HoTenDG { set; get; }
        public int IDLoaiDG { set; get; }
        public string TenDauSach;
        public string TenTacGia;
        public int Ten { set; get; }
        public int KT;
        public DateTime NgayMuon;
        #endregion
        #region Event KeyPress 
        private void tb_TenTacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperGUI.Instance.CheckKiTu(sender, e);
        }
        private void tb_PhieuMuon_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperGUI.Instance.CheckKiTu(sender, e);
        }
        #endregion
        #region Event Click    
        private void bt_CNDL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_TenNguoiMuon.Text)) { MessageBox.Show("Không được để trống họ tên người mượn.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_TenNguoiMuon.Focus(); }
            else if (string.IsNullOrEmpty(tb_TenDauSach.Text)) { MessageBox.Show("Không được để trống tên đầu sách.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_TenDauSach.Focus(); }
            else if (string.IsNullOrEmpty(cbb_TenTacGia.Text)) { MessageBox.Show("Không được để trống tên tác giả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); cbb_TenTacGia.Focus(); }
            else
            {
                try
                {
                    PhieuMuonService Sv = new PhieuMuonService();
                    PhieuMuonDtos PM = new PhieuMuonDtos();
                    HoTenDG = HelperGUI.Instance.KiemTraHoTen(tb_TenNguoiMuon.Text);
                    NgayMuon = dt_NgayMuon.Value;
                    TenDauSach = tb_TenDauSach.Text;
                    PM.NgayMuon = NgayMuon;
                    PM.TenDocGia = HoTenDG;
                    List<int> ID = new List<int>();
                    var myOtherList = listbox_TenDauSach.Items.Cast<int>().ToList();
                    ID = myOtherList;
                    Sv.addFormPhieuMuonAndCTPhieuMuon(PM, ID);
                    MessageBox.Show("Thêm thành công");
                    fillTheLoaiSachDataFromTableSach();
                    listbox_TenDauSach.Items.Clear(); 
                }
                catch
                {

                }
            }
        }
        private void bt_Lamlai_Click(object sender, EventArgs e)
        {
            HelperGUI.ResetAllControls(groupControl_TTPM);
            listbox_TenDauSach.Items.Clear();
        }
        private void btn_TimSach_Click(object sender, EventArgs e)
        {
            TenDauSach = tb_TenDauSach.Text;
            TenTacGia = cbb_TenTacGia.Text;
            List<CuonSachDTO> list = new List<CuonSachDTO>();
            list = GetDataDAO.Instance.getList(TenDauSach, TenTacGia);
            dgv_DuLieuTT.DataSource = list;
        }
        private void btn_ChonSachVaoList_Click(object sender, EventArgs e)
        {
            Ten = Int32.Parse(dgv_DuLieuTT.CurrentRow.Cells["IDCuonSach"].Value.ToString());
            listbox_TenDauSach.Items.Add(Ten);
        }
        private void btn_XoaSachRaKhoiList_Click(object sender, EventArgs e)
        {
            listbox_TenDauSach.Items.RemoveAt(listbox_TenDauSach.SelectedIndex);
        }
        #endregion
        #region getValueChanged Datetimepicker  
        private void dt_NgaySinh_ValueChanged(object sender, EventArgs e)
        {
            NgayMuon = dt_NgayMuon.Value;
        }

        #endregion
        #region Load Du Lieu
        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            dgv_DuLieuPM.AutoGenerateColumns = false;
            tb_TenNguoiMuon.Text = HoTenDG;
            int IDGiuBien = IDLoaiDG;
            AutocompleteTenSach();
            fillTheLoaiSachDataFromTableSach();
        }
        #endregion
        #region Autocomplete
        public void AutocompleteTenSach()
        {
            HelperGUI.Instance.autocompleteTenDauSach(tb_TenDauSach);
        }
        private void tb_TenDauSach_TextChanged(object sender, EventArgs e)
        {
            List<string> TenTacGia = new List<string>();
            TenTacGia = GetDataDAO.Instance.getListTenTacGiaToTenDauSach(tb_TenDauSach.Text);
            cbb_TenTacGia.DataSource = TenTacGia;
        }
        #endregion
        #region LoadDataGView
        public void fillTheLoaiSachDataFromTableSach()
        {
            List<PhieuMuonDTO> ls = new List<PhieuMuonDTO>();
            PhieuMuonService PMsv = new PhieuMuonService();
            ls = PMsv.getAllFormPhieuMuonAndCTPhieuMuon();
            dgv_DuLieuPM.DataSource = ls;
        }
        #endregion
    }
}

