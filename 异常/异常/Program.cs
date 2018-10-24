using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 异常
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i = Convert.ToInt32("abc");

            }
            catch (Exception ex)
            {
                Console.WriteLine("数据错误"+ex.Message);
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("数据正确");
            }
            Console.ReadKey();
            //CreateFile("D:/1.txt");
            //CreateFile("D:/2.txt");
            //Console.ReadKey();
            //DeleteFile("D:/1.txt");
            //DeleteFile("D:/2.txt");
        }
        static int DeleteFile(string filepath)
        {

            File.Delete(filepath);
            return 0;
 
        }
        static int CreateFile(string filepath1)
        {
            FileStream fs = File.Create(filepath1);
           fs.Close();
            return 0;
 
        }
    }
}
