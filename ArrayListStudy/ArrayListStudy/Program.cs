using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ArrayListStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1.显示：信息
             * 添加
             * 修改
             * 删除
             * 查询
             */
            ArrayList objArrayList = new ArrayList();
            while (1 == 1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n*********************欢迎进入通讯录管理系统*******************\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("             姓名              手机号码");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\n--------------------------------------------------------------\n");
                foreach (string item in objArrayList)
                {
                    string[] strArray = item.Trim().Split('-');
                    Console.WriteLine(strArray[0].ToString().PadLeft(16, ' ') + strArray[1].ToString().PadLeft(25, ' '));
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n**************************************************************\n");
                Console.ResetColor();
            RechooseAction:
                Console.Write("请选择要执行的操作：");
                Output("【查询 Q】【修改 U】【添加 A】【删除 D】【清空 C】【退出 E】", "M");
                string action = InputYellow().ToUpper();
                switch (action)
                {
                    case "Q"://查询
                        #region 查询
                        Console.Write("请选择输入查询的信息：");
                        Output("【姓名 N】【手机号码 M】:", "M");
                        string choose = InputYellow();
                        if (choose.ToUpper() == "N")
                        {
                            Console.Write("请输入姓名：");
                            string q_name = InputYellow();
                            for (int i = 0; i < objArrayList.Count; i++)
                            {
                                string[] qstrArray = objArrayList[i].ToString().Split('-');
                                if (qstrArray[0] == q_name)
                                {
                                    Console.Write("查询到的信息如下：");
                                    Output("姓名:" + q_name + " 电话号码：" + qstrArray[1], "R");
                                    //Console.ReadKey();
                                }
                                else if(i==objArrayList.Count-1&&qstrArray[0]!=q_name)
                                {
                                    Output("没有查到需要的信息，请重新输入：", "R");
                                }
                            }
                        }
                        else if (choose.ToUpper() == "M")
                        {
                            Console.Write("请输入手机号码：");
                            string q_mobile = InputYellow();
                            for (int i = 0; i < objArrayList.Count; i++)
                            {
                                string[] qstrArray = objArrayList[i].ToString().Split('-');
                                if (qstrArray[1] == q_mobile)
                                {
                                    Console.Write("查询到的信息如下：");
                                    Output("姓名:" + qstrArray[0] + " 电话号码：" +q_mobile, "R");
                                    //Console.ReadKey();
                                }
                            }
                        }
                        else
                        {
                            Output("无效的选择！", "R");
                            goto RechooseAction;
                        }

                        
                        break;
                    #endregion
                    case "U"://修改
                        #region 修改
                        Console.Write("请输入姓名：");
                        string u_name = InputYellow().ToString();
                        for (int i = 0; i < objArrayList.Count; i++)
                        {
                            string [] ustrArray = objArrayList[i].ToString().Split('-');
                            if (ustrArray[0] == u_name)
                            {
                                Console.Write("需要修改的休息如下：");
                                Output("姓名：" + u_name + "电话号码：" + ustrArray[1], "R");
                                Console.Write("请输入电话号码：");
                                string u_mobile = InputYellow().ToString();
                                objArrayList.RemoveAt(i);
                                objArrayList.Add(ustrArray[0]+"-"+u_mobile);
                                Output("修改成功！", "R");
                              

                            }
                            else if (i == objArrayList.Count - 1 && ustrArray[0] != u_name)
                            {
                                Output("没有查到需要的信息，请重新输入：", "R");
                            }
                        }

                        break;
                    #endregion

                    case "A"://添加
                        Console.Write("请输入姓名：");
                        string a_name = InputYellow();
                        Console.Write("请输入手机号:");
                        string a_mobile = InputYellow();
                        objArrayList.Add(a_name + "-" + a_mobile);
                        Output("添加成功", "R");
                        break;
                    case "D"://删除
                        Console.Write("输入要删除的姓名：");
                        string d_name = InputYellow();
                        for (int i = 0; i < objArrayList.Count; i++)
                        {
                            string[] dstrArray = objArrayList[i].ToString().Split('-');
                            if (d_name == dstrArray[0])
                            {
                                Console.Write("查询到的信息如下：");
                                Output("姓名:" + d_name + " 电话号码：" + dstrArray[1], "R");
                                objArrayList.RemoveAt(i);
                                Output("删除成功！", "R");
                            }
                            
                            else if (i == objArrayList.Count - 1 && dstrArray[0] != d_name)
                            {
                                Output("没有查到需要的信息，请重新输入：", "R");
                            }

                        }

                        break;
                    case "C"://清空
                        objArrayList.Clear();
                        Output("内容已清空！", "R");
                        break;
                    case "E"://退出
                        goto End;
                    default:
                        Console.WriteLine("输入的字符无效，请重新输入！");
                        goto RechooseAction;
                }

            }
        End:
            //Console.BackgroundColor = ConsoleColor.Red;
           // Console.WriteLine("程序已退出，按任意键结束！");
            Output("程序已退出，按任意键结束！","R");
            Console.ReadKey();
        }
        static string InputYellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string input = Console.ReadLine().Trim();
            Console.ResetColor();
            return input;
        }
        static void Output(string str, string color)
        {
            switch (color.ToUpper())
            {
                case "R": //红色
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(str);
                    Console.ResetColor();
                    break;
                case "B": //蓝色
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(str);
                    Console.ResetColor();
                    break;
                case "M": //紫色
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(str);
                    Console.ResetColor();
                    break;
                default:
                    Console.WriteLine("选择的颜色参数无效！");
                    break;
            }
        }
    }
}
