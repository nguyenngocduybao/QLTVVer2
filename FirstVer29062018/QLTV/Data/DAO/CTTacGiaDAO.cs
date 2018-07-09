using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class CTTacGiaDAO
    {
        #region Instance
        private static CTTacGiaDAO instance;

        internal static CTTacGiaDAO Instance
        {
            get
            {
                if (instance == null) instance = new CTTacGiaDAO(); return DAO.CTTacGiaDAO.instance;
            }

            private set
            {
                DAO.CTTacGiaDAO.instance = value;
            }
        }
        #endregion
        #region Operator+
        public int IDPlus()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var query = ((from a in db.CT_TACGIA select a.IDCTTacGia).Max()).ToString();
                int ID = Int32.Parse(query);
                int IDadd = ++ID;
                return IDadd;
            }
        }
        #endregion
    }
}
