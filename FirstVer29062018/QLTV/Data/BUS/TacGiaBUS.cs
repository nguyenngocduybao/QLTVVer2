using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IBUS;
using Data.Model;
using Data.DAO;
using Data.Dtos;

namespace Data.BUS
{
    public class TacGiaBUS : ITacGiaBUS
    {
        //Add Form "TacGia"
        public bool AddFormTacGia(TacGiaDtos tacGia)
        {
            try
            {
                using (var db= new QuanLyThuVienEntities())
                {
                    int ID = TacGiaDAO.Instance.IDPlus();
                    db.TACGIAs.Add(new TACGIA()
                    {
                        IDTacGia = ID,
                        TenTacGia = tacGia.TenTacGia,
                        NgaySinh = tacGia.NgaySinh,
                    });
                    db.SaveChanges();
                    return true; 
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
        #region getList Search TacGiaDtos
        // getList Search IDTacGia From"TacGia"
        public List<TacGiaDtos> getFormTacGiaSearchIDTacGia(int ID)
        {
            try
            {
                List<TacGiaDtos> ListTacGia = new List<TacGiaDtos>();
                ListTacGia = TacGiaDAO.Instance.getFormTacGiaSearchIDTacGia(ID);
                return ListTacGia;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //getList Search TenTacGia From "TacGia"
        public List<TacGiaDtos> getFormTacGiaSearchTenTacGia(string TenTG)
        {
            try
            {
                List<TacGiaDtos> ListTacGia = new List<TacGiaDtos>();
                ListTacGia = TacGiaDAO.Instance.getFormTacGiaSearchTenTacGia(TenTG);
                return ListTacGia;

            }
            catch (Exception)
            {

                throw;
            }
        }
        //getList Search NgaySinhTacGia From "TacGia"
        public List<TacGiaDtos> getFormTacGiaSearchNgaySinhTG(DateTime NgaySinh)
        {
            try
            {
                List<TacGiaDtos> ListTacGia = new List<TacGiaDtos>();
                ListTacGia = TacGiaDAO.Instance.getFormTacGiaSearchNgaySinhTG(NgaySinh);
                return ListTacGia;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
