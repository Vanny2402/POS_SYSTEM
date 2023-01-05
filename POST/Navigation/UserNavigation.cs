using POST.Class;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POST.Navigation
{
    public partial class UserNavigation : UserControl
    {
        public UserNavigation()
        {
            InitializeComponent();
        }

        private void Gridcontroll_Click(object sender, EventArgs e)
        {

        }

        private void binding()
        {
            //UserName.DataSource =
        }

        private void UserNavigation_Load(object sender, EventArgs e)
        {
            DataTable dt = ClsUser.LoadDatatoGrid();
            GridControl_user.DataSource = dt;
        }
    }
}
