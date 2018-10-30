using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaculatDistnce
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x1 = -1;
            //int y1 = -1;
            //Console.WriteLine("输入X2的值：");
            //int x2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("输入Y2的值：");
            //int y2 = Convert.ToInt32(Console.ReadLine());
            //double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            //Console.WriteLine("两点间的距离为：{0}", distance);
            //Console.ReadKey();

            //Console.WriteLine("输入x1的坐标：");
            //int x1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("输入y1的坐标：");
            //int y1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("输入x2的坐标：");
            //int x2=int.Parse(Console.ReadLine());
            //Console.WriteLine("输入y2的坐标：");
            //int y2 = int.Parse(Console.ReadLine());

            //Point p1 = new Point( );
            //Point p2 = new Point(x2,y2);

            ////double distance = p1.distanceTo(p2);
            //double distance2 = p2.distanceTo(p1);
            ////Console.WriteLine("p1到p2的距离为：{0}",distance);
            //Console.WriteLine("p2到p1的距离为：{0}", distance2);
            //Circle c1 = new Circle();
            //Circle c2 = new Circle(4);
            //Console.WriteLine("圆c1的面积为：{0}", c1.Area());
            //Console.WriteLine("圆c2的面积为：{0}", c2.Area());
            ////Circle count = new Circle();
            //Console.WriteLine("圆形的个数为:{0}", Circle.Count);
            ////Console.WriteLine("圆形的个数为:{0}", c1.Count);
            //Console.ReadKey();
            var object1 = new { name = "haha", age = 14 };
            var object2 = new { name = "gege", age = 'a' };
            Console.WriteLine(object1.name + object1.age);
            Console.WriteLine(object2.name + object2.age);
            //object2 = object1;
            Console.WriteLine(object2.name + object2.age);


            Person p1 = new Person();
            p1.name = "xiaoming";
            p1.age = 16;
            Person p2 = new Person();
            p2.name = "xiaohong";
            p2.age = 20;
            Person p3 = new Person();
            Console.WriteLine("p1 name={0};  p1 age={1}", p1.name, p1.age);
            Console.WriteLine("p2 name={0};  p2 age={1}", p2.name, p2.age);

            Console.WriteLine();
            p1.name = "李磊";
            p2.age = 90;
            Console.WriteLine("p1 name={0};  p1 age={1}", p1.name, p1.age);
            Console.WriteLine("p2 name={0};  p2 age={1}", p2.name, p2.age);
            Console.WriteLine();
            Console.WriteLine("有{0}个人", Person.num);
            Console.ReadKey();
            
        }

        static int Ren()
        {
            Person p1 = new Person();
            int a = p1.age;
            return 0;
        }
        
    }
    
}
