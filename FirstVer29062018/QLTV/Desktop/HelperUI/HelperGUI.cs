using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Desktop.HelperUI
{
    class HelperGUI
    {
        #region Instance
        private static HelperGUI instance;

        internal static HelperGUI Instance
        {
            get
            {
                if (instance == null) instance = new HelperGUI(); return HelperUI.HelperGUI.instance;
            }

            private set
            {
                HelperUI.HelperGUI.instance = value;
            }
        }
        #endregion

        #region Format control
        //Kiểm tra họ tên độc giả
        public string KiemTraHoTenDG(string HoTenDG)
        {
            string kq="";
            HoTenDG = HoTenDG.Trim().ToLower();
            for (int i = 0; i < HoTenDG.Length; i++)
            {
                if (i == 0)
                    kq += HoTenDG[i].ToString().ToUpper();
                else
                    kq += HoTenDG[i];
                if (HoTenDG[i] == ' ')
                {
                    while (HoTenDG[i] == ' ')
                    {
                        i++;
                    }
                    kq += HoTenDG[i].ToString().ToUpper();
                }
            }
                return kq.ToString();
        }
        //kiểm tra Email đúng đinh dạng
        public bool IsValidEmail(string email)
        {
            string pattern = @"^[-a-zA-Z0-9][-.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[-.a-zA-Z0-9]+)*\.
            (com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|tv|[a-zA-Z]{2})$";

            Regex check = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);

            bool valid = false;
            if (string.IsNullOrEmpty(email))
            {
                valid = false;
            }
            else
            {
                valid = check.IsMatch(email);
            }
            return valid;
        }
        //check Email có nhiều hơn 4 kí tự
        public void checkIsMail(TextBox Email)
        {
            if (HelperGUI.Instance.IsValidEmail(Email.Text) == true)
            {
                for (int i = 0; i <= 3; i++)
                {
                    if (Email.Text[i] == '@')
                    {
                        MessageBox.Show("Email không hợp lệ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Email không hợp lệ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
