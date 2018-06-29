using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class CTBCTinhHinhMuonSachDAO
    {
        #region Instance
        private static CTBCTinhHinhMuonSachDAO instance;

        internal static CTBCTinhHinhMuonSachDAO Instance
        {
            get
            {
                if (instance == null) instance = new CTBCTinhHinhMuonSachDAO(); return DAO.CTBCTinhHinhMuonSachDAO.instance;
            }

            private set
            {
                DAO.CTBCTinhHinhMuonSachDAO.instance = value;
            }
        }
        #endregion

    }
}
