using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConverter
{
    public partial class Form1 : Form
    {
        //Create a Degree object
        Degree degree = new Degree();

        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close program
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tempTextBox.Text != null)
                {
                    if (CtoFradioButton.Checked)
                    {
                        double celsius = Double.Parse(tempTextBox.Text);
                        errorLabel.Text = "";
                        resultLabel.Text = degree.CtoF(celsius).ToString("n2") + " F";
                        
                    }
                    else if (FtoCradioButton.Checked)
                    {
                        double fahrenheit = Double.Parse(tempTextBox.Text);
                        errorLabel.Text = "";
                        resultLabel.Text = degree.FtoC(fahrenheit).ToString("n2") + " C";
                    }
                }
                else 
                {
                    errorLabel.Text = "Please enter numeric temperature!";
                }
            }
            catch
            {
                errorLabel.Text = "Please enter numeric temperature!";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            tempTextBox.Text = "";
            CtoFradioButton.Checked = false;
            FtoCradioButton.Checked = false;
            errorLabel.Text = "";
            tempTextBox.Focus();
        }

        private void tempTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
