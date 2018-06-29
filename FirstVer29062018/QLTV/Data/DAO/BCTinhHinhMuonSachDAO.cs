using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class BCTinhHinhMuonSachDAO
    {
        #region Instance
        private static BCTinhHinhMuonSachDAO instance;

        internal static BCTinhHinhMuonSachDAO Instance
        {
            get
            {
                if (instance == null) instance = new BCTinhHinhMuonSachDAO(); return DAO.BCTinhHinhMuonSachDAO.instance;
            }

            private set
            {
                DAO.BCTinhHinhMuonSachDAO.instance = value;
            }
        }
        #endregion

    }
}
