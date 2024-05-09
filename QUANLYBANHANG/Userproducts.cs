using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANHANG
{
    public partial class Userproducts : UserControl
    {
        public Userproducts()
        {
            InitializeComponent();
        }

        private void Userproducts_click(object sender, EventArgs e)
        {
            if (button_valid.Visible == false)
            {
                button_valid.Visible =true;
                button_valid.Visible = false;

            }
            else
            {
                button_valid.Visible = true;
                button_valid.Visible = false;
            }
        }

        private void btcheck_Click(object sender, EventArgs e)
        {
            if (button_valid.Visible == false)
            {
                button_valid.Visible = true;
                button_valid.Visible = false;

            }
            else
            {
                button_valid.Visible = true;
                button_valid.Visible = false;
            }
        }

        private void button_valid_Click(object sender, EventArgs e)
        {

        }
    }
}
