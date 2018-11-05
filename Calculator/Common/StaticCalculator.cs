using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class StaticCalculator
    {
        public static double Add(double num1,double num2)
        {
            return num1 + num2;
        }

        public static double Sub(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multi(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Div(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
