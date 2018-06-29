using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class LoaiSachDAO
    {
        #region Instance
        private static LoaiSachDAO instance;

        internal static LoaiSachDAO Instance
        {
            get
            {
                if (instance == null) instance = new LoaiSachDAO(); return DAO.LoaiSachDAO.instance;
            }

            private set
            {
                DAO.LoaiSachDAO.instance = value;
            }
        }
        #endregion
    }
}
