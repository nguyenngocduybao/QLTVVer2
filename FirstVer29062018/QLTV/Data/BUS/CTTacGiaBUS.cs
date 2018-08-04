using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IBUS;
using Data.Model;
using Data.DAO;
using Data.DTO;
using Data.Dtos;
namespace Data.BUS
{
    public class CTTacGiaBUS:ICTTacGiaBUS
    {
        #region add Form CTTacGia
        public bool addFormCTTacGia(CTTacGiaDtos tacGia)
        {
            try
            {
                using (var db = new QuanLyThuVienEntities())
                {
                    int ID = CTTacGiaDAO.Instance.IDPlus();
                    var checkIDTacGia = (from a in db.TACGIAs
                                         where a.IDTacGia.Equals(tacGia.IDTacGia)
                                         select a).FirstOrDefault();
                    if (checkIDTacGia == null) return false;
                    else
                    {
                        var checkIDDauSach = (from a in db.SACHes
                                              where a.IDDauSach.Equals(tacGia.IDDauSach)
                                              select a).FirstOrDefault();
                        if (checkIDDauSach == null) return false;
                        else
                            db.CT_TACGIA.Add(new CT_TACGIA()
                            {
                                IDCTTacGia = ID,
                                IDTacGia = tacGia.IDTacGia,
                                IDDauSach = tacGia.IDDauSach,
                            });
                        db.SaveChanges();
                        return true;
                    }
                }
            }
            catch (Exception)
            {

                return false;
            }

               
        }
        #endregion
        #region editForm CTTacGia
        public bool editFormCTTacGia(CTTacGiaDtos ctTacGia)
        {
            try
            {
                using (var db = new QuanLyThuVienEntities())
                {
                    var editCTTacGia = (from a in db.CT_TACGIA
                                        where a.IDCTTacGia.Equals(ctTacGia.IDCTTacGia)
                                        select a).FirstOrDefault();
                    if (editCTTacGia == null) return false;
                    editCTTacGia.IDTacGia = ctTacGia.IDTacGia;
                    editCTTacGia.IDDauSach = ctTacGia.IDDauSach;
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
