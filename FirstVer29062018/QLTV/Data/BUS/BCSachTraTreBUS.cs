using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IBUS;
using Data.Model;
using Data.Dtos;
using Data.DAO; 
namespace Data.BUS
{
    public class BCSachTraTreBUS:IBCSachTraTreBUS
    {
        #region load Form BaoCaoSachTraTre
        public List<BCSachTraTreDtos> LoadForm()
        {
            using (var db= new QuanLyThuVienEntities())
            { 
                var BaoCao = (from a in db.CT_PHIEUMUON
                              from b in db.PHIEUMUONs
                              from d in db.PHIEUTRAs
                              from c in db.CT_PHIEUTRA
                              where a.IDPhieuMuon.Equals(b.IDPhieuMuon) && b.IDPhieuMuon.Equals(c.IDPhieuMuon) && d.IDPhieuTra.Equals(c.IDPhieuTra)
                              && (d.NgayTra>b.HanTra)
                              select new BCSachTraTreDtos()
                              { 
                                  IDPhieuMuon = a.IDPhieuMuon,
                                  NgayThangNam = d.NgayTra,
                                  IDCuonSach = a.IDCuonSach,
                                  SoNgayTraTre = (d.NgayTra - b.HanTra).Days,           
                              }
                            ).ToList<BCSachTraTreDtos>();
                var listBaoCao = (from a in BaoCao
                                  select new BCSachTraTreDtos()
                                  {
                                      IDBCSachTre = BCSachTraTreDAO.Instance.IDPlus(),
                                      IDCuonSach = a.IDCuonSach,
                                      NgayThangNam = a.NgayThangNam,
                                      IDPhieuMuon = a.IDPhieuMuon,
                                      SoNgayTraTre = a.SoNgayTraTre,
                                      TenCuonSach = GetDataDAO.Instance.getTenCuonSach(a.IDCuonSach),
                                  }).ToList<BCSachTraTreDtos>();
                if (listBaoCao.Count > 0)
                    return listBaoCao;
                return new List<BCSachTraTreDtos>();
            }
        }
        #endregion
       
    }
}
