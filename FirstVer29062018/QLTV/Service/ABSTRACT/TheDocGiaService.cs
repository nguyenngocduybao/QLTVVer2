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
    public class TheDocGiaService : ITheDocGiaService
    {
        private ITheDocGiaBUS _TheDocGiaBUS;
        public TheDocGiaService()
        {
            this._TheDocGiaBUS = new TheDocGiaBUS();
        }
        // Add List "THeDocGia" and "User"
        public void AddTheDocGiaAndUser(TheDocGiaDtos DocGia, UserDtos user)
        {
            _TheDocGiaBUS.AddTheDocGiaAndUser(DocGia, user);
        }
        #region getListSearch From "TheDocGia"
        public List<TheDocGiaDTO> getFormTheDocGiaSearchDiaChiDG(string DiaChiDG)
        {
            return _TheDocGiaBUS.getFormTheDocGiaSearchDiaChiDG(DiaChiDG);
        }

        public List<TheDocGiaDTO> getFormTheDocGiaSearchNgayLapThe(DateTime Ngaylap)
        {
            return _TheDocGiaBUS.getFormTheDocGiaSearchNgayLapThe(Ngaylap);
        }

        public List<TheDocGiaDTO> getFormTheDocGiaSearchNgaySinhDG(DateTime NgaySinh)
        {
            return _TheDocGiaBUS.getFormTheDocGiaSearchNgaySinhDG(NgaySinh);
        }

        public List<TheDocGiaDTO> getFromTheDocGiaSearchEmaiLDG(string EmailDG)
        {
            return _TheDocGiaBUS.getFormTheDocGiaSearchEmailDG(EmailDG);
        }

        public List<TheDocGiaDTO> getFromTheDocGiaSearchHoTen(string TenDG)
        {
            return _TheDocGiaBUS.getFromTheDocGiaSearchHoTen(TenDG);
        }
        #endregion
    }

}
