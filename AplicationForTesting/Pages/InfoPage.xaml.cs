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
    /// Логика взаимодействия для InfoPage.xaml
    /// </summary>
    public partial class InfoPage : Page
    {
        public InfoPage()
        {
            InitializeComponent();
        }

        private void btnBegin_Click(object sender, RoutedEventArgs e)
        {
            GlobalClass.nameTest = "Конкуренция и рыночные структуры";
            FrameClass.MainFrame.Navigate(new PracticPage1());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Вы точно хотите вернуться на страницу авторизации?", "Внимание!", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes) FrameClass.MainFrame.Navigate(new AutorizationPage());      
        }
    }
}
