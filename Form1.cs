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

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=ENOLA\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;Trust Server Certificate=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminSignUp d = new AdminSignUp();
            d.Show();

        }

        private void StudentDashboard_Click(object sender, EventArgs e)
        {
            StudentSignUp d = new StudentSignUp();
            d.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
