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
        public static string[] MemberInfo;

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
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewMembers);
                dataGridViewMembers.ColumnCount = 6;
                dataGridViewMembers.Columns[0].Name = "First Name";
                dataGridViewMembers.Columns[1].Name = "Last Name";
                dataGridViewMembers.Columns[2].Name = "Birth Date";
                dataGridViewMembers.Columns[3].Name = "City";
                dataGridViewMembers.Columns[4].Name = "State";
                dataGridViewMembers.Columns[5].Name = "Join Date";


                StreamReader inputFile; //to read the file
                string line; //to hold a line from the file
                int count = 0; //line counter

                //create a delimiter array
                char[] delim = { ',' };

                //open the csv file

                inputFile = File.OpenText(FileLoad);



                while (!inputFile.EndOfStream)
                {
                    //read a line from the file.
                    line = inputFile.ReadLine();

                    //get the test scores as tokens
                    string[] tokens = line.Split(delim);

                    //dataGridViewMembers.DataSource = tokens;

                    dataGridViewMembers.Rows.Add(tokens[0], tokens[1], tokens[2], tokens[3], tokens[4], tokens[5]);


                    //increment the line counter
                    count++;
                }
                //close the file
                inputFile.Close();
                labelFileName.Text = count + " lines processed.";
            }
            catch (Exception ex)
            {
                //display an error message
                MessageBox.Show(ex.Message);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            labelFileName.Text = "Please select a file to format.";
        }

        private void buttonFixDates_Click(object sender, EventArgs e)
        {
            labelFileName.Text = "Fixing.... Please wait.";

            try
            {

                dataGridViewMembers.Rows.Clear();

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewMembers);
                dataGridViewMembers.ColumnCount = 6;
                dataGridViewMembers.Columns[0].Name = "First Name";
                dataGridViewMembers.Columns[1].Name = "Last Name";
                dataGridViewMembers.Columns[2].Name = "Birth Date";
                dataGridViewMembers.Columns[3].Name = "City";
                dataGridViewMembers.Columns[4].Name = "State";
                dataGridViewMembers.Columns[5].Name = "Join Date";


                StreamReader inputFile; //to read the file
                string line; //to hold a line from the file
                int count = 0; //line counter

                //create a delimiter array
                char[] delim = { ',' };


                //open the csv file

                inputFile = File.OpenText(FileLoad);
                StreamWriter OutputFile = new StreamWriter("ConvertedDates.CSV");



                while (!inputFile.EndOfStream)
                {
                    //read a line from the file.
                    line = inputFile.ReadLine();
                    line = line.Replace(".", "/");
                    line = line.Replace("-", "/");




                    //heres where we change stuff. tokens[2] and tokens[5] are the birthdates and join dates. 
                    //so we're gonna turn them into variables, then their own arrays.

                    //get the columns as tokens
                    string[] tokens = line.Split(delim);


                    //splits the birthdate into 3 parts: MM DD & YY or YYYY
                    string date = tokens[2];

                    date = date.Replace("Jan", "1");
                    date = date.Replace("Feb", "2");
                    date = date.Replace("Mar", "3");
                    date = date.Replace("Apr", "4");
                    date = date.Replace("May", "5");
                    date = date.Replace("Jun", "6");
                    date = date.Replace("Jul", "7");
                    date = date.Replace("Aug", "8");
                    date = date.Replace("Sep", "9");
                    date = date.Replace("Oct", "10");
                    date = date.Replace("Nov", "11");
                    date = date.Replace("Dec", "12");


                    string temp = "";
                    string[] dateparts = date.Split('/');

                    //if month is abbreviated, switch with numeric value



                    if (int.Parse(dateparts[0]) > 12)
                    {
                        //switch the dates around
                        temp = dateparts[1];
                        dateparts[1] = dateparts[0];
                        dateparts[0] = temp;
                    }

                    if (int.Parse(dateparts[2]) < 1000)
                    {

                        dateparts[2] = "19" + dateparts[2];
                    }

                    if (dateparts[0].Contains("0"))
                    {
                        if (int.Parse(dateparts[0]) < 10)
                        {
                            dateparts[0].Replace("0", "");
                        }
                    }



                    tokens[2] = dateparts[0] + "/" + dateparts[1] + "/" + dateparts[2];

                    //next comes the join date

                    //splits the joindate into 3 parts: MM DD & YY or YYYY
                    string date2 = tokens[5];

                    date2 = date2.Replace("Jan", "1");
                    date2 = date2.Replace("Feb", "2");
                    date2 = date2.Replace("Mar", "3");
                    date2 = date2.Replace("Apr", "4");
                    date2 = date2.Replace("May", "5");
                    date2 = date2.Replace("Jun", "6");
                    date2 = date2.Replace("Jul", "7");
                    date2 = date2.Replace("Aug", "8");
                    date2 = date2.Replace("Sep", "9");
                    date2 = date2.Replace("Oct", "10");
                    date2 = date2.Replace("Nov", "11");
                    date2 = date2.Replace("Dec", "12");


                    string temp2 = "";
                    string[] dateparts2 = date2.Split('/');

                    //if month is abbreviated, switch with numeric value

                  


                    if (int.Parse(dateparts2[0]) > 12)
                    {
                        //switch the dates around
                        temp2 = dateparts2[1];
                        dateparts2[1] = dateparts2[0];
                        dateparts2[0] = temp2;
                    }

                    if (int.Parse(dateparts2[2]) < 1000)
                    {

                        dateparts2[2] = "19" + dateparts2[2];
                    }


                    if (dateparts2[0].Contains("0"))
                    {
                        if (int.Parse(dateparts2[0]) < 10)
                        {
                            dateparts2[0] = dateparts2[0].Replace(@"0", "");
                        }
                    }

                    if (dateparts2[1].Contains("0"))
                    {
                        if (int.Parse(dateparts2[1]) < 10)
                        {
                            dateparts2[1] = dateparts2[1].Replace(@"0", "");
                            
                        }
                    }


                    tokens[5] = dateparts2[0] + "/" + dateparts2[1] + "/" + dateparts2[2];



                    dataGridViewMembers.Rows.Add(tokens[0], tokens[1], tokens[2], tokens[3], tokens[4], tokens[5]);

                    OutputFile.WriteLine(tokens[0] + "," + tokens[1] + "," + tokens[2] + "," + tokens[3] + "," + tokens[4] + "," + tokens[5]);



                    //increment the line counter
                    count++;
                }
                //close the file
                inputFile.Close();

                
                
                labelFileName.Text = "Processing Complete!";
            }
            catch (Exception ex)
            {
                //display an error message
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            //copy the code from the fix button but tweak it so it outputs to a seperate CSV file
        }
    }
}
