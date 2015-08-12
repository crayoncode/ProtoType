using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    /// <summary>
    /// 原型模式(浅度复制)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Resume a = new Resume("小明");
            a.SetPersonalInfo("男","23");
            a.SetWorkExperience("2010-2015","XXX公司");
            //a.DisPlay();

            Resume b = (Resume)a.Clone();
            b.SetWorkExperience("1998-2008","YYY企业");

            Resume c = (Resume)a.Clone();
            c.SetPersonalInfo("男", "25");

            a.DisPlay();
            b.DisPlay();
            c.DisPlay();

            Console.ReadKey();
        }
    }
}
