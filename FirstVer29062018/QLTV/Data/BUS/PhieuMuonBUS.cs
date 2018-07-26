using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IBUS;
using Data.Model;
using Data.DAO;
using Data.DTO;
using Data.Dtos;
namespace Data.BUS
{
    public class PhieuMuonBUS:IPhieuMuonBUS
    {
        #region Add Form PhieuMuon and CTPhieuMuon 
        public bool AddFormPhieuMuonAndCTPhieuMuon(PhieuMuonDtos  phieuMuon,List<string> TenDauSach)
        {
            try
            {
                
                using (var db = new QuanLyThuVienEntities())
                {
                    int ID = PhieuMuonDAO.Instance.IDPlus();
                    var checkIDDocGia = (from a in db.THEDOCGIAs
                                         where a.IDDocGia.Equals(phieuMuon.IDDocGia)
                                         select a).FirstOrDefault();
                    if (checkIDDocGia == null) return false;
                    db.PHIEUMUONs.Add(new PHIEUMUON()
                    {
                        IDPhieuMuon = ID,
                        IDDocGia = phieuMuon.IDDocGia,
                        NgayMuon = phieuMuon.NgayMuon,
                        HanTra = PhieuMuonDAO.Instance.HanMuonSach(phieuMuon.NgayMuon),
                    });
                    for (int i = 0; i < TenDauSach.Count; i++)
                    {
                        
                        int IDCT = CTPhieuMuonDAO.Instance.IDPlus();
                        db.CT_PHIEUMUON.Add(new CT_PHIEUMUON()
                        {
                            IDCTPhieuMuon = IDCT,
                            IDCuonSach = GetDataDAO.Instance.getIDCuonSach(TenDauSach[i]),
                            IDPhieuMuon = ID,
                        });
                        db.SaveChanges();
                    }
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
       
        #endregion
        #region getList Search PhieuMuonDTO
        //get List IDDocGia
        public List<PhieuMuonDTO> getFormPhieuMuonSearchIDDocGia(int ID)
        {
            try
            {
                List<PhieuMuonDTO> ListPhieuMuon = new List<PhieuMuonDTO>();
                ListPhieuMuon = PhieuMuonDAO.Instance.getFormPhieuMuonSearchIDDocGia(ID);
                return ListPhieuMuon;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //get List search IDPhieuMuon
        public List<PhieuMuonDTO> getFormPhieuMuonSearchIDPhieuMuon(int ID)
        {
            try
            {
                List<PhieuMuonDTO> ListPhieuMuon = new List<PhieuMuonDTO>();
                ListPhieuMuon = PhieuMuonDAO.Instance.getFormPhieuMuonSearchIDPhieuMuon(ID);
                return ListPhieuMuon;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //get List search ngaymuon
        public List<PhieuMuonDTO> getFormPhieuMuonSearchNgayMuon(DateTime ngaymuon)
        {
            try
            {
                List<PhieuMuonDTO> ListPhieuMuon = new List<PhieuMuonDTO>();
                ListPhieuMuon = PhieuMuonDAO.Instance.getFormPhieuMuonSearchNgayMuon(ngaymuon);
                return ListPhieuMuon;
            }
            catch (Exception)
            {

                throw;
            }
        }
        // get list search Han Tra
        public List<PhieuMuonDTO> getFormPhieuMuonSearchHanTra(DateTime hantra)
        {
            try
            {
                List<PhieuMuonDTO> ListPhieuMuon = new List<PhieuMuonDTO>();
                ListPhieuMuon = PhieuMuonDAO.Instance.getFormPhieuMuonSearchHanTra(hantra);
                return ListPhieuMuon;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
        #region getAll FormPhieuMuonAndCTPhieuMuon
        public List<PhieuMuonDTO> getAllFormPhieuMuonAndCTPhieuMuon()
        {
            try
            {
                List<PhieuMuonDTO> ListPhieuMuon = new List<PhieuMuonDTO>();
                ListPhieuMuon = PhieuMuonDAO.Instance.getAllFormPhieuMuonAndCTPhieuMuon();
                return ListPhieuMuon;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

    }
}
