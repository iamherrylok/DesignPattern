using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Resume : ICloneable
    {
        private string Name { get; set; }
        private string Sex { get; set; }
        private string Age { get; set; }
        private string TimeArea { get; set; }
        private string Company { get; set; }

        public Resume(string name)
        {
            Name = name;
        }

        public void SetPersonalInfo(string sex,string age)
        {
            Sex = sex;
            Age = age;
        }

        public void SetWorkExperience(string timeArea,string company)
        {
            TimeArea = timeArea;
            Company = company;
        }

        public void Display()
        {
            Console.WriteLine($"{ Name }  {Age }  {Sex}");
            Console.WriteLine($"{TimeArea}  :  {Company}");
        }

        public object Clone()
        {
            return (object)this.MemberwiseClone();
        }
    }
}
