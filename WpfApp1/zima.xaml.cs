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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для zima.xaml
    /// </summary>
    public partial class zima : Window
    {
        public zima()
        {
            InitializeComponent();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Katalog k1 = new Katalog();
            k1.Show();
            Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            korzina11 korzina11 = new korzina11();
            korzina11.Show();
            Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            korzina11 korzina11 = new korzina11();
            korzina11.Show();
            Hide();
        }
    }
}
