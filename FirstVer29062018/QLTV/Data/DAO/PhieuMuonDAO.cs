using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class PhieuMuonDAO
    {
        #region Instance
        private static PhieuMuonDAO instance;

        internal static PhieuMuonDAO Instance
        {
            get
            {
                if (instance == null) instance = new PhieuMuonDAO(); return DAO.PhieuMuonDAO.instance;
            }

            private set
            {
                DAO.PhieuMuonDAO.instance = value;
            }
        }
        #endregion

    }
}
