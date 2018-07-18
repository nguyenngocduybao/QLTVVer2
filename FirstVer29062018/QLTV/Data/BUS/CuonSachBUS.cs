using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IBUS;
using Data.Model;
using Data.DAO;
using Data.Dtos;
using Data.DTO;
namespace Data.BUS
{
    public class CuonSachBUS:ICuonSachBUS
    {
        #region add Form CuonSach
        public bool addFormCuonSach(CuonSachDtos cuonSach)
        {
            try
            {
                using (var db= new QuanLyThuVienEntities())
                {
                    int ID = CuonSachDAO.Instance.IDPlus();
                    var checkIDSach = (from a in db.SACHes
                                       where a.IDSach.Equals(cuonSach.IDSach)
                                       select a).FirstOrDefault();
                    if (checkIDSach == null) return false;
                    db.CUONSACHes.Add(new CUONSACH()
                    {
                        IDCuonSach = ID,
                        IDSach = cuonSach.IDSach,
                        TinhTrang = "Chưa cho mượn",
                    });
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
