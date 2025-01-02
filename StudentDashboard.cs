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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem
{
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
        }

        private void updateDetails_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            updateDetails.Visible = false;
            viewBookBtn.Visible = false;
            browsBook.Visible = false;
            label11.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            Update.Visible = true;
            label2.Visible = true;
            s_country.Visible = true;
            F_Name.Visible = true;
            L_Name.Visible = true;
            S_city.Visible = true;
            S_Email.Visible = true;
            birthDate.Visible = true;
            S_IDforUpdate.Visible = true;
            S_ID_textBox.Visible = true;
            GoBackbtn.Visible = true;
            label2.Visible = true;
            Viewbooks.Visible = false;
            SearchFotStudent.Visible = true;
            viewBooksLbl.Visible = false;



        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void viewBook_Click(object sender, EventArgs e)
        {
            SearchFotStudent.Visible = false;
            searchBookBtn.Visible = false;
            updateDetails.Visible = false;
            S_ID_textBox.Visible=false;
            pictureBox1.Visible = false;
            updateDetails.Visible = false;
            viewBookBtn.Visible = false;
            browsBook.Visible = false;
            label11.Visible = true;
            viewBooksLbl.Visible = true;
            birthDate.Visible = false;
            //S_IDforUpdate.Visible = true;
            //S_ID_textBox.Visible = true;
            GoBackbtn.Visible = true;
            Viewbooks.Visible = true;
            label2.Visible = false;
            browsBookLbl.Visible = false;

            using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection("Data Source=ENOLA\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;"))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BOOK, Author, publisher ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Viewbooks.DataSource = dt;

            }



        }
        private void browsBook_Click(object sender, EventArgs e)
        {
            Viewbooks.Visible = true;
            pictureBox1.Visible = false;
            updateDetails.Visible = false;
            viewBookBtn.Visible = false;
            browsBook.Visible = false;
            BookIDForView.Visible = true;
            BookISBN_txt.Visible = true;
            searchBookBtn.Visible=true;
            label11.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            Update.Visible = false;
            label2.Visible = false;
            s_country.Visible = false;
            F_Name.Visible = false;
            L_Name.Visible = false;
            S_city.Visible = false;
            S_Email.Visible = false;
            birthDate.Visible = false;
            S_IDforUpdate.Visible = false;
            S_ID_textBox.Visible = false;
            GoBackbtn.Visible = true;//go back button
            Viewbooks.Visible = true;
            searchStudentBtn.Visible = false;
            SearchFotStudent.Visible = false;
            viewBooksLbl.Visible = false;
            browsBookLbl.Visible = true;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//go back button
        {
            pictureBox1.Visible = true;
            updateDetails.Visible = true;
            viewBookBtn.Visible = true;
            browsBook.Visible = true;
            label11.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            Update.Visible = false;
            label2.Visible = false;
            s_country.Visible = false;
            F_Name.Visible = false;
            L_Name.Visible = false;
            S_city.Visible = false;
            S_Email.Visible = false;
            birthDate.Visible = false;
            S_IDforUpdate.Visible = false;
            S_ID_textBox.Visible = false;
            GoBackbtn.Visible = false;
            searchStudentBtn.Visible = false;
            BookIDForView.Visible = false;
            BookISBN_txt.Visible = false;
            searchBookBtn.Visible = false;
            Viewbooks.Visible = false;
            SearchFotStudent.Visible = true;
            Viewbooks.DataSource = null;
            browsBookLbl.Visible = false;
            viewBooksLbl.Visible = false;




        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection("Data Source=ENOLA\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;"))
                {


                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = con;
                    con.Open();
                    //                                                       F_NAME, L_NAME, EMAIL
                    sqlCommand.CommandText = "UPDATE student SET F_NAME = '" + F_Name.Text + "',L_NAME = '" + L_Name.Text + "' ,  EMAIL = '" + S_Email.Text + "', CITY = '" + S_city.Text + "', Country = '" + s_country.Text + "' WHERE ID = '" + S_ID_textBox.Text + "' ";
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Book updated Successfully!");

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void button2_Click(object sender, EventArgs e) // view button for view books in the data grid view
        {
            using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection("Data Source=ENOLA\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;"))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BOOK,Borrow,author,publisher where borrow", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Viewbooks.DataSource = dt;

            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*string category = categoryComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection("Data Source=ENOLA\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;"))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM Book WHERE Category = @Category";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Category", category);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            Viewbooks.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }*/
        }

        

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
           //this.bOOKTableAdapter.Fill(this.libraryDataSet.BOOK);

           /* using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection("Data Source=ENOLA\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;"))
            {
                try
                {
                    con.Open();
                    string query = "SELECT DISTINCT Category FROM Book";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                categoryComboBox.Items.Add(reader["Category"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }*/

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bORROWTableAdapter.FillBy(this.libraryDataSet.BORROW);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Viewbooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchBookBtn_Click(object sender, EventArgs e)
        {
            int bookID;
            if (!int.TryParse(BookISBN_txt.Text, out bookID))
            {
                MessageBox.Show("Please enter a valid book ID.");
                return;
            }

            string sqlQuery = "SELECT * FROM BOOK WHERE ISBN = @BookID";

            using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection("Data Source=ENOLA\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;"))
            {
                using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                {
                    cmd.Parameters.AddWithValue("@BookID", bookID);

                    try
                    {
                        con.Open();

                        DataTable dt = new DataTable();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }

                        Viewbooks.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        
    }

        private void searchStudentBtn_Click(object sender, EventArgs e)
        {
            int studentID;
            if (!int.TryParse(S_ID_textBox.Text, out studentID))
            {
                MessageBox.Show("Please enter a valid ID.");
                S_ID_textBox.Text = "";
                S_ID_textBox.Focus();
                return;
            }

            string sqlQuery = "SELECT * FROM STUDENT WHERE ID = @studentID";

            using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection("Data Source=ENOLA\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;"))
            {
                using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                {
                    cmd.Parameters.AddWithValue("@studentID", studentID);

                    try
                    {
                        con.Open();

                        DataTable dt = new DataTable();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }

                        Viewbooks.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void S_ID_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void S_ID_textBox_Leave(object sender, EventArgs e)
        {

        }

        private void SearchFotStudent_Click(object sender, EventArgs e)
        {
            Viewbooks.Visible = true;
            pictureBox1.Visible = false;
            updateDetails.Visible = false;
            viewBookBtn.Visible = false;
            browsBook.Visible = false;
            BookIDForView.Visible = false;
            BookISBN_txt.Visible = false;
            searchBookBtn.Visible = false;
            label11.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            Update.Visible = false;
            label2.Visible = false;
            s_country.Visible = false;
            F_Name.Visible = false;
            L_Name.Visible = false;
            S_city.Visible = false;
            S_Email.Visible = false;
            birthDate.Visible = false;
            SearchFotStudent.Visible = false;
            S_IDforUpdate.Visible = true;
            S_ID_textBox.Visible = true;
            GoBackbtn.Visible = true;//go back button
            Viewbooks.Visible = true;
            searchStudentBtn.Visible = true;

        }
    }
}
    

