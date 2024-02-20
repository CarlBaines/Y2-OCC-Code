using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Task2_Code_LL_000013680_Baines_C
{
    public partial class Form2 : Form
    {
        AccessibilityHelper accessibilityHelper = new AccessibilityHelper();
        public Form2(AccessibilityHelper accessibilityHelper)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            this.accessibilityHelper = accessibilityHelper;
            accessibilityHelper.UpdateFontSize(this.Controls);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("You have allowed the app to take your location.");
            }
            else if (checkBox1.Checked == false)
            {
                MessageBox.Show("You have disabled app location tracking.");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void editProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7(accessibilityHelper);
            f7.ShowDialog();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your account has successfully been signed out!");
            this.Hide();
            Form5 f5 = new Form5(accessibilityHelper);
            f5.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(accessibilityHelper);
            f1.ShowDialog();
        }


        private void backtoHomeIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(accessibilityHelper);
            f1.ShowDialog();
        }

        private void weatherIcon_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form3 f3 = new Form3();
            //f3.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void editTextSize_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8(accessibilityHelper);
            f8.ShowDialog();
        }
    }
}
