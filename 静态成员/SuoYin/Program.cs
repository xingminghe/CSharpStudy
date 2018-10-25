using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuoYin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4 };
            int i = values[2];
            Person p1=new Person();
            p1[1]="小明";
            Console.WriteLine(p1[1]+p1[2]);
            p1[2]="小红";
            Console.WriteLine(p1[1] + p1[2]);
            Console.ReadKey();
        }
    }
    class Person
    {
        private string FirstName = "大毛";
        private string SecondName = "二毛";
        public string this[int index]
        {
            set
            {
                if (index == 1)
                {
                    FirstName = value;
                }
                else if (index == 2)
                {
                    SecondName = value;
                }
                else
                {
                    throw new Exception("错误的序号：");
                }
            }
            get 
            {
                if (index == 1)
                {
                    return FirstName;
                }
                else if (index == 2)
                {
                    return SecondName;
                }
                else
                {
                    throw new Exception("错误的序号：");
                }
            }
        }
    }
}
