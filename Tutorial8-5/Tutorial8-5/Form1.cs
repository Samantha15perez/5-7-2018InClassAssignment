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

namespace Tutorial8_5
{

    struct PhoneBookEntry
    {
         public string name;
         public string phone;
    }

    public partial class Form1 : Form
    {
        //field to hold a list of PhoneBookEntry objects.
        private List<PhoneBookEntry> phoneList = new List<PhoneBookEntry>();

        public Form1()
        {
            InitializeComponent();
        }

        //the readfile method reads the contents of the phonelist.txt file and stores it as 
        //phonebookentry objects in the phonelist

            private void ReadFile()
        {
            try
            {

            
                StreamReader inputfile; //to read the file
                string line; //to hold a line from the file

                //create an instance of the phonebookentry structure
                PhoneBookEntry entry = new PhoneBookEntry();

                //create a delimiter array
                char[] delim = { ',' };

                //open the phonelist file
                inputfile = File.OpenText("Phonelist.txt");

                //read the lines from the file
                while (!inputfile.EndOfStream)
                {
                    //read a line from the file
                    line = inputfile.ReadLine();

                    //tokenize the line
                    string[] tokens = line.Split(delim);

                    //store the tokens in the entry object
                    entry.name = tokens[0];
                    entry.phone = tokens[1];

                    //add the entry object to the list
                    phoneList.Add(entry);
                }
            }
            catch (Exception ex)
            {
                //display an error message
                MessageBox.Show(ex.Message);
            }

        }

        //the displaynames method displays the list of names in the nameslistbox control

            private void displayNames()
        {
            foreach (PhoneBookEntry entry in phoneList)
            {
                nameslistbox.Items.Add(entry.name);
            }
        }

        

        private void buttonexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //read the phonelist.txt file
            ReadFile();

            //display the names
            displayNames();
        }

        private void nameslistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get the index of the selected item
            int index = nameslistbox.SelectedIndex;

            //display teh corresponding phone number
            phonelabel.Text = phoneList[index].phone;
        }
    }
}
