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

namespace ZADANIE_3
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
            int num = int.Parse(txtNumber1.Text);
            double val = double.Parse(txtNumber2.Text);
            double a, c, h, S;
            switch (num)
            {
                case 1: // катет a
                    a = val;
                    c = a * Math.Sqrt(2);
                    h = c / 2;
                    S = c * h / 2;
                    lblResult.Content = $"a ={c:N3}\n" +
                                        $"c ={h:N3}\n" +
                                        $"S ={S:N3}";
                    break;
                case 2: // гипотенуза c
                    c = val;
                    a = c / Math.Sqrt(2);
                    h = c / 2;
                    S = c * h / 2;
                    lblResult.Content = $"a ={a:N3}\n" +
                                        $"c ={h:N3}\n" +
                                        $"S ={S:N3}";
                    break;
                case 3: // высота h
                    h = val;
                    c = h * 2;
                    a = c / Math.Sqrt(2);
                    S = c * h / 2;
                    lblResult.Content = $"a ={a:N3}\n" +
                                        $"c ={c:N3}\n" +
                                        $"S ={S:N3}";
                    break;
                case 4: // площадь S
                    S = val;
                    c = Math.Sqrt(S * 2);
                    h = c / 2;
                    a = c / Math.Sqrt(2);
                    lblResult.Content = $"a ={a:N3}\n" +
                                        $"c ={c:N3}\n" +
                                        $"h ={h:N3}";
                    break;
                default:
                    lblResult.Content = "Ошибка";
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
