using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IBUS;
using Data.Model;
using Data.DAO;
using Data.BUS;
using Data.Dtos;
using Data.DTO;
namespace Data.BUS
{
    public  class SachBUS :ISachBUS
    {
        #region Add Form DauSach , Sach ,CT _PhieuNhap
        public bool ADDFormSach(SachDTO sach)
        {
            try
            {
                using (var db = new QuanLyThuVienEntities())
                {
                    var checkTenDauSach = (from a in db.DAUSACHes
                                           where a.TenDauSach.ToUpper().Equals(sach.TenDauSach)
                                           select a).FirstOrDefault();
                    int ID = DauSachDAO.Instance.IDPlus();
                    var checkID = (from a in db.LOAISACHes
                                   where a.IDLoaiSach.Equals(sach.IDLoaiSach)
                                   select a).FirstOrDefault();
                    if (checkID == null) return false;
                    if (checkTenDauSach == null)
                    {
                        db.DAUSACHes.Add(new DAUSACH()
                        {
                            IDDauSach = ID,
                            IDLoaiSach = GetDataDAO.Instance.getIDLoaiSachToTenLoaiSach(sach.TenLoaiSach),
                            TenDauSach = sach.TenDauSach,
                        });
                    }
                    int IDsach = SachDAO.Instance.IDPlus();
                    if (sach.IDDauSach.Equals(ID))
                    {
                       
                        var checkIDTacGia = (from a in db.CT_TACGIA
                                             where a.IDCTTacGia.Equals(sach.IDCTTacGia)
                                             select a).FirstOrDefault();
                        if (checkID == null) return false;
                        db.SACHes.Add(new SACH()
                        {
                            IDSach = IDsach,
                            IDDauSach = ID,
                            IDCTTacGia = GetDataDAO.Instance.getIDCTTacGiaToTenTacGia(sach.TenTacGia),
                            GiaTien = sach.GiaTien,
                            NamXB = sach.NamXB,
                            SoLuongTon = sach.SoLuongTon,
                            NhaXB = sach.NhaXB,

                        });
                        if (sach.IDSach.Equals(IDsach))
                        {
                            int IDCT = CTPhieuNhapSachDAO.Instance.IDPlus();
                            var checkIDPhieuNhapSach = (from a in db.PHIEUNHAPSACHes
                                                        where a.IDPhieuNhap.Equals(sach.IDPhieuNhap)
                                                        select a).FirstOrDefault();
                            if (checkIDPhieuNhapSach == null) return false;
                            db.CT_PHIEUNHAPSACH.Add(new CT_PHIEUNHAPSACH()
                            {
                                IDCTPhieuNhap = IDCT,
                                IDSach = IDsach,
                                IDPhieuNhap = GetDataDAO.Instance.getIDPhieuNhapToNgayNhapSach(sach.NgayNhap),
                                SoLuong = sach.SoLuong,
                                DonGia = sach.DonGia,
                                ThanhTien = sach.DonGia * sach.SoLuong,
                            });
                            var update = (
                                          from b in db.PHIEUNHAPSACHes
                                          where b.IDPhieuNhap.Equals(sach.IDPhieuNhap)
                                          select b).FirstOrDefault<PHIEUNHAPSACH>();
                            update.TongTien = update.TongTien + (sach.DonGia * sach.SoLuong);
                        }
                    }
                    var updateSoLuong = (from a in db.SACHes
                                         where a.IDSach.Equals(IDsach)
                                         select a).FirstOrDefault<SACH>();
                    updateSoLuong.SoLuongTon = updateSoLuong.SoLuongTon + sach.SoLuong;
                    CuonSachDAO.Instance.addFormCuonSach(sach.SoLuong, IDsach);
                    db.SaveChanges();
                    return true;
                }  
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
        #region EditForm DauSach,Sach,CT_PhieuNhap
        public bool editFormDauSachAndSachAndCTPhieuNhap(SachDTO sach)
        {
            try
            {
                using(var db = new QuanLyThuVienEntities())
                {
                    var EditDAUSACH = (from a in db.DAUSACHes
                                where a.IDDauSach.Equals(sach.IDDauSach)
                                select a).FirstOrDefault();
                    if (EditDAUSACH == null) return false;
                    EditDAUSACH.IDLoaiSach = GetDataDAO.Instance.getIDLoaiSachToTenLoaiSach(sach.TenLoaiSach);
                    EditDAUSACH.TenDauSach = sach.TenDauSach;
                    var EditSach = (from a in db.SACHes
                                    where a.IDSach.Equals(sach.IDSach)
                                    select a).FirstOrDefault();
                    if (EditSach == null) return false;
                    EditSach.IDDauSach = sach.IDDauSach;
                    EditSach.IDCTTacGia = GetDataDAO.Instance.getIDCTTacGiaToTenTacGia(sach.TenTacGia);
                    EditSach.NamXB = sach.NamXB;
                    EditSach.NhaXB = sach.NhaXB;
                    EditSach.SoLuongTon = sach.SoLuongTon + sach.SoLuong;
                    EditSach.GiaTien = sach.GiaTien;
                    var EditCTPhieuNhap = (from a in db.CT_PHIEUNHAPSACH
                                           where a.IDCTPhieuNhap.Equals(sach.IDCTPhieuNhap)
                                           select a).FirstOrDefault();
                    EditCTPhieuNhap.IDPhieuNhap = GetDataDAO.Instance.getIDPhieuNhapToNgayNhapSach(sach.NgayNhap);
                    EditCTPhieuNhap.IDSach = sach.IDSach;
                    EditCTPhieuNhap.SoLuong = sach.SoLuong;
                    EditCTPhieuNhap.DonGia = sach.DonGia;
                    EditCTPhieuNhap.ThanhTien = sach.SoLuong * sach.DonGia;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
        #endregion
        #region getListSearch SachDTO
        //get List Search NamXuatban
        public List<SachDTO> getFormSachNamXuatBan(string NamXB)
        {
            try
            {
                List<SachDTO> listSach = new List<SachDTO>();
                listSach = SachDAO.Instance.getFormSachNamXuatBan(NamXB);
                return listSach;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //get List Search NhaXuatBan
        public List<SachDTO> getFormSachNhaXuatBan(string NhaxB)
        {
            try
            {
                List<SachDTO> listSach = new List<SachDTO>();
                listSach = SachDAO.Instance.getFormSachNhaXuatBan(NhaxB);
                return listSach;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //get List Search GiaTien
        public List<SachDTO> getFormSachSearchGiaTien(decimal tien)
        {
            try
            {
                List<SachDTO> listSach = new List<SachDTO>();
                listSach = SachDAO.Instance.getFormSachSearchGiaTien(tien);
                return listSach;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //get List Search IDSach
        public List<SachDTO> getFormSachSearchIDSach(int IDsach)
        {
            try
            {
                List<SachDTO> listSach = new List<SachDTO>();
                listSach = SachDAO.Instance.getFormSachSearchIDSach(IDsach);
                return listSach;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //get List Search SoluongTon
        public List<SachDTO> getFormSachSearchSoLuongTon(int SL)
        {
            try
            {
                List<SachDTO> listSach = new List<SachDTO>();
                listSach = SachDAO.Instance.getFormSachSearchSoLuongTon(SL);
                return listSach;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //get List Search TenDauSach
        public List<SachDTO> getFormSachTenDauSach(string TenDauSach)
        {
            try
            {
                List<SachDTO> listSach = new List<SachDTO>();
                listSach = SachDAO.Instance.getFormSachTenDauSach(TenDauSach);
                return listSach;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
    