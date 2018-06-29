using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class CuonSachDAO
    {
        #region Instance
        private static CuonSachDAO instance;

        internal static CuonSachDAO Instance
        {
            get
            {
                if (instance == null) instance = new CuonSachDAO(); return DAO.CuonSachDAO.instance;
            }

            private set
            {
                DAO.CuonSachDAO.instance = value;
            }
        }
        #endregion

    }
}
