using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class GetDataDAO
    {
        #region Instance
        private static GetDataDAO instance;

        internal static GetDataDAO Instance
        {
            get
            {
                if (instance == null) instance = new GetDataDAO(); return DAO.GetDataDAO.instance;
            }

            private set
            {
                DAO.GetDataDAO.instance = value;
            }
        }
        #endregion
        
    }

}
