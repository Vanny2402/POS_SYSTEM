using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using POST.Class;
using System.Data.OleDb;

using Xamarin.Forms;
using DevExpress.XtraEditors;

namespace POST.UserInterface
{
    public partial class UserForm : DevExpress.XtraEditors.XtraForm
    {
        public UserForm()
        {
            InitializeComponent();
            txt_userName.Text = "Demo";
            txt_password.Text = "Abc";
            txt_salary.Text = "1000";
            txt_description.Text = "DemoTest";
            ComboGender.SelectedIndex = 1;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            string username = txt_userName.Text.Trim();
            string gender = ComboGender.SelectedItem.ToString();
            DateTime dateOfbirth = dtDob.Value;
            string password = txt_password.Text.Trim();
            string description = txt_description.Text.Trim();
            float salary = float.Parse(txt_salary.Text.Trim());
            string phone = txt_phone.Text.Trim();
            int possitionId = 1;
            byte[] img = Public_function.converterDemo(use_Picturebox.Image);
            int active = 0;
            if (is_active.Checked)
                active = 1;
            else
                active = 0;
            ClsUser.userInsesrt(username, gender, dateOfbirth, password, description, salary, phone, active, possitionId, img);
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            DataTable dt = ClsUser.LoadDatatoGrid();
        }
        private void use_Picturebox_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (f.ShowDialog() == DialogResult.OK)
            {
                use_Picturebox.Image = new Bitmap(f.FileName);
            }
        }                   
    }
}
