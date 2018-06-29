using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class BCSachTraTreDAO
    {
        #region Instance
        private static BCSachTraTreDAO instance;

        internal static BCSachTraTreDAO Instance
        {
            get
            {
                if (instance == null) instance = new BCSachTraTreDAO(); return DAO.BCSachTraTreDAO.instance;
            }

            private set
            {
                DAO.BCSachTraTreDAO.instance = value;
            }
        }
        #endregion

    }
}
