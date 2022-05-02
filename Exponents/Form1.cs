using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name: William Seaver
 * Date: 5/1/2022
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:
 *************************************/

namespace Exponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xGoButton_Click(object sender, EventArgs e)
        {
            // STORAGE
            int Input = 0;
            int Squared = 0;
            int Cubed = 0;
            // INPUT
 
            Input = Convert.ToInt32(xInputTextBox.Text);
          
            // PROCESS
            /* calculate the square of the number and add it to the output - 
             * do this with a method call that allows you to pass the number
             * and then receive the answer */
            Squared = Square(Input);
            xOutputLabel.Text = Convert.ToString(Squared);

            /* calculate the cube of the number and add it to the output - 
             * do this by creating a methd as in the squaring example above */
            Cubed = Cube(Input);
            try
            {
                xOutputLabel.Text = Convert.ToString(Squared) + " " + Convert.ToString(Cubed);
            }
            catch (FormatException)
            {
                xOutputLabel.Text = "Please enter an integer";
            }
            // OUTPUT
            // set the output to visible
            xOutputLabel.Visible = true;
            // turn the Go button off
            xGoButton.Enabled = false;
        }

        public int Square(int num)
        {
            // we will create this code in class
            int Squared = num * num;
            return Squared;
        }

        public int Cube(int num)
        {
            // we will create this code in class
            int Cubed = num * num * num;
            return Cubed;
        }

        private void xResetButton_Click(object sender, EventArgs e)
        {
            // the input and output text should be emptied
            xInputTextBox.Text = "";
            xOutputLabel.Text = "";
            // turn the output to invisible
            xOutputLabel.Visible = false;
            // turn the Go button back on
            xGoButton.Enabled = true;
        }

    }
}
