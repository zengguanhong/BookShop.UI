using BookShop.Model;
using BookShop.DAL;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.DAL
{
    public class UserService
    {
        public static User GetUserByLoginId(string loginId)
        {
            string sql = "SELECT * FROM Users WHERE ID = @LoginId";          
            using (SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@LoginId", loginId)))
            {
                if (reader.Read())
                {
                    User user = new BookShop.Model.User();
                    user.ID = (int)reader["ID"];
                    user.UserName = (string)reader["UserName"];
                    user.Password = (string)reader["Password"];                                  
                    reader.Close();
                    
                    return user;
                }
                else
                {
                    reader.Close();  
                    return null;
                }
            }
        }
        public static BookShop.Model.User AddUser(string regName,string regPwd)
        {
            string sql = "INSERT INTO Users VALUES(@regName,@regPwd)";
            sql += "; SELECT @@IDENTITY AS 'ID'";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@regName", regName), 
				new SqlParameter("@regPwd", regPwd)
				
            };
            int newID = DBHelper.GetScalar(sql, para);
            BookShop.Model.User user = new BookShop.Model.User();
            user.ID = newID;
            user.UserName = regName;
            user.Password = regPwd;
            return user;
        }
        public static User ModifyUser(int moID,string moUserName,string moPassword)
        {
            string sql = "UPDATE Users SET UserName=@moUserName,Password=@moPassword where ID=@id";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@id", moID),
                new SqlParameter("@moUserName", moUserName),
                new SqlParameter("@moPassword", moPassword)

            };
            DBHelper.ExecuteCommand(sql, para);
            User user = new User();
            user.ID = moID;
            user.UserName = moUserName;
            user.Password = moPassword;
            return user;
        }

    }
}
