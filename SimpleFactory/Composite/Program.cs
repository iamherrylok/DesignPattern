using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {

        /// <summary>
        /// 树模型就是组合模式很好的解释
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Composite root = new Composite("Root");
            root.Add(new Composite("subRoot1"));
            root.Add(new Composite("subRoot2"));

            Composite lok = new Composite("lok");
            lok.Add(new Leaf("lokk"));
            lok.Add(new Leaf("lokkk"));

            root.Add(lok);

        }
    }
}
