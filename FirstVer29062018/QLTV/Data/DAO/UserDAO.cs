using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;


namespace Data.DAO
{
    public class UserDAO
    {
        #region Instance
        private static UserDAO instance;

        internal static UserDAO Instance
        {
            get
            {
                if (instance == null) instance = new UserDAO(); return DAO.UserDAO.instance;
            }

            private set
            {
                DAO.UserDAO.instance = value;
            }
        }
        #endregion
        #region Operator+
        public int IDPlus()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var query = ((from a in db.USERS select a.IDDocGia).Max()).ToString();
                int ID = Int32.Parse(query);
                int IDadd = ++ID;
                return IDadd;
            }
        }
        #endregion
        
    }

}
