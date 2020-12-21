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
    public partial class 登录界面 : Form
    {
        public 登录界面()
        {
            InitializeComponent();
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Id = textID.Text;
            string userName = textUserName.Text.Trim();
            string password = textPassword.Text;
            BookShop.BLL.UserManager mgr = new BookShop.BLL.UserManager();
            BookShop.Model.User user = mgr.Login(Id,userName,password);
            if(user == null)
            {
                MessageBox.Show("登陆失败!");
            }
            
            if(user != null)//登录成功跳转主界面
            {

                staticInf.user = user;
                主界面 fm = new 主界面();
                fm.ShowDialog();
               
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            注册界面 fm = new 注册界面();
            fm.ShowDialog();
        }
    }
}
