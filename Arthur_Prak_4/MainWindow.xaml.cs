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
using static System.Collections.Specialized.BitVector32;

namespace Arthur_Prak_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            int action = int.Parse(txtC.Text);
            switch (action)
            {
                case 1:
                    lblNewValues.Content = $"{a} + {b} = {a + b}";
                    break;
                case 2:
                    lblNewValues.Content = $"{a} - {b} = {a - b}";
                    break;
                case 3:
                    lblNewValues.Content = $"{a} * {b} = {a * b}";
                    break;
                case 4:
                    lblNewValues.Content = $"{a} / {b} = {a/b}";
                    break;
                default:
                    lblNewValues.Content = "Неправильный номер действия";
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
