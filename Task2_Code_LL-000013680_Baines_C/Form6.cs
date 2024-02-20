using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace Task2_Code_LL_000013680_Baines_C
{
    public partial class Form6 : Form
    {
        AccessibilityHelper accessibilityHelper = new AccessibilityHelper();
        public Form6(AccessibilityHelper accessibilityHelper)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;

            this.accessibilityHelper = accessibilityHelper;
            accessibilityHelper.UpdateFontSize(this.Controls);
        }

        private void lblBacktoSignin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5(accessibilityHelper);
            f5.ShowDialog();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //Tells the code where the database is
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\M2202766\\OneDrive - Middlesbrough College\\Documents\\Year 2\\Week 16\\OSC Mock\\Task 2\\Task2_Code_LL-000013680_Baines_C\\Task2_Code_LL-000013680_Baines_C\\userDetails.mdf; Integrated Security = True; Connect Timeout = 30";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
           
            //Use stored procedure

            SqlCommand command = new SqlCommand("AddRecord", sqlConnection);

            command.CommandType = CommandType.StoredProcedure;

            //Takes username and password from the sign up form.
            //Calls the hash function to give the password a hash key (encryption).

            string username = txtUsernameSignUp.Text;

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(txtPasswordSignUp.Text);

            //string hashedPassword = ComputeSHA256Hash(txtPasswordSignUp.Text);


            //Creates a boolean for search purposes.
            bool found = false;

            //Checks to see if either of the fields for user input are empty.
            if (txtUsernameSignUp.Text == string.Empty || txtPasswordSignUp.Text == string.Empty)
            {
                found = true;
            }
               
            if (found)
            {
                MessageBox.Show("Please enter a valid username and password to sign up.");
                txtUsernameSignUp.Text = "";
                txtPasswordSignUp.Text = "";
            }

            else
            {
                MessageBox.Show("Account successfully created");

                //Opens the home screen if the user successfully creates an account.
                this.Hide();
                Form1 f1 = new Form1(accessibilityHelper);
                f1.ShowDialog();

                //Call stored procedure and pass in username and password as parameters
                
                command.Parameters.AddWithValue("@Username", username);

                command.Parameters.AddWithValue("@Password", hashedPassword);

                //Opens connection to the database, executes stored procedure and closes the connection.
                sqlConnection.Open();

                command.ExecuteNonQuery();

                sqlConnection.Close();
            }

            



        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
