using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class CuonSachDAO
    {
        #region Instance
        private static CuonSachDAO instance;

        public static CuonSachDAO Instance
        {
            get
            {
                if (instance == null) instance = new CuonSachDAO(); return DAO.CuonSachDAO.instance;
            }

            private set
            {
                DAO.CuonSachDAO.instance = value;
            }
        }
        #endregion
        #region Operator+
        public int IDPlus()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var query = ((from a in db.CUONSACHes select a.IDCuonSach).Max()).ToString();
                int ID = Int32.Parse(query);
                int IDadd = ++ID;
                return IDadd;
            }
        }
        #endregion
    }
}
