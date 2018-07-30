using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IBUS;
using Data.Dtos;
using Data.DTO;
using Data.Model;
using Data.DAO;
namespace Data.BUS
{
    public class TheDocGiaBUS:ITheDocGiaBUS
    {
        #region Add From "THeDocGia" and From "User"
        public bool AddTheDocGiaAndUser(TheDocGiaDtos DocGia,UserDtos user)
        {
            try
            {
                using (var db = new QuanLyThuVienEntities())
                {
                    int ID = TheDocGiaDAO.Instance.IDPlus();
                    db.THEDOCGIAs.Add(new THEDOCGIA()
                    {
                        IDDocGia = ID,
                        HoTenDG = DocGia.HoTenDG,
                        DiaChiDG = DocGia.DiaChiDG,
                        EmailDG = DocGia.EmailDG,
                        NgaySinhDG = DocGia.NgaySinhDG,
                        NgayLapThe = DocGia.NgayLapThe,
                        IDLoaiDG = DocGia.IDLoaiDocGia,
                        TongNo = 0,
                        NgayHetHan = TheDocGiaDAO.Instance.countHanThe(DocGia.NgayLapThe),
                    });
                    db.USERS.Add(new USER()
                    {
                        IDDocGia = ID,
                        UserName = user.UserName,
                        Pwd = user.Password,
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
        #region getList All "DocGia" and "User"
        public List<TheDocGiaDTO> getAllDocGiaAndUser()
        {
            List<TheDocGiaDTO> listTheDocGiaDTO = new List<TheDocGiaDTO>();
            listTheDocGiaDTO = TheDocGiaDAO.Instance.getAllDocGiaAndUser();
            return listTheDocGiaDTO;
        }
        #endregion
        public List<TheDocGiaDTO> getFormTheDocGiaSearchDiaChiDG(string DiaChiDG)
        {
            try
            {
                List<TheDocGiaDTO> listTheDocGiaDTO = new List<TheDocGiaDTO>();
                listTheDocGiaDTO = TheDocGiaDAO.Instance.getFormTheDocGiaSearchDiaChiDG(DiaChiDG);
                return listTheDocGiaDTO;

            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
        #region getListSearch From "TheDocGia"
        // getListSearch HoTenDG From "TheDocGia"
        public List<TheDocGiaDTO> getFromTheDocGiaSearchHoTen(string TenDG)
        {
            try
            {

                List<TheDocGiaDTO> listTheDocGiaDTO = new List<TheDocGiaDTO>();
                listTheDocGiaDTO = TheDocGiaDAO.Instance.getFromTheDocGiaSearchHoTenDG(TenDG);
                return listTheDocGiaDTO;
            }
            catch (Exception)
            {

                throw;
            }
        }
        // getListSearch EmailDG From "TheDocGia"
        public List<TheDocGiaDTO> getFormTheDocGiaSearchEmailDG(string EmailDG)
        {
            try
            {
                List<TheDocGiaDTO> listTheDocGiaDTO = new List<TheDocGiaDTO>();
                listTheDocGiaDTO = TheDocGiaDAO.Instance.getFormTheDocGiaSearchEmailDG(EmailDG);
                return listTheDocGiaDTO;

            }
            catch (Exception)
            {

                throw;
            }
        }
        // getListSearch NgayLap From "TheDocGia"
        public List<TheDocGiaDTO> getFormTheDocGiaSearchNgayLapThe(DateTime Ngaylap)
        {
            try
            {
                List<TheDocGiaDTO> listTheDocGiaDTO = new List<TheDocGiaDTO>();
                listTheDocGiaDTO = TheDocGiaDAO.Instance.getFormTheDocGiaSearchNgayLapThe(Ngaylap);
                return listTheDocGiaDTO;

            }
            catch (Exception)
            {

                throw;
            }
        }
        // getListSearch NgaySinh From "TheDocGia"
        public List<TheDocGiaDTO> getFormTheDocGiaSearchNgaySinhDG(DateTime NgaySinh)
        {
            try
            {
                List<TheDocGiaDTO> listTheDocGiaDTO = new List<TheDocGiaDTO>();
                listTheDocGiaDTO = TheDocGiaDAO.Instance.getFormTheDocGiaSearchNgaySinhDG(NgaySinh);
                return listTheDocGiaDTO;

            }
            catch (Exception)
            {

                throw;
            }
        }
        //get list Search UserName 
        public List<TheDocGiaDTO> getFormTheDocGiaSearchUserName(string Username)
        {
            try
            {
                List<TheDocGiaDTO> listTheDocGiaDTO = new List<TheDocGiaDTO>();
                listTheDocGiaDTO = TheDocGiaDAO.Instance.getFormTheDocGiaSearchUserName(Username);
                return listTheDocGiaDTO;
            }
            catch (Exception)
            {

                throw;
            };
        }
        #endregion
    }
}
