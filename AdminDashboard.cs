using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Net;



namespace LibraryManagementSystem
{
    public partial class AdminDashboard : Form
    {

        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void addBook_Click(object sender, EventArgs e)
        {
            /*AddBook a = new AddBook();
            a.Show();
            this.Hide();*/
            pictureBox1.Visible = false;
            updateBook.Visible = false;
            viewBook.Visible = true;
            addBook.Visible = false;
            B_ID.Visible = true;
            title_addBook.Visible = true;
            B_ISBN.Visible = true;
            B_publication_y.Visible = true;
            B_Title.Visible = true;
            B_edition.Visible = true;
            B_category.Visible = true;
            textBox1.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox2.Visible = true;
            ID_textBox.Visible = true;
            add.Visible = true;
            Gobackbutton.Visible = true;
            dataGridView1.Visible = false;
            DeleteBook.Visible = false;
            searchForBook.Visible = false;
            delete.Visible = false;
            deleteLabel.Visible = false;


        }

        private void updateBook_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            updateBook.Visible = false;
            viewBook.Visible = true;
            addBook.Visible = false;
            B_ID.Visible = false;
            title_addBook.Visible = false;
            B_ISBN.Visible = false;
            B_publication_y.Visible = true;
            B_Title.Visible = true;
            B_edition.Visible = true;
            B_category.Visible = true;
            textBox1.Visible = false;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox2.Visible = true;
            button2.Visible = true;
            BookID_textBox.Visible = true;
            BookIDForView.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            Gobackbutton.Visible = true;
            B_ID.Visible = false;
            ID_textBox.Visible = false;
            add.Visible = false;
            dataGridView1.Visible = false;
            DeleteBook.Visible = false;
            searchForBook.Visible = false;
            deleteLabel.Visible = false;



        }

        private void viewBook_Click(object sender, EventArgs e)
        {
            //viewBooks v = new viewBooks();
            //v.Show();
            //this.Hide();
            pictureBox1.Visible = false;
            updateBook.Visible = false;
            viewBook.Visible = false;
            addBook.Visible = false;
            title_addBook.Visible = false;
            Gobackbutton.Visible = true;
            //BookIDForView.Visible = true;
            //BookID_textBox.Visible=true;
            viewBooks.Visible = true;
            dataGridView1.Visible = true;
            DeleteBook.Visible = false;
            searchForBook.Visible = false; 
            B_ID.Visible = false;
            title_addBook.Visible = false;
            B_ISBN.Visible = false;
            B_publication_y.Visible = false;
            B_Title.Visible = false;
            B_edition.Visible = false;
            B_category.Visible = false;
            textBox1.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox2.Visible = false;
            button2.Visible = false;
            ID_textBox.Visible = false;
            Gobackbutton.Visible = true;
            delete.Visible = false;
            add.Visible = false;
            deleteLabel.Visible = false;


            using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection("Data Source=ENOLA\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;"))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BOOK, Author, publisher ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }

        }
        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection("Data Source=ENOLA\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;"))
                {
                    con.Open();
                    string sqlQueryInsert = "INSERT INTO BOOK (ISBN, TITLE, Category, EDITION, Publication_y, pub_ID ) VALUES (@ISBN, @TITLE, @Category, @EDITION, @Publication_y, @ID)";

                    SqlCommand command = new SqlCommand(sqlQueryInsert, con);
                    command.Parameters.AddWithValue("@ISBN", textBox1.Text);
                    command.Parameters.AddWithValue("@TITLE", textBox5.Text);
                    command.Parameters.AddWithValue("@Category", textBox2.Text);
                    command.Parameters.AddWithValue("@EDITION", textBox4.Text);
                    command.Parameters.AddWithValue("@Publication_y", textBox3.Text);
                    command.Parameters.AddWithValue("@ID", ID_textBox.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Book added!");

                    pictureBox1.Visible = true;
                    updateBook.Visible = true;
                    viewBook.Visible = true;
                    addBook.Visible = true;
                    B_ID.Visible = false;
                    title_addBook.Visible = false;
                    B_ISBN.Visible = false;
                    B_publication_y.Visible = false;
                    B_Title.Visible = false;
                    B_edition.Visible = false;
                    B_category.Visible = false;
                    textBox1.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    textBox2.Visible = false;
                    button2.Visible = false;
                    ID_textBox.Visible = false;
                    Gobackbutton.Visible = true;
                    add.Visible = true;
                    dataGridView1.Visible = false;
                    add.Visible = false;
                    searchForBook.Visible = true;
                    DeleteBook.Visible = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void B_ID_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//go back button
        {
            pictureBox1.Visible = true;
            addBook.Visible = true;
            viewBook.Visible = true;
            updateBook.Visible = true;
            B_category.Visible = false;
            B_edition.Visible = false;
            B_ID.Visible = false;
            B_ISBN.Visible = false;
            B_publication_y.Visible = false;
            B_Title.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            ID_textBox.Visible = false;
            BookIDForView.Visible = false;
            BookID_textBox.Visible = false;
            label2.Visible = false;
            Gobackbutton.Visible = false;
            add.Visible = false;
            viewBooks.Visible = false;
            button2.Visible = false;
            title_addBook.Visible = false;
            dataGridView1.Visible = false;
            DeleteBook.Visible = true;
            searchForBook.Visible = true;
            searchBookBtn.Visible = false;
            deleteLabel.Visible = false;

        }

        private void add_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection("Data Source=ENOLA\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;"))
                {
                    con.Open();
                    string sqlQueryInsert = "INSERT INTO BOOK (ISBN, TITLE, Category, EDITION, Publication_y, pub_ID ) VALUES (@ISBN, @TITLE, @Category, @EDITION, @Publication_y, @ID)";

                    SqlCommand command = new SqlCommand(sqlQueryInsert, con);
                    command.Parameters.AddWithValue("@ISBN", textBox1.Text);
                    command.Parameters.AddWithValue("@TITLE", textBox5.Text);
                    command.Parameters.AddWithValue("@Category", textBox2.Text);
                    command.Parameters.AddWithValue("@EDITION", textBox4.Text);
                    command.Parameters.AddWithValue("@Publication_y", textBox3.Text);
                    command.Parameters.AddWithValue("@ID", ID_textBox.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Book added!");

                    pictureBox1.Visible = true;
                    updateBook.Visible = true;
                    viewBook.Visible = true;
                    addBook.Visible = true;
                    B_ID.Visible = false;
                    title_addBook.Visible = false;
                    B_ISBN.Visible = false;
                    B_publication_y.Visible = false;
                    B_Title.Visible = false;
                    B_edition.Visible = false;
                    B_category.Visible = false;
                    textBox1.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    textBox2.Visible = false;
                    button2.Visible = false;
                    ID_textBox.Visible = false;
                    Gobackbutton.Visible = true;
                    add.Visible = true;
                    dataGridView1.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)//update button
        {

            try
            {
                using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection("Data Source=ENOLA\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;"))
                {


                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = con;
                    con.Open();
                    sqlCommand.CommandText = "UPDATE Book SET title = '" + textBox5.Text + "',Publication_y = '" + textBox3.Text + "' ,  category = '" + textBox2.Text + "', edition = '" + textBox4.Text + "' WHERE ISBN = '" + BookID_textBox.Text + "' ";
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Book updated Successfully!");

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BookID_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteBook_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            updateBook.Visible = false;
            addBook.Visible = false;
            title_addBook.Visible = false;
            Gobackbutton.Visible = true;
            BookIDForView.Visible = true;
            BookID_textBox.Visible=true;
            BookIDForView.Visible=true;
            dataGridView1.Visible = true;
            DeleteBook.Visible = false;
            delete.Visible = true;
            searchBookBtn.Visible = false;
            DeleteBook.Visible = false;
            searchForBook.Visible = false;
            viewBook.Visible = false;
            deleteLabel.Visible = true;

        }

        private void delete_Click(object sender, EventArgs e)
        {
            string bookISBN = BookID_textBox.Text;

            if (!string.IsNullOrEmpty(bookISBN))
            {
                using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection("Data Source=ENOLA\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;"))
                {
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM Book WHERE ISBN = @ISBN";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@ISBN", bookISBN);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Book deleted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("No book found with the given ISBN.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ISBN.");
            }

            using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection("Data Source=ENOLA\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;"))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BOOK, Author, publisher Where ISBN = ISBN ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }

        private void searchForBook_Click(object sender, EventArgs e)
        {
            searchBookBtn.Visible = true;
            dataGridView1.Visible = true ;
            DeleteBook.Visible = false;
            searchForBook.Visible = false;
            BookID_textBox.Visible = true;
            BookIDForView.Visible = true;
            Gobackbutton.Visible = true; 
            viewBooks.Visible = false;
            addBook.Visible = false;
            searchForBook.Visible=false;
            DeleteBook.Visible=false;
            updateBook.Visible=false;
            deleteLabel.Visible = false;







        }

        private void searchBookBtn_Click(object sender, EventArgs e)
        {
            int bookID;
            if (!int.TryParse(BookID_textBox.Text, out bookID))
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

                        dataGridView1.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }
    }
}
