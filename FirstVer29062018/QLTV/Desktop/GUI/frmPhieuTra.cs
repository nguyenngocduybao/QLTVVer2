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
    public partial class frmPhieuTra : Form
    {
        public frmPhieuTra()
        {
            InitializeComponent();
        }
        #region VaLue
        public string HoTenDG { set; get; }
        public int IDLoaiDG { set; get; }
        public DateTime NgayTra;
        #endregion
        #region Load DateGridview
        private void frmPhieuTra_Load(object sender, EventArgs e)
        {
            tb_TenNguoiMuon.Text = HoTenDG;
            int IDGiuBien = IDLoaiDG;
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

                }
                catch
                {

                }
            }
        }

        private void bt_Lamlai_Click(object sender, EventArgs e)
        {
            HelperGUI.ResetAllControls(groupControl_TTPT);
        }
        #endregion
    }
}
