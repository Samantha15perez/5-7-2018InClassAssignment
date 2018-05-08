using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //the isvalidformat method accepts a string argument and determines whether it is properly formatted as a us telephone number
        //in the following manner: (XXX)XXX-XXXX if the argument is properly formatted, the method returns true; otherwise false.

        private bool isValidFormat(string str)
        {
            const int VALID_LENGTH = 13; //length of a valid string
            bool valid; //flag to indicate validity

            //determine whether str is properly formatted
            if (str.Length == VALID_LENGTH && str[0] == '(' &&
                str[4] == ')' && str[8] == '-')
            {
                valid = true;
            }
            else
            {
                valid = false;
            }

          
            //return the value of valid
            return valid; 
        }

        //the unformat ethod accepts a string, by reference, assumed to contain a telephone number formatted in this manner:
        //(XXX)XXX-XXXX the method unformats the string by removing the parenthesis and the hyphen. 
        private void unformat(ref string str)
        {
            //first, delete the left paren at position 0
            str = str.Remove(0, 1);
            //next, delete the right paren. because of the previous deletion, it is now located at position 3
            str = str.Remove(3, 1);
            //next delete the hyphen. because of the previous deletions it is now located at position 6.
            str = str.Remove(6, 1);

        }
        

        private void formatButton_Click(object sender, EventArgs e)
        {
            //get a trimmed copy of the user's input
            string input = numberTextBox.Text.Trim();
            //if the input  is properly formatted, unformat it and display it
            if (isValidFormat(input))
            {
                unformat(ref input);
                MessageBox.Show(input);
            }
            else
            {
                //display an error message
                MessageBox.Show("Invalid Input");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the form 
            this.Close();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
