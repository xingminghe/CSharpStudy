using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态类
{
    class Program
    {
        static void Main(string[] args)
        {
           ConsoleHelper.ReadInt();
        }
        static class ConsoleHelper
        {
            public static int ReadInt()
            {
                string str = Console.ReadLine();
                return Convert.ToInt32(str);
            }
        }
    }
}
