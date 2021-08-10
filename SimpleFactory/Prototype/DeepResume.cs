using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class DeepResume:ICloneable
    {
        private string Name { get; set; }
        private string Sex { get; set; }
        private string Age { get; set; }

        private WorkExperience WorkExperience;

        public DeepResume(string name)
        {
            Name = name;
            WorkExperience = new WorkExperience();
        }

        public void SetPersonalInfo(string sex, string age)
        {
            Sex = sex;
            Age = age;
        }

        public void SetWorkExperience(string timeArea, string company)
        {
            WorkExperience.TimeArea = timeArea;
            WorkExperience.Company = company;
        }

        public void Display()
        {
            Console.WriteLine($"{ Name }  {Age }  {Sex}");
            Console.WriteLine($"{WorkExperience.TimeArea}  :  {WorkExperience.Company}");
        }

        public object Clone()
        {
            return (object)this.MemberwiseClone();
        }
    }
}
