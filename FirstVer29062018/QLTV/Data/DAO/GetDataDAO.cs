using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class GetDataDAO
    {
        #region Instance
        private static GetDataDAO instance;

        internal static GetDataDAO Instance
        {
            get
            {
                if (instance == null) instance = new GetDataDAO(); return DAO.GetDataDAO.instance;
            }

            private set
            {
                DAO.GetDataDAO.instance = value;
            }
        }
        #endregion
        #region get Name to ID
        // get TenDocGia to IDDocGia
        public string getTenDocGiaToIDDocGia(int ID)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var TenDocGia = (from a in db.THEDOCGIAs
                                 where a.IDDocGia.Equals(ID)
                                 select a.HoTenDG).ToString();
                return TenDocGia;
            }
        }
        //get TenTacGia to IDCTTacGia
        public string getTenTacGiaToIDCTTacGia(int ID)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var TenTacGia = (from a in db.TACGIAs
                                 from b in db.CT_TACGIA
                                 where b.IDTacGia.Equals(a.IDTacGia) && a.IDTacGia.Equals(ID)
                                 select a.TenTacGia).ToString();                                                
                return TenTacGia;
            }
        }
       //get TenDauSach to IDDauSach
        public string getTenDausachToIDDauSach(int ID)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var TenDauSach = (from a in db.DAUSACHes
                                  where a.IDDauSach.Equals(ID)
                                  select a.TenDauSach).ToString();
                return TenDauSach;
            }
        }
        // get TenLoaiSach to IDLoaiSach
        public string getTenLoaiSachToIDLoaiSach(int ID)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var TenLoaiSach = (from a in db.LOAISACHes
                                   where a.IDLoaiSach.Equals(ID)
                                   select a.TenLoaiSach).ToString();
                return TenLoaiSach;
            }
        }
        #endregion


    }

}
