using Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IBUS
{
    public interface ICTTacGiaBUS
    {
        //Add Form CTTacGia
        bool addFormCTTacGia(CTTacGiaDtos tacGia);
        //Edit Form CTTacGia
        bool editFormCTTacGia(CTTacGiaDtos ctTacGia);
    }
}
