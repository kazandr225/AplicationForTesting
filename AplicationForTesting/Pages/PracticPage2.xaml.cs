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

        public PracticPage2()
        {
            InitializeComponent();
            AnswerGet();
        }

        /// <summary>
        /// Метод для отображения сохраненных пользовательский ответов
        /// </summary>
        void AnswerGet()
        {
            rb1Y.IsChecked = Properties.Settings.Default.rb1Y;
            rb1N.IsChecked = Properties.Settings.Default.rb1N;

            rb2Y.IsChecked = Properties.Settings.Default.rb2Y;
            rb2N.IsChecked = Properties.Settings.Default.rb2N;

            rb3Y.IsChecked = Properties.Settings.Default.rb3Y;
            rb3N.IsChecked = Properties.Settings.Default.rb3N;

            rb4Y.IsChecked = Properties.Settings.Default.rb4Y;
            rb4N.IsChecked = Properties.Settings.Default.rb4N;

            rb5Y.IsChecked = Properties.Settings.Default.rb5Y;
            rb5N.IsChecked = Properties.Settings.Default.rb5N;

            rb6Y.IsChecked = Properties.Settings.Default.rb6Y;
            rb6N.IsChecked = Properties.Settings.Default.rb6N;

            rb7Y.IsChecked = Properties.Settings.Default.rb7Y;
            rb7N.IsChecked = Properties.Settings.Default.rb7N;

            rb8Y.IsChecked = Properties.Settings.Default.rb8Y;
            rb8N.IsChecked = Properties.Settings.Default.rb8N;

            rb9Y.IsChecked = Properties.Settings.Default.rb9Y;
            rb9N.IsChecked = Properties.Settings.Default.rb9N;

            rb10Y.IsChecked = Properties.Settings.Default.rb10Y;
            rb10N.IsChecked = Properties.Settings.Default.rb10N;

            rb11Y.IsChecked = Properties.Settings.Default.rb11Y;
            rb11N.IsChecked = Properties.Settings.Default.rb11N;
        }

        /// <summary>
        /// Метод для сохранения ответов пользователя
        /// </summary>
        void AnswerSet()
        {
            Properties.Settings.Default.rb1Y = (bool)rb1Y.IsChecked;
            Properties.Settings.Default.rb1N = (bool)rb1N.IsChecked;

            Properties.Settings.Default.rb2Y = (bool)rb2Y.IsChecked;
            Properties.Settings.Default.rb2N = (bool)rb2N.IsChecked;

            Properties.Settings.Default.rb3Y = (bool)rb3Y.IsChecked;
            Properties.Settings.Default.rb3N = (bool)rb3N.IsChecked;

            Properties.Settings.Default.rb4Y = (bool)rb4Y.IsChecked;
            Properties.Settings.Default.rb4N = (bool)rb4N.IsChecked;

            Properties.Settings.Default.rb5Y = (bool)rb5Y.IsChecked;
            Properties.Settings.Default.rb5N = (bool)rb5N.IsChecked;

            Properties.Settings.Default.rb6Y = (bool)rb6Y.IsChecked;
            Properties.Settings.Default.rb6N = (bool)rb6N.IsChecked;

            Properties.Settings.Default.rb7Y = (bool)rb7Y.IsChecked;
            Properties.Settings.Default.rb7N = (bool)rb7N.IsChecked;

            Properties.Settings.Default.rb8Y = (bool)rb8Y.IsChecked;
            Properties.Settings.Default.rb8N = (bool)rb8N.IsChecked;

            Properties.Settings.Default.rb9Y = (bool)rb9Y.IsChecked;
            Properties.Settings.Default.rb9N = (bool)rb9N.IsChecked;

            Properties.Settings.Default.rb10Y = (bool)rb10Y.IsChecked;
            Properties.Settings.Default.rb10N = (bool)rb10N.IsChecked;

            Properties.Settings.Default.rb11Y = (bool)rb11Y.IsChecked;
            Properties.Settings.Default.rb11N = (bool)rb11N.IsChecked;
        }

            private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            GlobalClass.res -= GlobalClass.lres2; //вычитаем из итогового результата промежуточный
            GlobalClass.lres2 -= GlobalClass.lres2; //обнуляем промежуточный результат

            //подсчет баллов (max = 11)
            if (rb1Y.IsChecked == true) GlobalClass.lres2++;
            if (rb2N.IsChecked == true) GlobalClass.lres2++;
            if (rb3N.IsChecked == true) GlobalClass.lres2++;
            if (rb4Y.IsChecked == true) GlobalClass.lres2++;
            if (rb5N.IsChecked == true) GlobalClass.lres2++;
            if (rb6N.IsChecked == true) GlobalClass.lres2++;
            if (rb7N.IsChecked == true) GlobalClass.lres2++;
            if (rb8Y.IsChecked == true) GlobalClass.lres2++;
            if (rb9N.IsChecked == true) GlobalClass.lres2++;
            if (rb10Y.IsChecked == true) GlobalClass.lres2++;
            if (rb11Y.IsChecked == true) GlobalClass.lres2++;

            AnswerSet(); //запоминаем ответы пользователя
            GlobalClass.res += GlobalClass.lres2;
            FrameClass.MainFrame.Navigate(new PracticPage3());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            AnswerSet(); //запоминаем пользователя
            GlobalClass.lres2 -= GlobalClass.lres2; //обнуляем промежуточный результат
            FrameClass.MainFrame.Navigate(new PracticPage1());
        }
    }
}
