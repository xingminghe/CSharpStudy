using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace MyStaticCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);
            double result = 0;
            switch (cbSelectAction.Text)
            {
                case "+":
                    result = StaticCalculator.Add(num1, num2);
                    break;
                case "-":
                    result = StaticCalculator.Sub(num1, num2);
                    break;
                case "×":
                    result = StaticCalculator.Multi(num1, num2);
                    break;
                case "÷":
                    result = StaticCalculator.Div(num1, num2);
                    break;
            }
            txtResult.Text = result.ToString();
                
        }
    }
}
