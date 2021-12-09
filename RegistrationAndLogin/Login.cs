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
using FaceRecognition;


namespace RegistrationAndLogin
{
    public partial class Login : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
     public  bool var1;
        public Login()
        {
            InitializeComponent();
        }

        FaceRec faceRec = new FaceRec();

        private void Login_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security = True");
            cn.Open();
            faceRec.openCamera(pictureBox1, pictureBox2);
        }
      
        private void Btnregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
         /*   
            homes.textBox1.Text = txtusername.Text;*/
            faceRec.isTrained = true;

            
                Home homes = new Home();
                homes.checkBox6.Checked = true;
                var1 = true;

            if ( txtusername.Text != string.Empty)
            {
                
               
                cmd = new SqlCommand("select * from LoginTable where username='" + txtusername.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Esta presente en la lista");
                    dr.Close();
                    this.Hide();
                    Home home = new Home();
                    home.ShowDialog();
                 




                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account available with this username and image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            


        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            faceRec.Save_IMAGE(txtusername.Text);
        }
    }
}
