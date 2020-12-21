using BookShop.DAL;
using BookShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.BLL
{
    public class UserManager
    {
        public BookShop.Model.User Login(string loginId,string loginName,string loginPwd)
        {
            BookShop.Model.User user = BookShop.DAL.UserService.GetUserByLoginId(loginId);
            if (user.UserName == loginName && user.Password == loginPwd)
            {
                return user;
            }
            else
            {
                return null;
            }
            
        }
        public BookShop.Model.User Register(string regName,string regPwd)
        {
            BookShop.Model.User user = BookShop.DAL.UserService.AddUser(regName,regPwd);
            return user;
        }
        public User Modify(int moID,string moUserName,string moPassword)
        {
            User user = UserService.ModifyUser(moID,moUserName, moPassword);
            
            return user;
        }
    }
}
