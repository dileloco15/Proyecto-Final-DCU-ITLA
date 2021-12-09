using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistrationAndLogin;

namespace RegistrationAndLogin
{
    public partial class Home : Form
    {

        bool var2;
        public Home()
        {
            InitializeComponent();


        

        }

       public void button1_Click(object sender, EventArgs e)
        {
            Apoyo apoyo = new Apoyo();
            apoyo.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void Home_Load(object sender, EventArgs e)
        {
            Login log = new Login();

           var2 = log.var1;
            checbox1.Checked = true;

            if (var2 == true)
            {
                checbox1.Checked = true;


            }
       //     
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
