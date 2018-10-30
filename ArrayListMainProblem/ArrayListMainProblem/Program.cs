using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListMainProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList objArrayList = new ArrayList();
            objArrayList.Add(13);
            objArrayList.Add(3.123234);
            objArrayList.Add('h');
            objArrayList.Add("haha");
            objArrayList.Add(DateTime.Now);
            objArrayList.Add(true);

            //foreach (string item in objArrayList)
            //{
            for (int i = 0;i< objArrayList.Count;i++)
            {
                Console.WriteLine(objArrayList[i]);
            }
            Console.ReadKey();
            //}

        }
    }
}
