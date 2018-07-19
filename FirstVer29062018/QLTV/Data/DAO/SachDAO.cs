using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
using Data.DTO;
namespace Data.DAO
{
    public class SachDAO
    {
        #region Instance
        private static SachDAO instance;

        internal static SachDAO Instance
        {
            get
            {
                if (instance == null) instance = new SachDAO(); return DAO.SachDAO.instance;
            }

            private set
            {
                DAO.SachDAO.instance = value;
            }
        }
        #endregion
        #region Operator+
        public int IDPlus()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var query = ((from a in db.SACHes select a.IDSach).Max()).ToString();
                int ID = Int32.Parse(query);
                int IDadd = ++ID;
                return IDadd;
            }          
        }
        #endregion
        #region getListSearch SachDTO
        public List<SachDTO> getFormSachSearchIDSach(int IDsach)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.SACHes
                              where a.IDSach.Equals(IDsach)
                              select new SachDTO()
                              {
                                  IDSach=a.IDSach,
                                  TenDauSach=GetDataDAO.Instance.getTenDausachToIDDauSach(a.IDDauSach),
                                  TenTG=GetDataDAO.Instance.getTenTacGiaToIDCTTacGia(a.IDCTTacGia),
                                  NamXB=a.NamXB,
                                  NhaXB=a.NhaXB,
                                  GiaTien=a.GiaTien,
                                  SoLuongTon=a.SoLuongTon,                  

                              }).ToList<SachDTO>();
                if (result.Count > 0)
                    return result;
                return new List<SachDTO>();
            }
        }
        #endregion
    }
}
