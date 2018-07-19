using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.IService;
using Data.IBUS;
using Data.BUS;
using Data.Dtos;
using Data.DAO;
using Data.DTO;
namespace Service.ABSTRACT
{
    public class SachService : ISachService
    {
        private ISachBUS _iSachBUS;
        public SachService()
        {
            this._iSachBUS = new SachBUS();
        }
        public void ADDFormSach(SachDTO sach)
        {
            this._iSachBUS.ADDFormSach(sach);
        }
    }
}
