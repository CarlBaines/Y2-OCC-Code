using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2_Code_LL_000013680_Baines_C
{
    public partial class Form1 : Form
    {
        public AccessibilityHelper accessibilityHelper { get; set; }
        public Form1(AccessibilityHelper accessibilityHelper)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            this.accessibilityHelper = accessibilityHelper;
            accessibilityHelper.UpdateFontSize(this.Controls);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void locationContinue_Click(object sender, EventArgs e)
        {   
            //Checks to see if the location text box has an empty string.
            if (txtLocation.Text == string.Empty)
            {
                MessageBox.Show("Please input a location to get a weather forecast for.");
            }
            else
            {
                this.Hide();
                Form3 f3 = new Form3(accessibilityHelper, txtLocation.Text);
                f3.ShowDialog();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Checks to see if a location has been entered in the top box.
            if (txtLocation.Text == string.Empty)
            {
                MessageBox.Show("You need to enter a location in the top box before you can view weather warnings.");
            }
            else
            {
                this.Hide();
                Form3 f3 = new Form3(accessibilityHelper, txtLocation.Text);
                f3.ShowDialog();
            }
        }

        private void settingsIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(accessibilityHelper);
            f2.ShowDialog();


        }

        private void weatherIcon_Click(object sender, EventArgs e)
        {   

            //Checks to see if a location has been entered in the top box.
            if (txtLocation.Text == string.Empty)
            {
                MessageBox.Show("You need to enter a location in the top box before you can navigate to the weather forecast page.");
            }
            else
            {
                this.Hide();
                Form3 f3 = new Form3(accessibilityHelper, txtLocation.Text);
                f3.ShowDialog();
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void txtLocation_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void btnReadMore2_Click(object sender, EventArgs e)
        {
            //Checks to see if a location has been entered in the top box.
            if (txtLocation.Text == string.Empty)
            {
                MessageBox.Show("You need to enter a location in the top box before you view air quality.");
            }
            else
            {
                this.Hide();
                Form3 f3 = new Form3(accessibilityHelper, txtLocation.Text);
                f3.ShowDialog();
            }
        }
    }
}
