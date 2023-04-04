using Microsoft.Win32;
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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для DATA.xaml
    /// </summary>
    public partial class DATA : Page
    {
        AEROFLOT aero = new AEROFLOT();
            public DATA()
        {
            InitializeComponent();
        }

        private void BtnPW4_Click(object sender, RoutedEventArgs e)
        {
            aero.Plane = TxtN.Text;
            aero.AirSpaceShip = Txt;
            LstArray.item.clear();
            LstArray.Items.Add(aero.PrintToScreen());
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == false)
                return;
            aero.SaveToFile(saveFileDialog.FileName);

        }
    }
    }

