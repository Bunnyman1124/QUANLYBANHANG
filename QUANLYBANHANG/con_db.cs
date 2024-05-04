using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANHANG
{
    public class con_db
    {
        // data register start
        public bool Register_db(string username, string password)
        {
            bool check = false;
            string strcon = @"Data Source=LAPTOP-5LQJR3UP\MSSQLSERVER02;Initial Catalog=QUANLYSTORE;Integrated Security=True;";
            string sql = "insert into tb_user(username, password) values(@user, @pass)";
            using(SqlConnection conn = new SqlConnection(strcon))
            {
                conn.Open();    
                using(SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);
                    cmd.ExecuteNonQuery();
                    check = true;
                }
            }
            return check;
        }
        // data register  end


        // data login start

        public bool Login_db(string username, string password)
        {
            bool check = false;
            string strcon = @"Data Source=LAPTOP-5LQJR3UP\MSSQLSERVER02;Initial Catalog=QUANLYSTORE;Integrated Security=True;";
            string sql = "select * from tb_user where username = @user and password = @pass";
            
            using( SqlConnection conn = new SqlConnection(strcon))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    SqlDataReader rdr = cmd.ExecuteReader();
                    check = rdr.HasRows;
                }
            }
            return check;
        }

        // data login  end
    }
}
