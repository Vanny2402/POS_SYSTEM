using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POST.Class
{
    class ClsDatabase
    {
        public static SqlConnection CON = new SqlConnection("Data Source=DESKTOP-T44IHTE\\SQLEXPRESS;Initial Catalog=POSSQ9_DB;Persist Security Info=True;User ID=sa;Password=underadmin;MultipleActiveResultSets=true;");
        public static void checkconnection()
        {
            try
            {
                if (CON.State == ConnectionState.Closed)
                {
                    CON.Open();
                }
                else
                {
                    CON.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("problem With connection" + ex.Message);
            }
        }
    }
}
