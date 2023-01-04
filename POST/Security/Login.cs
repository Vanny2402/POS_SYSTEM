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

namespace POST.Security
{
    public partial class User_form : Form
    {
        public User_form()
        {
            InitializeComponent();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }  
        private void btn_Login_Click(object sender, EventArgs e)
        {
            ClsDatabase.checkconnection();
            ClsUser.login(txt_username.Text.Trim(),txt_password.Text.Trim());
        }

        private void User_form_Load(object sender, EventArgs e)
        {
            txt_password.Text = "admin";
            txt_username.Text = "admin";
        }
    }
}
