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
    public partial class 个人信息 : Form
    {
        public 个人信息()
        {
            InitializeComponent();
        }
        
        private void btnInfo_Click(object sender, EventArgs e)
        {
            label2.Text = staticInf.user.ID.ToString();
            label4.Text = staticInf.user.UserName;
            label6.Text = staticInf.user.Password;
        }

        private void btnUserModify_Click(object sender, EventArgs e)
        {
            用户信息修改 fm = new  用户信息修改();
            fm.ShowDialog();
        }
    }
}
