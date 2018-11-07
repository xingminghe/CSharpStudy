using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules
{
    /// <summary>
    /// 实体类 学生信息
    /// </summary>
    public class Students
    {
        //学号
        public string SNO { get; set; }
        //姓名
        public string Name { get; set; }
        //性别
        public string Gender { get; set; }
        //出生日期
        public DateTime Birthday { get; set; }
        //手机号码
        public string  Mobile { get; set; }
        //邮箱地址
        public string Email { get; set; }
        //家庭住址
        public string HomeAddress { get; set; }
        //照片
        public string PhotoPath { get; set; }
    }
}
