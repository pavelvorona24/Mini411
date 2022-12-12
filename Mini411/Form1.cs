using System;

namespace Mini411
{
    public partial class Form1 : Form
    {
        public string[] NameArray = new string[100];
        public string[] PhoneArray = new string[100];
        int iCurrentIndex = 0;
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
                System.Windows.Forms.MessageBox.Show("Some error ");
                return;
            }




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

            int i;
            lbOutput.Items.Clear();
            for (i = 0; i < iCurrentIndex; i = i + 1)
            {
                
            }
            lbOutput.Items.Add("Number of Customers: " + i);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name;
            int i;
            name = txtInput.Text;
            i = 0;
            lbOutput.Items.Clear();
            while (i < iCurrentIndex)
            {
 
                if (NameArray[i] == name)
                {
                    
                    lbOutput.Items.Add("Selected customer: " + NameArray[i] + "  Phone number  " + PhoneArray[i]);
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
            string phone;
            int i;
            phone = txtInput2.Text;
            i = 0;
            lbOutput.Items.Clear();
            while (i < iCurrentIndex)
            {

                if (PhoneArray[i] == phone)
                {

                    lbOutput.Items.Add("Selected customer: " + NameArray[i] + "  Phone number  " + PhoneArray[i]);
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
    }
    }

        



