using Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IBUS
{
    public interface IBCSachTraTreBUS
    {
        //Load Form BaoCaoSachTraTre
        List<BCSachTraTreDtos> LoadForm();
        //getListAll BCSachTratre
        List<BCSachTraTreDtos> getListAllBCSachTraTre();
        //Load BaoCao to Date
        List<BCSachTraTreDtos> loadBaoCaoToDate(DateTime NgayLapBaoCao);
    }
}
