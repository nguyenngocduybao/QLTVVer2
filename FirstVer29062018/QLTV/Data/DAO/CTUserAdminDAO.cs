using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class CTUserAdminDAO
    {
        #region Instance
        private static CTUserAdminDAO instance;

        internal static CTUserAdminDAO Instance
        {
            get
            {
                if (instance == null) instance = new CTUserAdminDAO(); return DAO.CTUserAdminDAO.instance;
            }

            private set
            {
                DAO.CTUserAdminDAO.instance = value;
            }
        }
        #endregion

    }
}
