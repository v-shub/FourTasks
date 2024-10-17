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

namespace Ex4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Task1Button_Click(object sender, RoutedEventArgs e)
        {
            Window pW = new Window1();
            pW.Show();
            this.Close();
        }

        private void Task2Button_Click(object sender, RoutedEventArgs e)
        {
            Window pW = new Window2();
            pW.Show();
            this.Close();
        }

        private void Task3Button_Click(object sender, RoutedEventArgs e)
        {
            Window pW = new Window3();
            pW.Show();
            this.Close();
        }

        private void Task4Button_Click(object sender, RoutedEventArgs e)
        {
            Window pW = new Window4();
            pW.Show();
            this.Close();
        }
    }
}
