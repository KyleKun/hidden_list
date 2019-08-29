using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiddenList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Hide feature.
        private void btnHide_Click(object sender, EventArgs e)
        {
            if (btnHide.Text == ">")
            {
                panel1.Hide();
                btnHide.Text = "<";
            }
            else if (btnHide.Text == "<")
            {
                panel1.Show();
                btnHide.Text = ">";
            }
           
        }

        //Closes Application.
        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
