using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Calculator objCalc = new Calculator();
            objCalc.num1 = Convert.ToDouble(txtNum1.Text);
            objCalc.num2 = Convert.ToDouble(txtNum2.Text);
            
            switch (cbSelectAction.Text)
            {
                case "+":
                    objCalc.Add();
                    break;

                case "-":
                    objCalc.Sub();
                    break;

                case "×":
                    objCalc.Multi();
                    break;

                case "÷":
                    objCalc.Div();
                    break;
            }
            txtResult.Text = objCalc.result.ToString();
        }
    }
}
