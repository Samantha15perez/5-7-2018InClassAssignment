using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tutorial8_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the form
            this.Close();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile; //to read the file
                string line; //to hold a line from the file
                int count = 0; //student counter
                int total; //accumulator
                double average; //test score average

                //create a delimiter array
                char[] delim = { ',' };

                //open the csv file
                inputFile = File.OpenText("Grades.csv");
                
                while (!inputFile.EndOfStream)
                {
                    //increment the student counter
                    count++;

                    //read a line from the file.
                    line = inputFile.ReadLine();

                    //get the test scores as tokens
                    string[] tokens = line.Split(delim);

                    //set the accumulator to 0
                    total = 0;

                    //calculate the total of the test score tokens
                    foreach (string str in tokens)
                    {
                        total += int.Parse(str);
                    }

                    //calculate the average of these test scores
                    average = (double)total / tokens.Length;

                    //display the average
                    averagesListBox.Items.Add("The average for student " + count + " is " + average.ToString("n1"));
                }
                //close the file
                inputFile.Close();

            }
            catch (Exception ex)
            {
                //display an error message
                MessageBox.Show(ex.Message);
            }
        }
    }
}
