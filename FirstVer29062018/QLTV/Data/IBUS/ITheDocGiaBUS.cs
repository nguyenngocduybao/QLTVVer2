using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.DTO;
using Data.DAO;
namespace Data.IBUS
{
    public interface ITheDocGiaBUS
    {
        bool AddTheDocGiaAndUser(TheDocGiaDtos DocGia, UserDtos user);
        #region getListSearch Form "TheDocGia"
        List<TheDocGiaDTO> getFromTheDocGiaSearchHoTen(string TenDG);
        List<TheDocGiaDTO> getFormTheDocGiaSearchEmailDG(string EmailDG);
        List<TheDocGiaDTO> getFormTheDocGiaSearchDiaChiDG(string DiaChiDG);
        List<TheDocGiaDTO> getFormTheDocGiaSearchNgayLapThe(DateTime Ngaylap);
        List<TheDocGiaDTO> getFormTheDocGiaSearchNgaySinhDG(DateTime NgaySinh);
        #endregion
    }
}