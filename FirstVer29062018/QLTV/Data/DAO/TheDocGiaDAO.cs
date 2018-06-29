using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class TheDocGiaDAO
    {
        #region Instance
        private static TheDocGiaDAO instance;

        internal static TheDocGiaDAO Instance
        {
            get
            {
                if (instance == null) instance = new TheDocGiaDAO(); return DAO.TheDocGiaDAO.instance;
            }

            private set
            {
                DAO.TheDocGiaDAO.instance = value;
            }
        }
        #endregion
    }
}
