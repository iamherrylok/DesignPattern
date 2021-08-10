using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Student1 student1 = new Student1();
            student1.Question1();
            student1.Question2();
            student1.Question3();

            Console.ReadKey();
        }
    }
}
