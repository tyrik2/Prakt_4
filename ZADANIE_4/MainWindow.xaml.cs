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

namespace ZADANIE_4
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
            int K = 0;
            int temp = n;
            while (temp>1)
            {
                temp = temp / 2;
                K++;
            }
            if (Math.Pow(2, K) == n)
            {
                lblResult.Content = $"Это 2 в {K} степени";
            }
            else
                lblResult.Content = $"N-Не степень 2";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
