using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class TacGiaDAO
    {
        #region Instance
        private static TacGiaDAO instance;

        internal static TacGiaDAO Instance
        {
            get
            {
                if (instance == null) instance = new TacGiaDAO(); return DAO.TacGiaDAO.instance;
            }

            private set
            {
                DAO.TacGiaDAO.instance = value;
            }
        }
        #endregion
        #region Operator+
        public int IDPlus()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var query = ((from a in db.TACGIAs select a.IDTacGia).Max()).ToString();
                int ID = Int32.Parse(query);
                int IDadd = ++ID;
                return IDadd;
            }
        }
        #endregion
    }
}
