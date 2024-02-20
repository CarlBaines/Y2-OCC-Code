using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BCrypt.Net;

namespace Task2_Code_LL_000013680_Baines_C
{
    public partial class Form5 : Form
    {

        AccessibilityHelper accessibilityHelper = new AccessibilityHelper();
        public Form5(AccessibilityHelper accessibilityHelper)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;

            this.accessibilityHelper = accessibilityHelper;
            accessibilityHelper.UpdateFontSize(this.Controls);
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {

            //Tells the code where the database is
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\M2202766\\OneDrive - Middlesbrough College\\Documents\\Year 2\\Week 16\\OSC Mock\\Task 2\\Task2_Code_LL-000013680_Baines_C\\Task2_Code_LL-000013680_Baines_C\\userDetails.mdf; Integrated Security = True; Connect Timeout = 30";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
                
            //Creates an empty list
            List<User> userDetailsList = new List<User>();

            //Sets up stored procedure
            SqlCommand cmd = new SqlCommand("GetUserDetails", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;

            //Executes stored procedure
            SqlDataAdapter sd = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();


            sqlConnection.Open();

            sd.Fill(dt);

            sqlConnection.Close();


            //Gets every field out of the person record and puts it into the people list.
            foreach (DataRow dr in dt.Rows)

            {

                userDetailsList.Add(

                new User()
                {

                    Id = Convert.ToInt32(dr["Id"]),

                    username = Convert.ToString(dr["Username"]),

                    password = Convert.ToString(dr["Password"])

                   

                });

            }

            //Take username and password inputs from form.

            string UserInputtedUsername = txtUsernameSignIn.Text;


            //Sets up a temporary boolean for search purposes.
            bool found = false;

            //Loops through each user in the database
            foreach (User user in userDetailsList)
            {   
                //Checks if the user inputted username and password are equal to those stored in the database
                if (UserInputtedUsername == user.username)
                {
                    found = BCrypt.Net.BCrypt.Verify(txtPasswordSignIn.Text, user.password);
                    break; 
                }
            }

            if (found)
            {
                MessageBox.Show("You have successfully signed in");

                //Hides sign in page and loads the app's homepage
                this.Hide();
                Form1 f1 = new Form1(accessibilityHelper);
                f1.ShowDialog();
            }

            else
            {   
                MessageBox.Show("Invalid login details. Please try again!");
                //Clears the input fields so the user can retry entering valid login details.
                txtUsernameSignIn.Clear();
                txtPasswordSignIn.Clear();
            }

        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {   
            //Navigates the user to the sign up page and closes the sign in page.
            this.Hide();
            Form6 f6 = new Form6(accessibilityHelper);
            f6.ShowDialog();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
