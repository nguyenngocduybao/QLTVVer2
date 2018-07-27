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

        public static SachDAO Instance
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
        //get List Search IDSach 
        public List<SachDTO> getFormSachSearchIDSach(int IDsach)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.SACHes
                              where a.IDSach.Equals(IDsach)
                              select new SachDTO()
                              {
                                  IDSach = a.IDSach,
                                  IDDauSach = a.IDDauSach,
                                  IDCTTacGia=a.IDCTTacGia,
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
        //get List Search TenDauSach
        public List<SachDTO> getFormSachTenDauSach(string TenDauSach)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.DAUSACHes
                              from b in db.SACHes
                              where a.IDDauSach.Equals(b.IDDauSach) && a.TenDauSach.ToUpper().Contains(TenDauSach.ToUpper())
                              select new SachDTO()
                              {
                                  IDDauSach = a.IDDauSach,
                                  IDSach = b.IDSach,
                                  IDCTTacGia = b.IDCTTacGia,
                                  TenDauSach = GetDataDAO.Instance.getTenDausachToIDDauSach(a.IDDauSach),
                                  TenTG = GetDataDAO.Instance.getTenTacGiaToIDCTTacGia(b.IDCTTacGia),
                                  NamXB = b.NamXB,
                                  NhaXB = b.NhaXB,
                                  GiaTien = b.GiaTien,
                                  SoLuongTon = b.SoLuongTon,
                              }).ToList<SachDTO>();
                if (result.Count > 0)
                    return result;
                return new List<SachDTO>();

            }
        }
        // get List Search NhaXuatBan
        public List<SachDTO> getFormSachNhaXuatBan(string NhaxB)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.SACHes
                              where a.NhaXB.ToUpper().Contains(NhaxB.ToUpper())
                              select new SachDTO()
                              {
                                  IDSach = a.IDSach,
                                  IDDauSach = a.IDDauSach,
                                  IDCTTacGia = a.IDCTTacGia,
                                  TenDauSach = GetDataDAO.Instance.getTenDausachToIDDauSach(a.IDDauSach),
                                  TenTG = GetDataDAO.Instance.getTenTacGiaToIDCTTacGia(a.IDCTTacGia),
                                  NamXB = a.NamXB,
                                  NhaXB = a.NhaXB,
                                  GiaTien = a.GiaTien,
                                  SoLuongTon = a.SoLuongTon,
                              }).ToList<SachDTO>();
                if (result.Count > 0)
                    return result;
                return new List<SachDTO>();
            }
        }
        // get List Search NamXuatBan 
        public List<SachDTO> getFormSachNamXuatBan(string NamXB)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.SACHes
                              where a.NamXB.Equals(NamXB)
                              select new SachDTO()
                              {
                                  IDSach = a.IDSach,
                                  IDDauSach = a.IDDauSach,
                                  IDCTTacGia = a.IDCTTacGia,
                                  TenDauSach = GetDataDAO.Instance.getTenDausachToIDDauSach(a.IDDauSach),
                                  TenTG = GetDataDAO.Instance.getTenTacGiaToIDCTTacGia(a.IDCTTacGia),
                                  NamXB = a.NamXB,
                                  NhaXB = a.NhaXB,
                                  GiaTien = a.GiaTien,
                                  SoLuongTon = a.SoLuongTon,
                              }).ToList<SachDTO>();
                if (result.Count > 0)
                    return result;
                return new List<SachDTO>();
            }
        }
        // get List Search GiaTien
        public List<SachDTO> getFormSachSearchGiaTien(decimal tien)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.SACHes
                              where a.GiaTien.Equals(tien)
                              select new SachDTO()
                              {
                                  IDSach = a.IDSach,
                                  IDDauSach = a.IDDauSach,
                                  IDCTTacGia = a.IDCTTacGia,
                                  TenDauSach = GetDataDAO.Instance.getTenDausachToIDDauSach(a.IDDauSach),
                                  TenTG = GetDataDAO.Instance.getTenTacGiaToIDCTTacGia(a.IDCTTacGia),
                                  NamXB = a.NamXB,
                                  NhaXB = a.NhaXB,
                                  GiaTien = a.GiaTien,
                                  SoLuongTon = a.SoLuongTon,
                              }).ToList<SachDTO>();
                if (result.Count > 0)
                    return result;
                return new List<SachDTO>();
            }
        }
        //get List Search SoLuongTon
        public List<SachDTO> getFormSachSearchSoLuongTon(int SL)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.SACHes
                              where a.SoLuongTon.Equals(SL)
                              select new SachDTO()
                              {
                                  IDSach = a.IDSach,
                                  IDDauSach = a.IDDauSach,
                                  IDCTTacGia = a.IDCTTacGia,
                                  TenDauSach = GetDataDAO.Instance.getTenDausachToIDDauSach(a.IDDauSach),
                                  TenTG = GetDataDAO.Instance.getTenTacGiaToIDCTTacGia(a.IDCTTacGia),
                                  NamXB = a.NamXB,
                                  NhaXB = a.NhaXB,
                                  GiaTien = a.GiaTien,
                                  SoLuongTon = a.SoLuongTon,
                              }).ToList<SachDTO>();
                if (result.Count > 0)
                    return result;
                return new List<SachDTO>();
            }
        }
        #endregion
    }
}
