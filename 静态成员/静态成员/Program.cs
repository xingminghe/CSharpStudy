using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态成员
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person.Age = 28;
            Dog g = new Dog();
            Person.TotalCount = 30;
            Console.WriteLine(Person.TotalCount);
            //DoIt("nihao");
            g.叫唤();
            Program p = new Program();
            //p.Hello();
            //Person p = new Person();
            p.DoIt("中国人民");
            Person.人口汇报();
            Console.ReadKey();
        }
        //public void Hello()
        //{
        //    DoIt("nihao");
        //}
        public  void DoIt(string person)
        {
            Console.WriteLine("offfff");
            Console.WriteLine(person);
        }
        public class Person
        {
            public static int TotalCount;
            public int Age;

            public static void 人口汇报()
            {
                Console.WriteLine("总人口数{0}",TotalCount);
            }

        }
        public class Dog
        {
            public void 叫唤()
            {
                Console.WriteLine("旺旺{0}", Person.TotalCount);
            }
        }
    }
}
