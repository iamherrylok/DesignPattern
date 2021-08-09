using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字：");
            string num1Str = Console.ReadLine();
            double num1 = Convert.ToDouble(num1Str);

            Console.WriteLine("请输入第二个数字：");
            string num2Str = Console.ReadLine();
            double num2 = Convert.ToDouble(num2Str);

            Console.WriteLine("请输入操作符号：");
            string operation = Console.ReadLine();

            double result = 0;
            GetCalInstance(operation).Calculate(num1, num2, ref result);
            Console.WriteLine($"答案：{result}");

            Console.ReadKey();
        }


        /// <summary>
        /// 简单工厂方法就是能根据运行时创建相应对象
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Operation GetCalInstance(string str)
        {
            switch (str)
            {
                case "+":
                    return new Add();
                case "-":
                    return new Subtraction();
                case "*":
                    return new Multiplication();
                case "/":
                    return new Division();
                default:
                    return null;
            }
        }

        /// <summary>
        /// 也是简单工厂  
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static IOperation GetCalInstanceFI(string str)
        {
            switch (str)
            {
                case "+":
                    return new AddFI();
                case "-":
                    return new SubFI();
                case "*":
                    return new MulFI();
                case "/":
                    return new DivFI();
                default:
                    return null;
            }
        }


        
    }
}
