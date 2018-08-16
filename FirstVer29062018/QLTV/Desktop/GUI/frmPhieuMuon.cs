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
        #region getValueChanged Datetimepicker  
        private void dt_NgaySinh_ValueChanged(object sender, EventArgs e)
        {
            NgayMuon = dt_NgayMuon.Value;
        }

        #endregion
        #region Load Du Lieu
        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            tb_TenTacGia.Text = HoTenDG;
            int IDGiuBien = IDLoaiDG;
        }
        #endregion
    }
}
