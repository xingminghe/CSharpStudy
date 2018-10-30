using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaculatDistnce
{
    partial class Circle
    {
        private double radios;
        public static int Count = 0;
        public double area = 0;

        //public Circle()
        //{
        //    radios = 10;
        //    Count++;
        //}
        //public Circle(double Radios)
        //{
        //    radios = Radios;
        //    Count++;
        //}

        public double Area()
        {
            area = Math.PI * radios * radios;
            return area;
        }

    }
}
