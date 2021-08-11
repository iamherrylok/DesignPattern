using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Home
    {
        public List<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("房子开始装修");
            foreach (var part in parts)
            {
                Console.WriteLine($"组件 {part} 已装好;");
            }
            Console.WriteLine("房子装修完毕");
        }
    }
}
