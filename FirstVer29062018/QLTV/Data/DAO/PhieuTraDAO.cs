using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class PhieuTraDAO
    {
        #region Instance
        private static PhieuTraDAO instance;

        internal static PhieuTraDAO Instance
        {
            get
            {
                if (instance == null) instance = new PhieuTraDAO(); return DAO.PhieuTraDAO.instance;
            }

            private set
            {
                DAO.PhieuTraDAO.instance = value;
            }
        }
        #endregion

    }
}
