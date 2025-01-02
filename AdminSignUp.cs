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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem
{
    public partial class AdminSignUp : Form
    {
        public AdminSignUp()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentDashboard_Click(object sender, EventArgs e)
        {
            using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection("Data Source=ENOLA\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;"))
            {
                con.Open();
                string sqlQueryInsert = "INSERT INTO ADMIN (ID, F_NAME, L_NAME, EMAIL, P_NO, PASSWORD ) VALUES (@ID, @F_NAME, @L_NAME, @EMAIL, @P_NO, @PASSWORD)";

                SqlCommand command = new SqlCommand(sqlQueryInsert, con);
                command.Parameters.AddWithValue("@ID", ID_textBox.Text);
                command.Parameters.AddWithValue("@F_NAME", name_textBox.Text);
                command.Parameters.AddWithValue("@L_NAME", Lname_TXB.Text);
                command.Parameters.AddWithValue("@EMAIL", email_TXB.Text);
                command.Parameters.AddWithValue("@P_NO", Phone_TXB.Text);
                command.Parameters.AddWithValue("@PASSWORD", Password_TXB.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Admin registration successful!");

                AdminDashboard ad = new AdminDashboard();
                ad.Show();
                this.Hide();

            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AdminSignUp_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            login.Visible = true;
            LGpass.Visible = true;
            loginId.Visible = true;
            lloginID.Visible = true;
            loginPass.Visible = true;
            label12.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            A_ID.Visible = false;
            Lname_TXB.Visible = false;
            name_textBox.Visible = false;
            email_TXB.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            Password_TXB.Visible=false;
            Phone_TXB.Visible = false; 
            ID_textBox.Visible  =false;
            A_dashboard.Visible = false;

        }

        private void login_Click(object sender, EventArgs e)
        {
            using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection("Data Source=ENOLA\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;"))
            {
                con.Open();
                string sqlQueryLogin = "SELECT * FROM ADMIN WHERE ID= '" + loginId.Text + "' and PASSWORD= '" + loginPass.Text + "'";
                SqlCommand command = new SqlCommand(sqlQueryLogin, con);

                new AdminDashboard().Show();
                this.Hide();
            }
        }
    }
}
