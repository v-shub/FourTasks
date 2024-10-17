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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
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
            bool isNumSalary = double.TryParse(SalaryBox.Text, out double salary);
            bool isNumPeriod = int.TryParse(PeriodBox.Text, out int period);
            double mult;
            if (isNumSalary == false || isNumPeriod == false || salary<0 || period<0 || period>100)
                ResultLabel.Content = "Вы ввели что-то неправильно. Попробуйте ещё раз.";
            else
            {
                if (period < 5)
                    mult = 1.1;
                else if (period < 10)
                    mult = 1.15;
                else if (period < 15)
                    mult = 1.25;
                else if (period < 20)
                    mult = 1.35;
                else if (period < 25)
                    mult = 1.45;
                else
                    mult = 1.5;
                ResultLabel.Content = salary * mult;
            }
        }
    }
}
