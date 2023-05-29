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
    /// Логика взаимодействия для PracticPage2.xaml
    /// </summary>
    public partial class PracticPage2 : Page
    {

        public int res2;
        public PracticPage2()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            //подсчитываем быллы (max = 11)
            if (rb1Y.IsChecked == true) res2++;
            if (rb2N.IsChecked == true) res2++;
            if (rb3N.IsChecked == true) res2++;
            if (rb4Y.IsChecked == true) res2++;
            if (rb5N.IsChecked == true) res2++;
            if (rb6N.IsChecked == true) res2++;
            if (rb7N.IsChecked == true) res2++;
            if (rb8Y.IsChecked == true) res2++;
            if (rb9N.IsChecked == true) res2++;
            if (rb10Y.IsChecked == true) res2++;
            if (rb11Y.IsChecked == true) res2++;

            GlobalClass.res += res2;

            FrameClass.MainFrame.Navigate(new ResoultsPage());
        }
    }
}
