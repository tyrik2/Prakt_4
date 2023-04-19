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

namespace ZADANIE_6
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
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(txtNumber1.Text);
            bool Popa = false;
            while (n>0)
            {
                int digit = n % 10;//posled number
                if (digit%2==1)//esli nechet
                {
                    Popa= true;
                    break;
                }
                n /= 10;//-poled number
            }
            lblResult.Content = $"{Popa}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
