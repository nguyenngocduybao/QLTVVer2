using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class TheDocGiaDAO
    {
        #region Instance
        private static TheDocGiaDAO instance;

        internal static TheDocGiaDAO Instance
        {
            get
            {
                if (instance == null) instance = new TheDocGiaDAO(); return DAO.TheDocGiaDAO.instance;
            }

            private set
            {
                DAO.TheDocGiaDAO.instance = value;
            }
        }
        #endregion
        #region opretor+
        public int IDPlus()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var query = ((from b in db.THEDOCGIAs select b.IDDocGia).Max()).ToString();
                int ID = Int32.Parse(query);
                int idplus = ++ID;
                return idplus;
            }
        }
        #endregion
        #region List TheDocGia to IDDocGia
        public List<TheDocGiaDtos> GetFormTheDocGia(int ID)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var Result = (from m in db.THEDOCGIAs
                              where m.IDDocGia.Equals(ID)
                              select new TheDocGiaDtos()
                              {
                                  IDDocGia = m.IDDocGia,
                                  HoTenDG = m.HoTenDG,
                                  DiaChiDG = m.DiaChiDG,
                                  EmailDG = m.EmailDG,
                                  NgayLapThe=m.NgayLapThe,
                                  NgaySinhDG=m.NgaySinhDG
                              }).ToList<TheDocGiaDtos>();
                return Result;                   
            }
        }
        #endregion
        #region List TheDocGiaDtos to HoTenDG
        public List<TheDocGiaDtos> GetFormTheDocGiaToHoTenDG(string HoTenDG)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from m in db.THEDOCGIAs
                              where m.HoTenDG.ToUpper().Equals(HoTenDG.ToUpper())
                              select new TheDocGiaDtos()
                              {
                                  IDDocGia = m.IDDocGia,
                                  HoTenDG = m.HoTenDG,
                                  DiaChiDG = m.DiaChiDG,
                                  EmailDG = m.EmailDG,
                                  NgayLapThe = m.NgayLapThe,
                                  NgaySinhDG = m.NgaySinhDG
                              }).ToList<TheDocGiaDtos>();
                return result;
            }
        }
        #endregion
        #region Search
        //search IDDocGia Form "THEDOCGIA"
        #endregion
    }
}
