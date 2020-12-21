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
    public partial class 主界面 : Form
    {
        public 主界面()
        {
            InitializeComponent();
        }

        private void btnImformation_Click(object sender, EventArgs e)
        {
            个人信息 fm = new 个人信息();
            fm.ShowDialog();
        }
    }
}
