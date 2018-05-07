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
        //ths isvalidnumber method accepts a string and returns true if it contains 10 digits, or false otherwise
        private bool isValidNumber(string str)
        {
            const int VALID_LENGTH = 10; //length of a valid string
            bool valid = true; //flag to indicate validity

            //check the strings length
            if (str.Length == VALID_LENGTH)
            {
                //check each character in str
                foreach (char ch in str)
                {
                    //if this character is not a digit, the string is not valid
                    if (!char.IsDigit(ch))
                    {
                        valid = false;
                    }
                }
            }
            else
            {
                //incorrect length
                valid = false;
            }
            //return the status
            return valid; 
        }

        //the telephoneformat method accepts a string argument by reference and formats it as a telephone number
        private void TelephoneFormat(ref string str)
        {
            //fist insert the left paren at position 0
            str = str.Insert(0, "(");
            //next insert the right paren at position 4
            str = str.Insert(4, ")");
            //next, insert the hyphen at position 8
            str = str.Insert(8, "-");
        }

        private void formatButton_Click(object sender, EventArgs e)
        {
            //get a trimmed copy of the user's input
            string input = numberTextBox.Text.Trim();
            //if the input is a valid number, format it and display it
            if (isValidNumber(input))
            {
                TelephoneFormat(ref input);
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


    }
}
