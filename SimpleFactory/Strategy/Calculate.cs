using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Calculate
    {
        MainWindow _mainWindow = null;
        IOperation _operation = null;

        public Calculate(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
        }

        public void SetStragy(string operation)
        {
            switch (operation)
            {
                case "+":
                    _operation = new Add();
                    break;
                case "-":
                    _operation = new Sub();
                    break;
                case "*":
                    _operation = new Mul();
                    break;
                case "/":
                    _operation = new Div();
                    break;
            }
        }

        public void GetResult()
        {
            _operation.GetResult(_mainWindow.num1.Text, _mainWindow.num2.Text, out string result);
            _mainWindow.numResult.Text = result;
        }
    }
}
