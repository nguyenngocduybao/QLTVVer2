using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Desktop.HelperUI;
using System.Text.RegularExpressions;
using Data.DAO;
using Service.IService;
using Data.Dtos;
using Data.DTO;
using Data.IBUS;
using Service.ABSTRACT;

namespace Desktop.GUI
{
    public partial class frmTheDocGia : DevExpress.XtraEditors.XtraForm
    {
        public frmTheDocGia()
        {
            InitializeComponent();
        }

        #region Value
        public string HoTenDG;
        public string UserName;
        public string Pwd;
        public DateTime NgaySinhDG;
        public string DiaChiDG;
        public string EmailDG;
        public int IDLoaiDG;
        public DateTime NgayLapThe;
        //biến kiểm tra Email hợp lệ
        #endregion
        #region Event Click
        private void bt_CNDL_Click(object sender, EventArgs e)
        {
            MessageBox.Show(HelperGUI.Instance.KiemTraHoTenDG(tb_HoTenDG.Text));
            HelperGUI.Instance.checkIsMail(tb_Email);
        }
        #endregion
        #region Event KeyPress
        private void tb_HoTenDG_KeyPress(object sender, KeyPressEventArgs e)
        {
            int isNumber = 0;
            e.Handled = int.TryParse(e.KeyChar.ToString(), out isNumber);
        }
        #endregion
        #region getValueChanged Combobox
        private void cb_LDG_SelectedValueChanged(object sender, EventArgs e)
        {
            IDLoaiDG = HelperDAO.Instance.checkIDLoaiDGFromTenLoaiDocGia(cb_LoaiDocGia.Text);
        }
        #endregion
        #region getValueChanged Datetimepicker
        //định dạng về kểu datetimepicker
        private void dt_NgayLT_ValueChanged(object sender, EventArgs e)
        {
            NgayLapThe = dt_NgayLT.Value;
        }
        private void dt_Ngaysinh_ValueChanged(object sender, EventArgs e)
        {
            NgaySinhDG = dt_Ngaysinh.Value;
        }
        #endregion

        private void frmTheDocGia_Load(object sender, EventArgs e)
        {

        }
    }
}