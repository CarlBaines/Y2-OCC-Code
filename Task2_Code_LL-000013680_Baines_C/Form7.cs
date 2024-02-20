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

namespace Task2_Code_LL_000013680_Baines_C
{
    public partial class Form7 : Form
    {
        AccessibilityHelper accessibilityHelper = new AccessibilityHelper();

        public string location; 
        public Form7(AccessibilityHelper accessibilityHelper)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            this.accessibilityHelper = accessibilityHelper;
            accessibilityHelper.UpdateFontSize(this.Controls);
        }

        

        private void backtoHomeIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(accessibilityHelper);
            f1.ShowDialog();
        }

        private void weatherIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3(accessibilityHelper, location);
            f3.ShowDialog();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tells the code where the database is
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\M2202766\\OneDrive - Middlesbrough College\\Documents\\Year 2\\Week 16\\OSC Mock\\Task 2\\Task2_Code_LL-000013680_Baines_C\\Task2_Code_LL-000013680_Baines_C\\userDetails.mdf; Integrated Security = True; Connect Timeout = 30";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Use stored procedure

            SqlCommand command = new SqlCommand("UpdateRecord", sqlConnection);

            command.CommandType = CommandType.StoredProcedure;

            //Takes the changed username and password from the form

            string id = txtID.Text;
            string updatedUsername = txtChangeUsername.Text;
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(txtChangePassword.Text);

            //temporary boolean for search purposes
            bool found = false;

            //Checks to see if any of the fields are empty.
            if (txtID.Text == string.Empty || txtChangeUsername.Text == string.Empty || txtChangePassword.Text == string.Empty)
            {
                found = true;
            }

            if (found)
            {
                MessageBox.Show("Please enter a valid ID, username and password");
            }

            else
            {
                command.Parameters.AddWithValue("@StdId", id);
                command.Parameters.AddWithValue("@Username", updatedUsername);
                command.Parameters.AddWithValue("@Password", hashedPassword);

                sqlConnection.Open();

                command.ExecuteNonQuery();

                MessageBox.Show("Your username and password have successfully been changed. Please sign back in");

                sqlConnection.Close();

                this.Hide();
                Form5 f5 = new Form5(accessibilityHelper);
                f5.ShowDialog();
            }

        }

        private void backIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(accessibilityHelper);
            f2.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
