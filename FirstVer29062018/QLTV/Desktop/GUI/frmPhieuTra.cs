using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop.HelperUI;
using Data.DTO;
using Data.DAO;
using Data.Dtos;
using Service.ABSTRACT;

namespace Desktop.GUI
{
    public partial class frmPhieuTra : Form
    {
        public frmPhieuTra()
        {
            InitializeComponent();
        }
        #region VaLue
        public string HoTenDG { set; get; }
        public int IDLoaiDG { set; get; }
        public int Ten { set; get; }
        public int IDPhieuMuon { get; set; }
        public DateTime NgayTra;
        #endregion
        #region Load DateGridview
        private void frmPhieuTra_Load(object sender, EventArgs e)
        {
            dgv_DuLieuPT.AutoGenerateColumns = false;
            tb_TenNguoiMuon.Text = HoTenDG;
            int IDGiuBien = IDLoaiDG;
            fillPhieuTra();
        }
        #endregion
        #region Event Click
        private void bt_CNDL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_TenNguoiMuon.Text)) { MessageBox.Show("Không được để trống họ tên người mượn.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_TenNguoiMuon.Focus(); }
            else
            {
                try
                {
                    if (string.IsNullOrEmpty(tb_TenNguoiMuon.Text)) { MessageBox.Show("Không được để trống họ tên người mượn.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_TenNguoiMuon.Focus(); }
                    else
                    {
                        //viet ham add ha a?
                        PhieuTraService PTSv = new PhieuTraService();
                        PhieuTraDtos ls = new PhieuTraDtos();
                        IDPhieuMuon =Int32.Parse(cbb_IDPhieuMuon.Text);
                        HoTenDG = tb_TenNguoiMuon.Text;
                        NgayTra = dt_NgayTra.Value;
                        ls.NgayTra = NgayTra;
                        ls.TenDG = HoTenDG;
                        ls.IDPhieuMuon = IDPhieuMuon;
                        List<int> ID = new List<int>();
                        var myOtherList = listbox_TenDauSach.Items.Cast<int>().ToList();
                        ID = myOtherList;
                        PTSv.AddFormPhieuTra(ls, ID);
                        MessageBox.Show("Thêm thành công");
                        fillPhieuTra();
                        listbox_TenDauSach.Items.Clear();
                    }
                }
                catch
                {

                }
            }
        }
        private void bt_Lamlai_Click(object sender, EventArgs e)
        {
            HelperGUI.ResetAllControls(groupControl_TTPT);
            listbox_TenDauSach.Items.Clear();
        }
        private void tb_TenNguoiMuon_TextChanged(object sender, EventArgs e)
        {
            List<CuonSachDtos> cuonsach = new List<CuonSachDtos>();
            cuonsach = GetDataDAO.Instance.getListCuonSachDtos(tb_TenNguoiMuon.Text);
            dgv_DuLieuTra.DataSource = cuonsach;
            List<string> ID = new List<string>();
            ID = GetDataDAO.Instance.getListIDPhieuMuonToHoTenDG(tb_TenNguoiMuon.Text);
            cbb_IDPhieuMuon.DataSource = ID;
        }
        private void btn_ChonSachVaoList_Click(object sender, EventArgs e)
        {
            Ten = Int32.Parse(dgv_DuLieuTra.CurrentRow.Cells["IDCuonSach"].Value.ToString());
            listbox_TenDauSach.Items.Add(Ten);
           
            
        }
        #endregion
        #region DatetimepickerChanged
        private void dt_NgayTra_ValueChanged(object sender, EventArgs e)
        {
            NgayTra = dt_NgayTra.Value;
        }
        #endregion
        #region Load Du Lieu
        public void fillPhieuTra()
        {
            List<CTPhieuTraDTO> ls = new List<CTPhieuTraDTO>();
            PhieuTraService PTSv = new PhieuTraService();
            ls = PTSv.getALlFormPhieuTraAndCTPhieuTra();
            dgv_DuLieuPT.DataSource = ls;
        }
        #endregion
    }
}
