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
using System.Windows.Shapes;

namespace Ex4
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window pW = new MainWindow();
            pW.Show();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CalcButton_Click(object sender, RoutedEventArgs e)
        {
            bool isNum1 = int.TryParse(Num1Box.Text, out int num1);
            bool isNum2 = int.TryParse(Num2Box.Text, out int num2);
            if (isNum1 == false || isNum2 == false || num1 >= num2)
            {
                SumLabel.Content = "Вы ввели что-то неправильно. Попробуйте ещё раз.";
                OddLabel.Content = SumLabel.Content;
            }
            else
            {
                int sum = 0;
                string oddNums = "";
                for (int i = num1 + 1; i < num2; i++)
                {
                    sum += i;
                    if (i % 2 != 0)
                        oddNums += $"{i} ";
                }
                SumLabel.Content = sum;
                OddLabel.Content = oddNums;
            }
        }
    }
}
