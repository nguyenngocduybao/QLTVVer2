using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;

namespace Data.DAO
{
    public class UserDAO
    {
        #region Instance
        private static UserDAO instance;

        internal static UserDAO Instance
        {
            get
            {
                if (instance == null) instance = new UserDAO(); return DAO.UserDAO.instance;
            }

            private set
            {
                DAO.UserDAO.instance = value;
            }
        }
        #endregion


    }
}
