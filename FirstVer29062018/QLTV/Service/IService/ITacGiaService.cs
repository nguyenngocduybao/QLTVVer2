using Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface ITacGiaService
    {
        //Add Form "TacGia"
        void AddFormTacGia(TacGiaDtos tacGia);
        // getList Search IDTacGia From"TacGia"
        List<TacGiaDtos> getFormTacGiaSearchIDTacGia(int ID);
        //getList Search TenTacGia From "TacGia"
        List<TacGiaDtos> getFormTacGiaSearchTenTacGia(string TenTG);
        //getList Search NgaySinhTacGia From "TacGia"
        List<TacGiaDtos> getFormTacGiaSearchNgaySinhTG(DateTime NgaySinh);
    }
}
