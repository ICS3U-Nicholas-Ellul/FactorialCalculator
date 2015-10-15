/*
 * Created by: Nicholas  Ellul
 * Created on: 15-Oct-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 3-10
 * This program calculates factorials 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Double factorialNumber;
            Double factorialAnswer;


            this.lstList.Items.Clear();
            factorialAnswer = 1;
            factorialNumber = Convert.ToDouble(this.textBox1.Text);
            
            for(int factorialCounter = 1; factorialCounter <= factorialNumber; factorialCounter++)
            {
                
                //this.lstList.Items.Add(factorialCounter);
                factorialAnswer = factorialAnswer * factorialCounter;
            }
            this.lstList.Items.Add(factorialAnswer);
        }
    }
}
