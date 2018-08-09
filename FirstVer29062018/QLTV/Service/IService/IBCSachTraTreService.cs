using Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface IBCSachTraTreService
    {
        //Load Form BaoCaoSachTraTre
        List<BCSachTraTreDtos> LoadForm();
    }
}
