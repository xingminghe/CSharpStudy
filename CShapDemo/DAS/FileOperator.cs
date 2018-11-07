using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modules;
using System.IO;

namespace DAL
{
    public class FileOperator
    {
        public List<Students> ReadFile(string fileName)
        {
            List<Students> objList = new List<Students>();
            string Line = string.Empty;
            try
            {
                StreamReader sr = new StreamReader(fileName, Encoding.Default);
                Line = sr.ReadLine();
                while (Line != null)
                {
                    
                    string[] student = Line.Split(',');
                    //传统方法
                    //Students objStudents = new Students();
                    //objStudents.SNO = student[0];
                    //objStudents.Name = student[1];
                    //objStudents.Gender = student[2];
                    //objStudents.Birthday = Convert.ToDateTime(student[3]);
                    //objStudents.Mobile = student[4];
                    //objStudents.Email = student[5];
                    //objStudents.HomeAddress = student[6];
                    //objStudents.PhotoPath = student[7];
                    //objList.Add(objStudents);

                    //推荐方法
                    objList.Add(
                        new Students
                        {
                            SNO = student[0],
                            Name = student[1],
                            Gender = student[2],
                            Birthday = Convert.ToDateTime(student[3]),
                            Mobile = student[4],
                            Email = student[5],
                            HomeAddress = student[6],
                            PhotoPath = student[7]
                        }
                     );
                    Line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objList;
        }
    }
}
