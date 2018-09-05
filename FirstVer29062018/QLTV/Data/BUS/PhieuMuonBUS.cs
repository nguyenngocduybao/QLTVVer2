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
        public bool AddFormPhieuMuonAndCTPhieuMuon(PhieuMuonDtos  phieuMuon,List<int> IDCuonSach)
        {
            try
            {
                
                using (var db = new QuanLyThuVienEntities())
                {
                    int ID = PhieuMuonDAO.Instance.IDPlus();
                    db.PHIEUMUONs.Add(new PHIEUMUON()
                    {
                        IDPhieuMuon = ID,
                        IDDocGia = GetDataDAO.Instance.getIDDocGiaToHoTenDG(phieuMuon.TenDocGia),
                        NgayMuon = phieuMuon.NgayMuon,
                        HanTra = PhieuMuonDAO.Instance.HanMuonSach(phieuMuon.NgayMuon),
                    });
                    db.SaveChanges();
                    for (int i = 0; i <IDCuonSach.Count(); i++)
                    {
                        
                        int IDCT = CTPhieuMuonDAO.Instance.IDPlus();
                        db.CT_PHIEUMUON.Add(new CT_PHIEUMUON()
                        {
                            IDCTPhieuMuon = IDCT,
                            IDCuonSach = IDCuonSach[i],
                            IDPhieuMuon = ID,
                        });
                        db.SaveChanges();
                        var updateTinhTrang = (from a in db.CUONSACHes
                                               where a.IDCuonSach.Equals(IDCuonSach[i])
                                               select a).FirstOrDefault<CUONSACH>();
                        updateTinhTrang.TinhTrang = "Đã cho mượn";
                        db.SaveChanges();
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
        #region editForm PhieuMuon And CTPhieuMuon
        public bool editFormPhieuMuonAndCTPhieuMuon(PhieuMuonDTO phieumuon)
        {
            try
            {
                using (var db= new QuanLyThuVienEntities())
                {
                    var Edit = (from a in db.PHIEUMUONs
                                where a.IDPhieuMuon.Equals(phieumuon.IDPhieuMuon)
                                select a).FirstOrDefault();
                    if (Edit == null) return false;
                    Edit.NgayMuon = phieumuon.NgayMuon;
                    Edit.IDDocGia = phieumuon.IDDocGia;
                    Edit.HanTra = PhieuMuonDAO.Instance.HanMuonSach(phieumuon.NgayMuon);
                    var EditCT = (from a in db.CT_PHIEUMUON
                                  where a.IDCTPhieuMuon.Equals(phieumuon.IDCTPhieuMuon)
                                  select a).FirstOrDefault();
                    if (EditCT == null) return false;
                    EditCT.IDCuonSach = GetDataDAO.Instance.getIDCuonSach(phieumuon.TenDauSach);
                    EditCT.IDPhieuMuon = phieumuon.IDPhieuMuon;
                    var updateTinhTrang = (from a in db.CUONSACHes
                                           where a.IDCuonSach.Equals(GetDataDAO.Instance.getIDCuonSach(phieumuon.TenDauSach))
                                           select a).FirstOrDefault<CUONSACH>();
                    updateTinhTrang.TinhTrang = "Đã cho mượn";
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
