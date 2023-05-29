using AplicationForTesting.Classes;
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

namespace AplicationForTesting.Pages
{
    /// <summary>
    /// Логика взаимодействия для PracticPage1.xaml
    /// </summary>
    public partial class PracticPage1 : Page
    {
        public int res1;
        public PracticPage1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {

            //подсчитываем быллы (max = 16)
            if (rb1A.IsChecked == true) res1++;
            if (rb2V.IsChecked == true) res1++;
            if (rb3A.IsChecked == true) res1++;
            if (rb4V.IsChecked == true) res1++;
            if (rb5V.IsChecked == true) res1++;
            if (rb6B.IsChecked == true) res1++;
            if (rb7B.IsChecked == true) res1++;
            if (rb8V.IsChecked == true) res1++;
            if (rb93.IsChecked == true) res1++;
            if (rb106.IsChecked == true) res1++;

            if (cb111.IsChecked == true) res1--;
            if (cb112.IsChecked == true) res1++;
            if (cb113.IsChecked == true) res1++;
            if (cb114.IsChecked == true) res1++;
            if (cb115.IsChecked == true) res1--;
            if (cb116.IsChecked == true) res1--;


            if (cb121.IsChecked == true) res1--;
            if (cb122.IsChecked == true) res1++;
            if (cb123.IsChecked == true) res1++;
            if (cb124.IsChecked == true) res1++;
            if (cb125.IsChecked == true) res1++;

            if (cb131.IsChecked == true) res1++;
            if (cb132.IsChecked == true) res1--;
            if (cb133.IsChecked == true) res1--;
            if (cb134.IsChecked == true) res1--;
            if (cb135.IsChecked == true) res1++;

            if (cb141.IsChecked == true) res1++;
            if (cb142.IsChecked == true) res1--;
            if (cb143.IsChecked == true) res1--;
            if (cb144.IsChecked == true) res1++;
            if (cb145.IsChecked == true) res1--;

            if (cb151.IsChecked == true) res1--;
            if (cb152.IsChecked == true) res1--;
            if (cb153.IsChecked == true) res1++;
            if (cb154.IsChecked == true) res1++;
            if (cb155.IsChecked == true) res1++;

            if (cb161.IsChecked == true) res1++;
            if (cb162.IsChecked == true) res1--;
            if (cb163.IsChecked == true) res1--;
            if (cb164.IsChecked == true) res1++;
            if (cb165.IsChecked == true) res1++;
            if (cb166.IsChecked == true) res1--;

            GlobalClass.res += res1;

            FrameClass.MainFrame.Navigate(new PracticPage2());
        }

    }
}
