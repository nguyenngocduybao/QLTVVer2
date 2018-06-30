using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class LoaiSachDAO
    {
        #region Instance
        private static LoaiSachDAO instance;

        internal static LoaiSachDAO Instance
        {
            get
            {
                if (instance == null) instance = new LoaiSachDAO(); return DAO.LoaiSachDAO.instance;
            }

            private set
            {
                DAO.LoaiSachDAO.instance = value;
            }
        }
        #endregion
        #region Operator+
        public int IDPlus()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var query = ((from a in db.LOAISACHes select a.IDLoaiSach).Max()).ToString();
                int ID = Int32.Parse(query);
                int IDadd = ++ID;
                return IDadd;
            }
        }
        #endregion
    }
}
