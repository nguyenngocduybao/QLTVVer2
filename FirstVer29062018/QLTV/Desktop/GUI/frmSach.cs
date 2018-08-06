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
using System.Text.RegularExpressions;
using Data.DAO;

namespace Desktop.GUI
{
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
        }

        #region Value
        public string TenDauSach;
        public string NhaXB;
        string TenLoaiSach;
        string TenTacGia;
        public int NamXB;
        public int SoLuongTon;
        public decimal GiaTien;
        public int SoLuong;
        public decimal DonGia;
        public decimal TongTien;
        #endregion
        #region Event KeyPress
        private void tb_TenDauSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperGUI.Instance.CheckKiTu(sender, e);
        }
        private void tb_NhaXuatBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperGUI.Instance.CheckKiTu(sender, e);
        }
        private void tb_TenTacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperGUI.Instance.CheckKiTu(sender, e);
        }
        private void tb_SoLuongTon_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperGUI.Instance.CheckInt(sender, e);
        }
        private void tb_GiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperGUI.Instance.CheckInt(sender, e);
        }
        private void tb_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperGUI.Instance.CheckInt(sender, e);
        }
        private void tb_DonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperGUI.Instance.CheckInt(sender, e);
        }
        private void tb_ThanhTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperGUI.Instance.CheckInt(sender, e);
        }

        #endregion
        #region Event Click
        private void btn_ThemLoaiSach_Click(object sender, EventArgs e)
        {
            FrmThemLoaiSach frm = new FrmThemLoaiSach();
            frm.ShowDialog();
        }
        #endregion
        #region Load Data to Combobox
        //get Thể Loại Sáchd Database
        public void fillTheLoaiSachDataFromTableSach()
        {
            List<string> TenTheLoai = new List<string>();
            TenTheLoai = GetDataDAO.Instance.getListTenTheLoaiSach();
            cbb_TheLoaiSach.DataSource = TenTheLoai;
        }
        #endregion

        private void frmSach_Load(object sender, EventArgs e)
        {
            fillTheLoaiSachDataFromTableSach();
        }
    }
}
