using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class LoaiDocGiaDAO
    {
        #region Instance
        private static LoaiDocGiaDAO instance;

        internal static LoaiDocGiaDAO Instance
        {
            get
            {
                if (instance == null) instance = new LoaiDocGiaDAO(); return DAO.LoaiDocGiaDAO.instance;
            }
            private set
            {
                DAO.LoaiDocGiaDAO.instance = value;
            }
        }
        #endregion
    }
}
