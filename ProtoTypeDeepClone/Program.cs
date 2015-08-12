using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoTypeDeepClone
{
    /// <summary>
    /// 深度复制(浅度复制对于引用类型只是复制了引用)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Resume a = new Resume("小明");
            a.SetPersonalInfo("男", "23");
            a.SetWorkExperience("2010-2015", "XXX公司");

            Resume b = (Resume)a.Clone();
            b.SetWorkExperience("1988-2006","YY企业");

            Resume c = (Resume)a.Clone();
            c.SetWorkExperience("1994-2006", "ZZ公司");

            a.DisPlay();
            b.DisPlay();
            c.DisPlay();

            Console.ReadKey();
            
        }
    }
}
