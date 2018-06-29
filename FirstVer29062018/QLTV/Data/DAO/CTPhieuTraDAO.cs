using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class CTPhieuTraDAO
    {
        #region Instance
        private static CTPhieuTraDAO instance;

        internal static CTPhieuTraDAO Instance
        {
            get
            {
                if (instance == null) instance = new CTPhieuTraDAO(); return DAO.CTPhieuTraDAO.instance;
            }

            private set
            {
                DAO.CTPhieuTraDAO.instance = value;
            }
        }
        #endregion

    }
}
