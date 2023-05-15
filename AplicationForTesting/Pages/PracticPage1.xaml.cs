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
        public int idUs;
        public int res1;
        public PracticPage1()
        {
            InitializeComponent();
        }

        public PracticPage1(Users users) // конструктор для студента
        {
            InitializeComponent();
            idUs = users.UserId;
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

            GlobalClass.res += res1;

            FrameClass.MainFrame.Navigate(new ResoultsPage());
        }

        private void cb_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
