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

            GlobalClass gl = new GlobalClass();
            gl.res += res1;

            FrameClass.MainFrame.Navigate(new ResoultsPage());
        }
    }
}
