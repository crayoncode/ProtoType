using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    //集成ICloneable
    public  class Resume:ICloneable
    {
        private string name;
        private string sex;
        private string age;
        private string timeArea;
        private string company;

        public Resume(string name)
        {
            this.name = name;
        }
        //设置个人信息
        public void SetPersonalInfo(string sex, string age)
        {
            this.sex = sex;
            this.age = age;
        }
        //设置工作经历
        public void SetWorkExperience(string timeArea, string company)
        {
            this.timeArea = timeArea;
            this.company = company;
        }

        public void DisPlay()
        {
            Console.WriteLine("{0},{1},{2}",name,sex,age);
            Console.WriteLine("工作经历:{0}{1}",timeArea,company);
        }

        public Object Clone()
        {
            return (Object)this.MemberwiseClone();
        }

    }
}
