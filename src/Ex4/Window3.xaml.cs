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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window pW = new MainWindow();
            pW.Show();
            this.Close();
        }

        private void CalcButton_Click(object sender, RoutedEventArgs e)
        {
            bool isNum = int.TryParse(NumberBox.Text, out int num);
            if (isNum == false || num<1)
                ResultLabel.Content = "Вы ввели что-то неправильно. Попробуйте ещё раз.";
            else
            {
                int sum = 0;
                for(int i = 1; i <= num; i++)
                {
                    sum += i;
                }
                ResultLabel.Content = sum;
            }
        }
    }
}
