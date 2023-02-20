using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace aim_reflex_training_project
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMainPage fr = new FrmMainPage();
            if (TxtUserName.Text == "admin" && TxtPassword.Text=="0000")
            {
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username and password");
            }
            
       
        }
    }
}
