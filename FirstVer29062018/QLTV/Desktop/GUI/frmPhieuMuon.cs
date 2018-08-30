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

                }
                catch
                {

                }
            }
        }

        private void bt_Lamlai_Click(object sender, EventArgs e)
        {
            HelperGUI.ResetAllControls(groupControl_TTPM);
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
            tb_TenNguoiMuon.Text = HoTenDG;
            int IDGiuBien = IDLoaiDG;
            AutocompleteTenSach();
        }
        #endregion
        #region Autocomplete
        public void AutocompleteTenSach()
        {
            HelperGUI.Instance.autocompleteTenDauSach(tb_TenDauSach);
        }
        #endregion
    }
}
