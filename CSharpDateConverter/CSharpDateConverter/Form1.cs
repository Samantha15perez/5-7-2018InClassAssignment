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

namespace CSharpDateConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string FileLoad = "";

        private void button1_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.  
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            
            openFileDialog1.Filter = "CSV Files|*.csv|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.Title = "Select a Source File";
            openFileDialog1.InitialDirectory = @"Desktop\";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;



            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               
                labelFileName.Text = openFileDialog1.FileName;
                FileLoad = openFileDialog1.FileName;
            }
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
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

                    inputFile = File.OpenText(FileLoad);



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

        private void ddatagridMemberInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
