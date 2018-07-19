using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IBUS;
using Data.Model;
using Data.DAO;
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
                    int ID = DauSachDAO.Instance.IDPlus();
                    var checkID = (from a in db.LOAISACHes
                                   where a.IDLoaiSach.Equals(sach.IDLoaiSach)
                                   select a).FirstOrDefault();
                    if (checkID == null) return false;
                    db.DAUSACHes.Add(new DAUSACH()
                    {
                        IDDauSach = ID,
                        IDLoaiSach = sach.IDLoaiSach,
                        TenDauSach = sach.TenDauSach,
                    });
                    if (sach.IDDauSach.Equals(ID))
                    {
                        int IDsach = SachDAO.Instance.IDPlus();
                        var checkIDTacGia = (from a in db.CT_TACGIA
                                             where a.IDCTTacGia.Equals(sach.IDCTTacGia)
                                             select a).FirstOrDefault();
                        if (checkID == null) return false;
                        db.SACHes.Add(new SACH()
                        {
                            IDSach = IDsach,
                            IDDauSach = ID,
                            IDCTTacGia = sach.IDCTTacGia,
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
                                IDPhieuNhap = sach.IDPhieuNhap,
                                SoLuong = sach.SoLuong,
                                DonGia = sach.DonGia,
                                ThanhTien = sach.DonGia * sach.SoLuong,
                            });
                            var update = (from a in db.CT_PHIEUNHAPSACH
                                          from b in db.PHIEUNHAPSACHes
                                          where a.IDPhieuNhap.Equals(b.IDPhieuNhap)
                                          select b.TongTien).Sum();
                            db.PHIEUNHAPSACHes.Add(new PHIEUNHAPSACH()
                            {
                                TongTien = update,
                            });
                            int SoLuong = (from a in db.CT_PHIEUNHAPSACH
                                           from b in db.SACHes
                                           where a.IDSach.Equals(b.IDSach)
                                           select a.SoLuong).SingleOrDefault();
                            db.SACHes.Add(new SACH()
                            {
                                SoLuongTon = sach.SoLuongTon + SoLuong,
                            });
                            for (int i = 0; i < sach.SoLuong; i++)
                            {
                                int IDCuonSach = CuonSachDAO.Instance.IDPlus();
                                db.CUONSACHes.Add(new CUONSACH()
                                {
                                    IDCuonSach = ID,
                                    TinhTrang = "Chưa cho mượn",
                                });
                            }
                        }
                    }
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
