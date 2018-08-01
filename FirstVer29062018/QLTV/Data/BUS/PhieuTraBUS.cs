﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IBUS;
using Data.DTO;
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
                    var checkIDDocGia = (from a in db.PHIEUMUONs
                                             where a.IDDocGia.Equals(phieutra.IDDocGia)
                                             select a).FirstOrDefault();
                    if (checkIDDocGia == null) return false;
                    db.PHIEUTRAs.Add(new PHIEUTRA()
                    {
                        IDPhieuTra = ID,
                        IDDocGia = phieutra.IDDocGia,
                        NgayTra = phieutra.NgayTra,
                        SoTienTra = 0,
                        TienNoKyNay = 0,
                        TienPhatKyNay = 0,
                    });
                    for (int i = 0; i <IDCuonSach.Count; i++)
                    {
                        int IDCT = CTPhieuTraDAO.Instance.IDPlus();
                        db.CT_PHIEUTRA.Add(new CT_PHIEUTRA()
                        {
                            IDCTPhieuTra=IDCT,
                            IDPhieuTra=ID,
                            IDPhieuMuon=phieutra.IDPhieuMuon,
                            IDCuonSach=IDCuonSach[i],     
                            SoNgayMuon=PhieuTraDAO.Instance.SoNgayMuon(phieutra.NgayTra,IDCT),
                            TienPhat=PhieuTraDAO.Instance.TinhTienPhat(phieutra.NgayTra,IDCT),
                        });
                        var updateTinhTrang = (from a in db.CUONSACHes
                                               where a.IDCuonSach.Equals(IDCuonSach[i])
                                               select a).FirstOrDefault<CUONSACH>();
                        updateTinhTrang.TinhTrang = "Chưa cho mượn";
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
      
       
    }
}
