using BookShop.BLL;
using BookShop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop.UI
{
    public partial class 用户信息修改 : Form
    {
        public 用户信息修改()
        {
            InitializeComponent();
        }

        private void btnModifyUser_Click(object sender, EventArgs e)
        {
            int moID = staticInf.user.ID;
            string moUserName = staticInf.user.UserName;
            string moPassword = staticInf.user.Password;
            moUserName = textModifyUserName.Text.Trim();
            moPassword = textModifyPassword.Text;
            if (textModifyUserName.Text.Length == 0)
            {
                moUserName = staticInf.user.UserName;
            }
            if (textModifyPassword.Text.Length == 0)
            {
                moPassword = staticInf.user.Password;
            }
            UserManager mgr = new UserManager();
            User user = new User();
            user = mgr.Modify(moID,moUserName, moPassword);
            MessageBox.Show("修改信息成功！"+user.UserName+user.Password);
        }
    }
}
