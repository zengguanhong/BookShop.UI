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
    public partial class 注册界面 : Form
    {
        public 注册界面()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userName = textUserName.Text.Trim();
            string password = textPassword.Text;
            if(password.Length > 8)
            {
                MessageBox.Show("密码格式错误！密码长度最长不超过8。请重新输入！");
            }
            else
            {
                BookShop.Model.User user = new BookShop.Model.User();
                BookShop.BLL.UserManager mgr = new BookShop.BLL.UserManager();
                user = mgr.Register(userName, password);
                if (user == null)
                {
                    MessageBox.Show("注册失败");
                }
                else
                {
                    MessageBox.Show("注册成功！欢迎" + user.UserName + "！请记住您的ID：" + user.ID);
                }
            }
            
        }        
    }
}
