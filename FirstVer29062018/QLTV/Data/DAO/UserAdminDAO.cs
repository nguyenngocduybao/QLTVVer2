﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class UserAdminDAO
    {
        #region Instance
        private static UserAdminDAO instance;

        internal static UserAdminDAO Instance
        {
            get
            {
                if (instance == null) instance = new UserAdminDAO(); return DAO.UserAdminDAO.instance;
            }

            private set
            {
                DAO.UserAdminDAO.instance = value;
            }
        }
        #endregion

    }
}
