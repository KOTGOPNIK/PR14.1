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
using static Class1;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
        }

        private void BtnPW3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPW2_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPW1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPW4_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.frmObj.Navigate(new DATA());
        }
    }
}
