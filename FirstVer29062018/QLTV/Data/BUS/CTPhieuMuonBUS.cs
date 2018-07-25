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
    public class CTPhieuMuonBUS : ICTPhieuMuonBUS
    {
        #region add form CT_PhieuMuon
        public bool addFormCTPhieuMuon(CTPhieuMuonDTO ctPhieuMuon)
        {
            try
            {
                using (var db = new QuanLyThuVienEntities())
                {
                    int ID = CTPhieuMuonDAO.Instance.IDPlus();
                    var checkIDPhieuMuon = (from a in db.PHIEUMUONs
                                            where a.IDPhieuMuon.Equals(ctPhieuMuon.IDPhieuMuon)
                                            select a).FirstOrDefault();
                    if (checkIDPhieuMuon == null) return false;
                    db.CT_PHIEUMUON.Add(new CT_PHIEUMUON()
                    {
                        IDCTPhieuMuon = ID,
                        IDCuonSach = GetDataDAO.Instance.getIDCuonSach(ctPhieuMuon.TenDauSach),
                        IDPhieuMuon = ctPhieuMuon.IDPhieuMuon,
                    });
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
        #endregion
    }

}
