using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2_Code_LL_000013680_Baines_C
{
    public partial class Form8 : Form
    {
        AccessibilityHelper accessibilityHelper = new AccessibilityHelper();
        public Form8(AccessibilityHelper accessibilityHelper)
        {
            InitializeComponent();
            MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.accessibilityHelper = accessibilityHelper;
            accessibilityHelper.UpdateFontSize(this.Controls);
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void homeIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(accessibilityHelper);
            f1.ShowDialog();
        }

        private void backToPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(accessibilityHelper);
            f2.ShowDialog();
        }

        private void weatherIcon_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form3 f3 = new Form3();
            //f3.ShowDialog();
        }

       

        private void btnNewFontSize_Click(object sender, EventArgs e)
        {
            int fontSize;

            //Checks to see if the user input is an integer.
            try
            {
                fontSize = int.Parse(txtChangeFontSize.Text);
            }
            
            //If the user input is not an integer, an error message box is displayed and the text box is reset.
            catch
            {
                MessageBox.Show("Please enter a valid font size");
                txtChangeFontSize.Text = "";
                return;
            }
            
            //Else sets the user input entered as the font size and runs the method from the accessibiltiyHelper class.
            accessibilityHelper.fontSize = int.Parse(txtChangeFontSize.Text);
            accessibilityHelper.UpdateFontSize(this.Controls);
            

           
        }
    }
}
