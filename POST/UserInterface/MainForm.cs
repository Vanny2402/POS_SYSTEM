using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using POST.Navigation;
using POST.UserInterface;

namespace POST
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ribbonControl1.SelectedPage = rUser;
        }
        private void btn_user_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserForm userchild = new UserForm();
            userchild.MdiParent = this;
            userchild.Show();
        }

        private void ribbonControl1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (ribbonControl1.SelectedPage == rUser)
            {
                LayoutMain.Controls.Clear();
                LayoutMain.Controls.Add(new UserNavigation());
            }
            else if (ribbonControl1.SelectedPage == rDashboard)
            {
                LayoutMain.Controls.Clear();
            }
        }
    }
}
