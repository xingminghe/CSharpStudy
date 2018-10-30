using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaculatDistnce
{
    class Person
    {
        public string name = string.Empty;
        public int age;
        public static int num = 0;

        public Person()
        {
            num++;
        }
        public void Sleep()
          
        {
 
        }
        
        public static int Getumber()
        {
            Person p1 = new Person();
            int a = p1.age;
            return num;
        }
    }
}
