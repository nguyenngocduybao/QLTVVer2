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

        public static GetDataDAO Instance
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
        // get IDCuonSach to TenDauSach
        public int getIDCuonSach(string tb_TenSach)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.DAUSACHes
                              from b in db.SACHes
                              from c in db.CUONSACHes
                              where a.TenDauSach.Equals(tb_TenSach) && b.IDDauSach.Equals(a.IDDauSach) && b.IDSach.Equals(c.IDSach) && c.TinhTrang.Equals("Chưa cho mượn")
                              select c.IDCuonSach).FirstOrDefault();
                return result;

            }
        }
        //get TenCuonSach to IDCuonSach
        public string getTenCuonSach(int IDCuonSach)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var TenCuonSach = (from a in db.CUONSACHes
                                   from b in db.DAUSACHes
                                   from c in db.SACHes
                                   where a.IDCuonSach.Equals(IDCuonSach) && a.IDSach.Equals(c.IDSach) && b.IDDauSach.Equals(c.IDDauSach)
                                   select b.TenDauSach).ToString();
                return TenCuonSach;
            }
        }
        //get IDLoaiSach to TenLoaiSach
        public int getIDLoaiSachToTenLoaiSach(string TenLoaiSach)
        {
            using (var db= new QuanLyThuVienEntities())
            {
                var IDLoaiSach = (from a in db.LOAISACHes
                                  where a.TenLoaiSach.Equals(TenLoaiSach)
                                  select a.IDLoaiSach).ToString();
                int ID = Int32.Parse(IDLoaiSach);
                return ID;
            }
        }
        // getIDCTTacGia to TenTacGia
        public int getIDCTTacGiaToTenTacGia(string tentacgia)
        {
            using (var db=new QuanLyThuVienEntities())
            {
                var IDCTTacGia = (from a in db.TACGIAs
                                  join b in db.CT_TACGIA on a.IDTacGia equals b.IDTacGia
                                  where a.TenTacGia.Equals(tentacgia)
                                  select b.IDCTTacGia).ToString();
                int ID = Int32.Parse(IDCTTacGia);
                return ID;
            }
        }
       
        #endregion


    }

}
