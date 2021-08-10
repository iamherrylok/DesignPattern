using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class FinalDeepResume : ICloneable
    {
        private string Name { get; set; }
        private string Sex { get; set; }
        private string Age { get; set; }

        private FinalWorkExperience _finalWorkExperience;

        public FinalDeepResume(string name)
        {
            Name = name;
            _finalWorkExperience = new FinalWorkExperience();
        }

        private FinalDeepResume(FinalWorkExperience finalWorkExperience)
        {
            this._finalWorkExperience = (FinalWorkExperience)finalWorkExperience.Clone();
        }

        public void SetPersonalInfo(string sex, string age)
        {
            Sex = sex;
            Age = age;
        }

        public void SetWorkExperience(string timeArea, string company)
        {
            _finalWorkExperience.TimeArea = timeArea;
            _finalWorkExperience.Company = company;
        }

        public void Display()
        {
            Console.WriteLine($"{ Name }  {Age }  {Sex}");
            Console.WriteLine($"{_finalWorkExperience.TimeArea}  :  {_finalWorkExperience.Company}");
        }
        public object Clone()
        {
            FinalDeepResume finalDeep = new FinalDeepResume(_finalWorkExperience);
            finalDeep.Name = this.Name;
            finalDeep.Sex = this.Sex;
            finalDeep.Age = this.Age;
            return finalDeep;
        }
    }
}
