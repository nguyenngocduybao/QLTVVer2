using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IBUS;
using Data.DTO;
using Data.BUS;
using Data.Dtos;
using Data.Model;
using Data.DAO;
namespace Data.BUS
{
    public class PhieuTraBUS:IPhieuTraBUS
    {
        #region Add Form "PhieuTra"
        public bool AddFormPhieuTra(PhieuTraDtos phieutra,List<int> IDCuonSach)
        {
            try
            {
                using (var db = new QuanLyThuVienEntities())
                {
                    int ID = PhieuTraDAO.Instance.IDPlus();
                    db.PHIEUTRAs.Add(new PHIEUTRA()
                    {
                        IDPhieuTra = ID,
                        IDDocGia = GetDataDAO.Instance.getIDDocGiaToHoTenDG(phieutra.TenDG),
                        NgayTra = phieutra.NgayTra,
                        SoTienTra = 0,
                        TienNoKyNay = 0,
                        TienPhatKyNay = 0,
                    });
                    db.SaveChanges();
                    for (int i = 0; i <IDCuonSach.Count(); i++)
                    {
                        int IDCT = CTPhieuTraDAO.Instance.IDPlus();
                        db.CT_PHIEUTRA.Add(new CT_PHIEUTRA()
                        {
                            IDCTPhieuTra=IDCT,
                            IDPhieuTra=ID,
                            IDPhieuMuon=GetDataDAO.Instance.getIDPhieuMuonToIDCuonSach(IDCuonSach[i]),
                            IDCuonSach=IDCuonSach[i],     
                            SoNgayMuon=PhieuTraDAO.Instance.SoNgayMuon(phieutra.NgayTra,IDCT),
                            TienPhat=PhieuTraDAO.Instance.TinhTienPhat(phieutra.NgayTra,IDCT),
                        });
                        db.SaveChanges();
                        var updateTinhTrang = (from a in db.CUONSACHes
                                               where a.IDCuonSach.Equals(IDCuonSach[i])
                                               select a).FirstOrDefault<CUONSACH>();
                        updateTinhTrang.TinhTrang = "Chưa cho mượn";
                        db.SaveChanges();
                        if (HelperDAO.Instance.CheckTraTre(IDCT) == true)
                        {
                            int IDBC = BCSachTraTreDAO.Instance.IDPlus();
                            db.BCSACHTRATREs.Add(new BCSACHTRATRE()
                            {
                                IDBCSachTre = IDCT,
                                IDCuonSach = IDCuonSach[i],
                                IDPhieuMuon = phieutra.IDPhieuMuon,
                                NgayThangNam = phieutra.NgayTra,
                                SoNgayTraTre = (GetDataDAO.Instance.HanTraSachToIDCTPhieuTra(IDCT) - phieutra.NgayTra).Days,
                            });
                            db.SaveChanges();
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
        #region  get all from phieutra and CTPhieuTra
        public List<CTPhieuTraDTO> getALlFormPhieuTraAndCTPhieuTra()
        {
            try
            {
                List<CTPhieuTraDTO> phieutra = new List<CTPhieuTraDTO>();
                phieutra = PhieuTraDAO.Instance.getALlFormPhieuTraAndCTPhieuTra();
                return phieutra;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion


    }
}
