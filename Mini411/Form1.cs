using System;
using System.Reflection;

namespace Mini411
{
    public partial class Form1 : Form
    {
        //define public array variables
        public string[] NameArray = new string[100];
        public string[] PhoneArray = new string[100];
        int iCurrentIndex = 0;
        int iglobal;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {  
                //show all button logic to reflect all the records from arrays
                int i;
                lbOutput.Items.Clear();
                for (i = 0; i < iCurrentIndex; i = i + 1)
                {
                    lbOutput.Items.Add("Customer: " + i + "  Name:  " + NameArray[i] + "  Number:  " + PhoneArray[i]);
                }
                txtInput.Clear();
                txtInput2.Clear();
            }   
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            //add button logic to add attributes (name, and phone number) to array
            string name, phone;
            name = txtInput.Text;
            phone = txtInput2.Text;
            if (iCurrentIndex >= 100) // Array is full
            {
                System.Windows.Forms.MessageBox.Show("Array is Full! ");
                return;
            }
            if (1 == 1 )
            {
                NameArray[iCurrentIndex] = name; // Save in the array
                PhoneArray[iCurrentIndex] = phone;
                iCurrentIndex = iCurrentIndex + 1; // Update iCurrentIndex
                System.Windows.Forms.MessageBox.Show("Successful Add to the array");
                txtInput.Clear();
                txtInput2.Clear();

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Some error just for testing ");
                return;
            }




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // number of customers button logic to display total number of elements in array
            
            lbOutput.Items.Clear();
            lbOutput.Items.Add("Number of Customers: " + iCurrentIndex);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //search by name button logic to find record matching the name value added through search field
            string name;
            int i;
            name = txtInput.Text;
            i = 0;
            lbOutput.Items.Clear();
            while (i < iCurrentIndex)
            {
 
                if (NameArray[i] == name)
                {
                    //if matching name found, display the entire record from 2 arrays matching the searching pattern
                    lbOutput.Items.Add("Selected customer: " + NameArray[i] + "  Phone number  " + PhoneArray[i]);
                    // added selected record to global var for subsequent add or delete
                    iglobal = i;
                    break;
                }
                i = i + 1;
            }
            
            if (NameArray[i] is null)
            {
                System.Windows.Forms.MessageBox.Show("No records found " + i);
            }
                txtInput.Clear();
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {   
            //search by phone number button logic to find the record matching phone number value added through search field
            string phone;
            int i;
            phone = txtInput2.Text;
            i = 0;
            lbOutput.Items.Clear();
            while (i < iCurrentIndex)
            {

                if (PhoneArray[i] == phone)
                {
                    // if matching number found, display the entire record from 2 arrays matching the searching pattern
                    lbOutput.Items.Add("Selected customer: " + NameArray[i] + "  Phone number  " + PhoneArray[i]);
                    // added selected record to global var for subsequent add or delete
                    iglobal = i;
                    break;
                }
                i = i + 1;
            }

            if (PhoneArray[i] is null)
            {
                System.Windows.Forms.MessageBox.Show("No records found " + i);
            }
            txtInput.Clear();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (iglobal >= 0)
            {
                // update phone number for selected record in array via search by name
                PhoneArray[iglobal] = txtInput2.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ( iglobal >= 0 )
            {
                // if single record selected, program deletes it from both arrays as well as decrement icurrentindex
                NameArray = NameArray.Where((source, index) => index != iglobal).ToArray();
                PhoneArray = PhoneArray.Where((source, index) => index != iglobal).ToArray();
                iCurrentIndex = iCurrentIndex - 1;
                System.Windows.Forms.MessageBox.Show("Record Deleted from array");
            }
        }
    }
    }

        



