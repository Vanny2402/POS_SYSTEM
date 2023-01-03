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
    class ClsUser
    {
        public static SqlCommand cmd;  // static to call only on this Class 
        public static SqlDataAdapter da;// to Connect Sqlcomman to datset
        public static DataTable dbl;
        public static string sql;
        public static void login(string  username, string password)
        {
            sql = "SELECT* FROM TBL_USER WHERE UserName =@UserName AND Password=@Password";
            cmd = new SqlCommand(sql, ClsDatabase.CON);
            cmd.Parameters.AddWithValue("@UserName", username);
            cmd.Parameters.AddWithValue("@Password", password);
            da = new SqlDataAdapter(cmd);
            dbl = new DataTable();
            da.Fill(dbl);
            if (dbl.Rows.Count == 0)
            {
                MessageBox.Show("UserName Invalid", "POS:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
            }
        }
    }
}
