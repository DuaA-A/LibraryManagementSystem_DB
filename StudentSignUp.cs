using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class StudentSignUp : Form
    {
        public StudentSignUp()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void A_dashboard_Click(object sender, EventArgs e)
        {
            using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection("Data Source=ENOLA\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;"))
            {
                con.Open();
                string sqlQueryInsert = "INSERT INTO STUDENT (ID, F_NAME, L_NAME, EMAIL, B_DATE, CITY, COUNTRY, PASSWORD, P_NO,SSN ) VALUES (@ID, @F_NAME, @L_NAME, @EMAIL, @B_DATE, @CITY, @COUNTRY, @PASSWORD,@P_NO,@SSN)";

                SqlCommand command = new SqlCommand(sqlQueryInsert, con);
                command.Parameters.AddWithValue("@ID", S_ID.Text);
                command.Parameters.AddWithValue("@F_NAME", F_Name.Text);
                command.Parameters.AddWithValue("@L_NAME", L_Name.Text);
                command.Parameters.AddWithValue("@EMAIL", S_Email.Text);
                command.Parameters.AddWithValue("@B_DATE", textBox1.Text);
                command.Parameters.AddWithValue("@CITY", S_city.Text);
                command.Parameters.AddWithValue("@COUNTRY", s_country.Text);
                command.Parameters.AddWithValue("@PASSWORD", password.Text);
                command.Parameters.AddWithValue("@P_NO", P_NO.Text);
                command.Parameters.AddWithValue("@SSN", S_SSN.Text);


                
                if (F_Name.Text == "" || F_Name.Text.Length <= 3)
                {
                    ErrorProvider errorProvider = new ErrorProvider();
                    errorProvider.SetError(this.F_Name, "Name field can NOT be empty.");
                }
               
                command.ExecuteNonQuery();
                MessageBox.Show("Admin registration successful!");

                
            }
        }

        private void F_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void L_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void S_SSN_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void s_country_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void S_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void S_ID_Click(object sender, EventArgs e)
        {
            

        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "" || password.Text.Length <= 3)
            {
                ErrorProvider errorProvider = new ErrorProvider();
                errorProvider.SetError(this.password, "Password is NOT valid OR empty.");
            }


        }

        private void S_ID_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void password_MouseClick(object sender, MouseEventArgs e)
        {
            label8.Visible = false;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            label11.Visible = false;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();

            if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text.Length < 6)
            {

                errorProvider.SetError(this.textBox1, "NOT valid birth date.");
                label11.Visible = true; 
            }
            else
            {
                errorProvider.SetError(this.textBox1, "");
                label11.Visible = false; 
            }
        }


        private void S_ID_Leave(object sender, EventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();

            if (string.IsNullOrEmpty(ID.Text) || ID.Text.Length <= 6)
            {
                if (string.IsNullOrEmpty(ID.Text))
                {
                    errorProvider.SetError(this.ID, "ID field cannot be empty.");
                }
                else if (ID.Text.Length <= 6)
                {
                    errorProvider.SetError(this.ID, "ID is not valid. It must be longer than 6 characters.");
                }
            }
            else
            {
                errorProvider.SetError(this.ID, "");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            checkBox1.Visible= false;
            label7.Visible = false;
            label3.Visible = false;
            label5.Visible= false;
            ID.Visible = false;
            SSN.Visible = false;   
            label6.Visible = false;
            label4.Visible = false;
            label9.Visible = false;
            label2.Visible = false;
            label1.Visible = false;
            label11.Visible = false;
            label8.Visible = false;
            password.Visible = false;
            ID.Visible= false;
            S_Email.Visible = false;
            P_NO.Visible = false;
            S_SSN.Visible = false;
            s_country.Visible = false;  
            S_city.Visible = false;
            S_Email.Visible= false;
            S_ID.Visible= false;
            textBox1.Visible = false;
            L_Name.Visible= false;
            F_Name.Visible = false;
            label12.Visible = false;
            login.Visible = true;
            LGpass.Visible = true;
            loginId.Visible = true;
            lloginID.Visible = true;
            loginPass.Visible = true;


        }

        private void label11_Click(object sender, EventArgs e)
        {
            label11.Visible = false;
        }

        private void login_Click(object sender, EventArgs e)
        {
            using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection("Data Source=ENOLA\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;"))
            {
                con.Open();

                string sqlQueryLogin = "SELECT COUNT(*) FROM STUDENT WHERE ID = @ID AND PASSWORD = @PASSWORD";
                using (SqlCommand command = new SqlCommand(sqlQueryLogin, con))
                {
                    command.Parameters.AddWithValue("@ID", loginId.Text);
                    command.Parameters.AddWithValue("@PASSWORD", loginPass.Text);

                    int userCount = (int)command.ExecuteScalar();
                    if (userCount < 0)
                    {
                        MessageBox.Show("Invalid login credentials. Please try again.");
                    }
                    else
                    {
                        new StudentDashboard().Show();
                        this.Hide();
                    }
                }
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
            }
        }

        private void StudentSignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
