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

        #region Check
        //Check LoaiDocGia  From LOAIDOCGIA to IDLoaiDG
        public string CheckLoaiDocGia(int ID)
        {
            return ID.Equals(1) ?  "Thường" :  "VIP";
        }

        // Check IDLoaiDG From LOAIDOCGIA to TenLoaiDG
        public int CheckIDLoaiDG(string TenLoaiDG)
        {
            return TenLoaiDG.Equals("Thường") ? 1 : 2;

        }
        #endregion
        #region GetDATA  List
        // HotenDG from THEDOCGIA to IDDocGia
        public string GetDataHoTenDGFromTHEDOCGIA(int ID)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.THEDOCGIAs where a.IDDocGia.Equals(ID) select a.HoTenDG).ToString();
                return result;
            }
        }
 
        //Get IDDocGia from THEDOCGIA to HoTenDG
        public int GetIDDGFromTHEDOCGIA(string HoTenDG)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                int result = (from a in db.THEDOCGIAs where a.HoTenDG.ToUpper().Equals(HoTenDG.ToUpper())
                              select a.IDDocGia).DefaultIfEmpty(-1).FirstOrDefault();
                return result;
            }
        }
        #endregion
       
    }
}
