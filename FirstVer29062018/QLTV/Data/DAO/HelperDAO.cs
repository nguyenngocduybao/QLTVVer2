using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;

namespace Data.DAO
{
    class HelperDAO
    {
        #region Instance
        private static HelperDAO instance;

        internal static HelperDAO Instance
        {
            get
            {
                if (instance == null) instance = new HelperDAO(); return DAO.HelperDAO.instance;
            }

            private set
            {
                DAO.HelperDAO.instance = value;
            }
        }
        #endregion
        #region Check LoaiDocGia
        //Check LoaiDocGia  From LOAIDOCGIA to IDLoaiDG
        public string checkLoaiDocGiaFromID(int ID)
        {
            return ID.Equals(1) ?  "Thường" :  "VIP";
        }

        // Check IDLoaiDG From LOAIDOCGIA to TenLoaiDG
        public int checkIDLoaiDGFromTenLoaiDocGia(string TenLoaiDG)
        {
            return TenLoaiDG.Equals("Thường") ? 1 : 2;

        }
        #endregion
     
       
    }
}
