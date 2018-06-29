using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class CTPhieuNhapSachDAO
    {
        #region Instance
        private static CTPhieuNhapSachDAO instance;

        internal static CTPhieuNhapSachDAO Instance
        {
            get
            {
                if (instance == null) instance = new CTPhieuNhapSachDAO(); return DAO.CTPhieuNhapSachDAO.instance;
            }

            private set
            {
                DAO.CTPhieuNhapSachDAO.instance = value;
            }
        }
        #endregion

    }
}
