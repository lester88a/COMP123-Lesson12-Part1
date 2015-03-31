using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Lesson12_Part1
{
    public partial class PrintForm : Form
    {
        public PrintForm()
        {
            InitializeComponent();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();

            //call message button Method
            //MessageButton_Click(sender, e);
        }

        private void MessageButton_Click(object sender, EventArgs e)
        {
            //declear DialogResult variables
            DialogResult ReturndialogResult;

            //message button, convert sender as a button
            Button messageButtonSelected = (Button)sender;

            //declear messageSring for string purpose
            string messageSring = "";
            string messageTitle = "";
            //determine which button is selected. used messageButtonSelected.Name
            if (messageButtonSelected.Name=="MessageButton1")
            {
                messageSring = "Do you want to continue?";
                messageTitle = "Continue?";
            }
            else if (messageButtonSelected.Name == "MessageButton2")
            {
                messageSring = "Do you want to stop?";
                messageTitle = "Stop?";
            }
            else
            {
                messageSring = "Did it Print?";
                messageTitle = "Printing?";
            }

            //let ReturndialogResult return the info that messagebox has
            ReturndialogResult = MessageBox.Show(messageSring, messageTitle, 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if click yes, then return yes
            if (ReturndialogResult==DialogResult.Yes)
            {
                MessageBox.Show("Yes!");
            }
            else
            {
                MessageBox.Show("No!");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a test program \nThank you for using..", "About",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show message for sure to exit?

            //declear a DialogResult, and made it to show a messagebox
            DialogResult resturnResult;

            resturnResult=MessageBox.Show("Are you sure to exit?", "Are you sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            //if click ok will exit
            if (resturnResult==DialogResult.OK)
            {
                Application.Exit(); //should exit program
            }

            
        }
    }
}
