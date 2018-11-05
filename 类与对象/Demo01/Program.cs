using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person zhangsan = new Person();
            zhangsan.Name = "张三";
            //zhangsan.gender = "男";
            //zhangsan.birthday = Convert.ToDateTime("1996-03-24");
            //zhangsan.color = "黄";
            //zhangsan.job = "软件工程师";
            //zhangsan.nationality = "中国";

            Console.WriteLine(zhangsan.Name);
            Console.ReadKey();
        }
    }
    class Person
    {
        private string name;
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        private string gender;
        private string color;
        private double height;
        private DateTime birthday;
        private string job;
        private string nationality;
    }
}
