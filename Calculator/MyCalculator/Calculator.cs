using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public class Calculator
    {
        public double num1;
        public double num2;
        public double result;

        public double Add()
        {
            return result = num1 + num2;
        }

        public double Sub()
        {
            return result = num1 - num2;
        }

        public double Multi()
        {
            return result = num1 * num2;
        }

        public double Div()
        {
            return result = num1 / num2;
        }
    }


}
