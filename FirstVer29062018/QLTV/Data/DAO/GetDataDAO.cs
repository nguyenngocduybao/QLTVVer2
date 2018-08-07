﻿using System;
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
       // getIDPhieuNhap to NgayNhapSach
       public int getIDPhieuNhapToNgayNhapSach(DateTime NgayNhap)
        {
            using (var db= new QuanLyThuVienEntities())
            {
                var IDPhieuNhap = (from a in db.PHIEUNHAPSACHes
                                   where a.NgayNhap.Equals(NgayNhap)
                                   select a.IDPhieuNhap);
                if (IDPhieuNhap.Count() != 0)
                    return PhieuNhapSachDAO.Instance.IDPlus();
                else
                    return IDPhieuNhap.FirstOrDefault();
            }
        }

        #endregion
        #region Get list and Array 
        //getList TenTheLoai Sach
        public List<string> getListTenTheLoaiSach()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var listTenTheLoai = (from a in db.LOAISACHes
                                      select a.TenLoaiSach.ToString()).ToList();
                return listTenTheLoai;
            }
        }
        //get Array TenTacGia 
        public string[] getArrayTenTacGia()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var ArrTenTacGia = (from a in db.TACGIAs
                                    select a.TenTacGia).ToArray();
                return ArrTenTacGia;
            }
        }
        // get List TenTacGia
        public List<string> getListTenTacGia()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var listTenTacGia = (from a in db.TACGIAs
                                     select a.TenTacGia.ToString()).ToList();
                return listTenTacGia;
            }
        }
        //get list IDCuonSach To IDPhieuMuon
        public List<int> ListIDCuonSach(int tb_IDPhieuMuon)
        {

            using (var db = new QuanLyThuVienEntities())
            {
                var list = (from a in db.PHIEUMUONs
                            join b in db.CT_PHIEUMUON on a.IDPhieuMuon equals b.IDPhieuMuon
                            join c in db.CUONSACHes on b.IDCuonSach equals c.IDCuonSach
                            where a.IDPhieuMuon.Equals(tb_IDPhieuMuon) && c.TinhTrang == "Đã cho mượn"
                            select b.IDCuonSach).ToList<int>();
                return list;
            }
        }
        // get List auto complete TenTheLoai Sach
        public List<string> getListAutoTenTheLoai(string tb_TenTheLoai)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var ListTheLoai = (from a in db.LOAISACHes
                                   where a.TenLoaiSach.ToUpper().Contains(tb_TenTheLoai.ToUpper())
                                   select a.TenLoaiSach.ToString()).ToList();
                return ListTheLoai;
            }
        }
        //get List auto complete TenTacGia
        public List<string> getListAutoTenTacGia(String tb_TenTacGia)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var ListTenTacGia = (from a in db.TACGIAs
                                     where a.TenTacGia.ToUpper().Contains(tb_TenTacGia.ToUpper())
                                     select a.TenTacGia.ToString()).ToList();
                return ListTenTacGia;
            }
        }
        //getList auto complete HoTenDG
        public List<string> getListAutoHoTenDG(String tb_HoTenDG)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var ListHoTenDG = (from a in db.THEDOCGIAs
                                   where a.HoTenDG.ToUpper().Contains(tb_HoTenDG.ToUpper())
                                   select a.HoTenDG.ToString()).ToList();
                return ListHoTenDG;
            }
        }
        //get List IDDocGia To HoTenDG 
        public List<int> getListIDDG(string HoTenDG)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var ListIDDG = (from a in db.THEDOCGIAs
                                where a.HoTenDG.Equals(HoTenDG)
                                select a.IDDocGia).ToList();
                return ListIDDG;
            }
        }
        // get Array Auto TenTacGia
        public string[] getArrAutoTenTacGia(string tb_TenTacGia)
        {
            using (var db= new QuanLyThuVienEntities())
            {
                var ArrTenTacGia = (from a in db.TACGIAs
                                    where a.TenTacGia.ToUpper().Contains(tb_TenTacGia.ToUpper())
                                    select a.TenTacGia.ToString()).ToArray();
                return ArrTenTacGia;
            }
        }
        //get Array auto TenTheLoai Sach
        public string[] getArrAutoTenTheLoai(string tb_TenTheLoai)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var ArrTenTheLoai = (from a in db.LOAISACHes
                                     where a.TenLoaiSach.ToUpper().Contains(tb_TenTheLoai.ToUpper())
                                     select a.TenLoaiSach.ToString()).ToArray();
                return ArrTenTheLoai;
            }
        }
        #endregion

    }

}
