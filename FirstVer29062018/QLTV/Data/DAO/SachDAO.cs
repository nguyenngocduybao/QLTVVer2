using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class SachDAO
    {
        #region Instance
        private static SachDAO instance;

        internal static SachDAO Instance
        {
            get
            {
                if (instance == null) instance = new SachDAO(); return DAO.SachDAO.instance;
            }

            private set
            {
                DAO.SachDAO.instance = value;
            }
        }
        #endregion

    }
}
