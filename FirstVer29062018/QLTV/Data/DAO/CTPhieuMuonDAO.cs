using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class CTPhieuMuonDAO
    {
        #region Instance
        private static CTPhieuMuonDAO instance;

        internal static CTPhieuMuonDAO Instance
        {
            get
            {
                if (instance == null) instance = new CTPhieuMuonDAO(); return DAO.CTPhieuMuonDAO.instance;
            }

            private set
            {
                DAO.CTPhieuMuonDAO.instance = value;
            }
        }
        #endregion

    }
}
