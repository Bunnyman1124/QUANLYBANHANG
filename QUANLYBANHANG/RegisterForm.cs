using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANHANG
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        // close Register Form
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        // link to page login
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Close();
            frm1.Show();
        }

        // button sign up
            private void btsignup_Click(object sender, EventArgs e)
        {
            string username = tbusername.Text;
            string password = tbpassword.Text;
            string conPassword = tb_cpassword.Text;

            if(username == "" || password == "" || conPassword == "")
            {
                MessageBox.Show("pleas enter ");
            }else if(password.Length < 7)
            {
                MessageBox.Show("Password lenght > 7");
                tbpassword.Text = "";
                tb_cpassword.Text = "";
            }
            else if(password != conPassword)
            {
                MessageBox.Show("Password don't math");
                tbpassword.Text = "";
                tb_cpassword.Text = "";
            }
            else
            {
                con_db conn = new con_db();
                bool check = conn.Register_db(username, password);
                
                if(check)
                {
                    Form1 frmLogin = new Form1();
                    MessageBox.Show("Dang ky thanh cong");
                    this.Hide();
                    frmLogin.Show();
                }
                else
                {
                    MessageBox.Show("Dang ky khong thanh cong");
                }
            }
        }
    }
}
