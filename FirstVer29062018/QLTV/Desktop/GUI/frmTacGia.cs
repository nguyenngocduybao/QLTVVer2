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
            string[] TenTacGia = new string[10000];
            TenTacGia =  GetDataDAO.Instance.getArrayTenTacGia();
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            data.AddRange(TenTacGia.ToArray());
            tb_TenTacGia.AutoCompleteCustomSource = data;
            tb_TenTacGia.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
