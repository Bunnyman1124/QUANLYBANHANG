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

namespace QUANLYBANHANG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm frmregister = new RegisterForm();
            this.Hide();
            frmregister.Show();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            string username = tbusername.Text;
            string password = tbpassword.Text;
            string strcon = @"Data Source=LAPTOP-5LQJR3UP\MSSQLSERVER02;Initial Catalog=QUANLYSTORE;Integrated Security=True;";

            if(username == "" || password == "")
            {
                MessageBox.Show("Pleas enter");
            }
            else
            {
                con_db conn = new con_db();
                bool check = conn.Login_db(username, password);
                if (check)
                {
                    MessageBox.Show("Dang nhap thanh cong");
                    RegisterForm registerForm = new RegisterForm();
                    this.Hide();
                    registerForm.Show();
                }
                else
                {
                    MessageBox.Show("Dang nhap khong thanh cong");
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
