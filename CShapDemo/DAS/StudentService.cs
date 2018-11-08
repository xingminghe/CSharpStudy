using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modules;
using System.IO;

namespace DAL
{
   public class StudentService
    {
        public Students GetStudentBySNO(string sno,List<Students> objList)
        {
            Students objStudent = new Students();
            foreach (Students item in objList)
            {
                if (item.SNO.Equals(sno))
                {
                    objStudent = new Students
                    {

                        SNO = item.SNO,
                        Name = item.Name,
                        Gender = item.Gender,
                        Birthday = item.Birthday,
                        Mobile = item.Mobile,
                        Email = item.Email,
                        HomeAddress = item.HomeAddress,
                        PhotoPath = item.PhotoPath,

                    };
                    break;
                }
                
            }
            return objStudent;
        }//根据学号获取某个学生的信息

        public List<Students> GetAllStudentBySNO(string sno, List<Students> objList)
        {
            List<Students> objListQuery = new List<Students>();
            foreach (Students item in objList)
            {
                if (item.SNO.StartsWith(sno))
                {
                    objListQuery.Add(item
                        //new Students
                        //{
                        //    SNO = item.SNO,
                        //    Name = item.Name,
                        //    Gender = item.Gender,
                        //    Birthday = item.Birthday,
                        //    Mobile = item.Mobile,
                        //    Email = item.Email,
                        //    HomeAddress = item.HomeAddress,
                        //    PhotoPath = item.PhotoPath,
                        //}
                    );

                }


            }

            return objListQuery;
        }

        //根据姓名查询
        public List<Students> GetAllStudentByName(string name, List<Students> objList)
        {
            List<Students> objListQuery = new List<Students>();
            foreach (Students item in objList)
            {
                if (item.Name.Contains(name))
                    objListQuery.Add(item);
            }
            return objListQuery;
        }


        public List<Students> GetAllStudentByMobile(string mobile, List<Students> objList)
        {
            List<Students> objListQuery = new List<Students>();
            foreach (Students item in objList)
            {
                if (item.Mobile.Contains(mobile))
                    objListQuery.Add(item);
            }
            return objListQuery;
        }
    }

    
}
