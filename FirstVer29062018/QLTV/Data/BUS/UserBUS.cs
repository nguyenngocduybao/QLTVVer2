using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IBUS;
using Data.Model;
using Data.DAO;
using Data.DTO;

namespace Data.BUS
{
    public class UserBUS : IUserBUS
    {
        #region getListSearch UserDTO
        // search UserName
        public List<UserDTO> getFromUserSearchUserName(string Name)
        {
            try
            {
                List<UserDTO> listUserDTO = new List<UserDTO>();
                listUserDTO = UserDAO.Instance.getFromUserSearchUserName(Name);
                return listUserDTO;

            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
