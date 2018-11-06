using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Common
{
    public static class ValiDataInput
    {
        public static bool IsNumber(string txt)
        {
            Regex objRegex = new Regex(@"^[0-9]*$");//必须是数字
            return objRegex.IsMatch(txt);

        }
        public static bool IsStartWith(string txt)
        {
            
            Regex objRegex = new Regex(@"^[9][5]\d{4}$");//95开头的6位数字
            return objRegex.IsMatch(txt);
            
        }

        public static bool IsChinese(string txt)
        {
            Regex objRegex = new Regex(@"^[\u4e00-\u9fa5]{0,}$");//必须是汉字
            return objRegex.IsMatch(txt);
        }
    }
}
