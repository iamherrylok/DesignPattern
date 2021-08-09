using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Strategy
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public string _calOperation = string.Empty;
        Calculate Calculate = null;

        public MainWindow()
        {
            InitializeComponent();
            Calculate = new Calculate(this);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            _calOperation = operation.Text= "+";
            
        }

        private void Sub_Click(object sender, RoutedEventArgs e)
        {
            _calOperation = operation.Text = "-";
        }

        private void Mul_Click(object sender, RoutedEventArgs e)
        {
            _calOperation = operation.Text = "*";
        }

        private void Div_Click(object sender, RoutedEventArgs e)
        {
            _calOperation = operation.Text = "/";
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            Calculate.SetStragy(_calOperation);
            Calculate.GetResult();
        }
    }
}
