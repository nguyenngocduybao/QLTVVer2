using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IBUS;
using Data.BUS;
using Data.Dtos;
using Data.DAO;
using Data.DTO;
using Service.IService;
namespace Service.ABSTRACT
{
    public class CTPhieuMuonService : ICTPhieuMuonService
    {
        private ICTPhieuMuonBUS _iCTPhieuMuon;
        public CTPhieuMuonService()
        {
            this._iCTPhieuMuon = new CTPhieuMuonBUS();
        }
        public void addFormCTPhieuMuon(CTPhieuMuonDTO ctPhieuMuon)
        {
            this._iCTPhieuMuon.addFormCTPhieuMuon(ctPhieuMuon);
        }
    }
}
