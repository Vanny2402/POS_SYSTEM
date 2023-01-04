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
            }else
            {
                new MainForm().Show();
            }
        }

        public static void userInsesrt(string username,string gender,DateTime dateOfbirht,string password,string description,float salary,string phone,int active,int possitionId,byte[] photo)
        {
            //sql = "Insert into TBL_USER VALUES(2,'abc','Female','1999-03-05','admin','Test',980,'0974005480',1,1,null);";
            using (SqlCommand cmds = new SqlCommand("Sp_insert_user", ClsDatabase.CON))
            {
                try
                {
                    cmds.CommandType = CommandType.StoredProcedure;
                    cmds.Parameters.AddWithValue("@UserName", username);
                    cmds.Parameters.AddWithValue("@Gender", gender);
                    cmds.Parameters.AddWithValue("@DateOfbirth", dateOfbirht);
                    cmds.Parameters.AddWithValue("@Password", password);
                    cmds.Parameters.AddWithValue("@Discription", description);
                    cmds.Parameters.AddWithValue("@Salary", salary);
                    cmds.Parameters.AddWithValue("@Phone", phone);
                    cmds.Parameters.AddWithValue("@Active", active);
                    cmds.Parameters.AddWithValue("@PossitionId", possitionId);
                    cmds.Parameters.AddWithValue("@Photo", photo);

                    cmds.ExecuteNonQuery();
                    MessageBox.Show("After Insert:");
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
