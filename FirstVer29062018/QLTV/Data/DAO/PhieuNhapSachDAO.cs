using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class PhieuNhapSachDAO
    {
        #region Instance
        private static PhieuNhapSachDAO instance;

        internal static PhieuNhapSachDAO Instance
        {
            get
            {
                if (instance == null) instance = new PhieuNhapSachDAO(); return DAO.PhieuNhapSachDAO.instance;
            }

            private set
            {
                DAO.PhieuNhapSachDAO.instance = value;
            }
        }
        #endregion

    }
}
