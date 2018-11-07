using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modules;

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
        }
    }
}
