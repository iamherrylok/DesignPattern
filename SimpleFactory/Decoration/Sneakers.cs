using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoration
{
    class Sneakers:Finery
    {
        public override void Show()
        {
            base.Show();
            Console.WriteLine("穿鞋子");
        }
    }
}
