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
using Data.Dtos;
using Service.ABSTRACT;
using Data.DAO;
using Service.ABSTRACT;
using Desktop.HelperUI;

namespace Desktop.GUI
{
    public partial class frmTacGia : Form
    {
        public frmTacGia()
        {
            InitializeComponent();
        }
        #region Value
        public string TenTacGia;
        public DateTime NgaySinh;
        #endregion
        #region Event Keypress
        private void tb_TenTacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperGUI.Instance.CheckKiTu(sender, e);
        }
        #endregion
        #region getValueChanged Datetimepicker
        private void dt_NgaySinh_ValueChanged(object sender, EventArgs e)
        {
            NgaySinh = dt_NgaySinh.Value;
        }
        #endregion
        #region AutoComplete
        public void AutoCompleteTenTG()
        {
            HelperGUI.Instance.autocompleteTenTacGia(tb_TenTacGia);
        }
        #endregion
        #region LoadfrmTacGia
        private void frmTacGia_Load(object sender, EventArgs e)
        {
            AutoCompleteTenTG();
        }
        #endregion
    }
}
