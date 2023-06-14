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
        public PracticPage1()
        {
            InitializeComponent();
            AnswerGet();
        }

        /// <summary>
        /// Метод для отображения сохраненных пользовательский ответов
        /// </summary>
        void AnswerGet()
        {
            rb1A.IsChecked = Properties.Settings.Default.rb1A;
            rb1B.IsChecked = Properties.Settings.Default.rb1B;
            rb1V.IsChecked = Properties.Settings.Default.rb1V;

            rb2A.IsChecked = Properties.Settings.Default.rb2A;
            rb2B.IsChecked = Properties.Settings.Default.rb2B;
            rb2V.IsChecked = Properties.Settings.Default.rb2V;
            rb2G.IsChecked = Properties.Settings.Default.rb2G;

            rb3A.IsChecked = Properties.Settings.Default.rb3A;
            rb3B.IsChecked = Properties.Settings.Default.rb3B;
            rb3V.IsChecked = Properties.Settings.Default.rb3V;
            rb3G.IsChecked = Properties.Settings.Default.rb3G;

            rb4A.IsChecked = Properties.Settings.Default.rb4A;
            rb4B.IsChecked = Properties.Settings.Default.rb4B;
            rb4V.IsChecked = Properties.Settings.Default.rb4V;

            rb5A.IsChecked = Properties.Settings.Default.rb5A;
            rb5B.IsChecked = Properties.Settings.Default.rb5B;
            rb5V.IsChecked = Properties.Settings.Default.rb5V;

            rb6A.IsChecked = Properties.Settings.Default.rb6A;
            rb6B.IsChecked = Properties.Settings.Default.rb6B;
            rb6V.IsChecked = Properties.Settings.Default.rb6V;

            rb7A.IsChecked = Properties.Settings.Default.rb7A;
            rb7B.IsChecked = Properties.Settings.Default.rb7B;
            rb7V.IsChecked = Properties.Settings.Default.rb7V;

            rb8A.IsChecked = Properties.Settings.Default.rb8A;
            rb8B.IsChecked = Properties.Settings.Default.rb8B;
            rb8V.IsChecked = Properties.Settings.Default.rb8V;
            rb8G.IsChecked = Properties.Settings.Default.rb8G;

            rb91.IsChecked = Properties.Settings.Default.rb91;
            rb92.IsChecked = Properties.Settings.Default.rb92;
            rb93.IsChecked = Properties.Settings.Default.rb93;
            rb94.IsChecked = Properties.Settings.Default.rb94;
            rb95.IsChecked = Properties.Settings.Default.rb95;

            rb101.IsChecked = Properties.Settings.Default.rb101;
            rb102.IsChecked = Properties.Settings.Default.rb102;
            rb103.IsChecked = Properties.Settings.Default.rb103;
            rb104.IsChecked = Properties.Settings.Default.rb104;
            rb105.IsChecked = Properties.Settings.Default.rb105;
            rb106.IsChecked = Properties.Settings.Default.rb106;

            cb111.IsChecked = Properties.Settings.Default.cb111;
            cb112.IsChecked = Properties.Settings.Default.cb112;
            cb113.IsChecked = Properties.Settings.Default.cb113;
            cb114.IsChecked = Properties.Settings.Default.cb114;
            cb115.IsChecked = Properties.Settings.Default.cb115;
            cb116.IsChecked = Properties.Settings.Default.cb116;

            cb121.IsChecked = Properties.Settings.Default.cb121;
            cb122.IsChecked = Properties.Settings.Default.cb122;
            cb123.IsChecked = Properties.Settings.Default.cb123;
            cb124.IsChecked = Properties.Settings.Default.cb124;
            cb125.IsChecked = Properties.Settings.Default.cb125;

            cb131.IsChecked = Properties.Settings.Default.cb131;
            cb132.IsChecked = Properties.Settings.Default.cb132;
            cb133.IsChecked = Properties.Settings.Default.cb133;
            cb134.IsChecked = Properties.Settings.Default.cb134;
            cb135.IsChecked = Properties.Settings.Default.cb135;

            cb141.IsChecked = Properties.Settings.Default.cb141;
            cb142.IsChecked = Properties.Settings.Default.cb142;
            cb143.IsChecked = Properties.Settings.Default.cb143;
            cb144.IsChecked = Properties.Settings.Default.cb144;
            cb145.IsChecked = Properties.Settings.Default.cb145;

            cb151.IsChecked = Properties.Settings.Default.cb151;
            cb152.IsChecked = Properties.Settings.Default.cb152;
            cb153.IsChecked = Properties.Settings.Default.cb153;
            cb154.IsChecked = Properties.Settings.Default.cb154;
            cb155.IsChecked = Properties.Settings.Default.cb155;

            cb161.IsChecked = Properties.Settings.Default.cb161;
            cb162.IsChecked = Properties.Settings.Default.cb162;
            cb163.IsChecked = Properties.Settings.Default.cb163;
            cb164.IsChecked = Properties.Settings.Default.cb164;
            cb165.IsChecked = Properties.Settings.Default.cb165;
            cb166.IsChecked = Properties.Settings.Default.cb166;
        }

        /// <summary>
        /// Метод для сохранения ответов пользователя
        /// </summary>
        void AnswerSet()
        {
            Properties.Settings.Default.rb1A = (bool)rb1A.IsChecked;
            Properties.Settings.Default.rb1B = (bool)rb1B.IsChecked;
            Properties.Settings.Default.rb1V = (bool)rb1V.IsChecked;

            Properties.Settings.Default.rb2A = (bool)rb2A.IsChecked;
            Properties.Settings.Default.rb2B = (bool)rb2B.IsChecked;
            Properties.Settings.Default.rb2V = (bool)rb2V.IsChecked;
            Properties.Settings.Default.rb2G = (bool)rb2G.IsChecked;

            Properties.Settings.Default.rb3A = (bool)rb3A.IsChecked;
            Properties.Settings.Default.rb3B = (bool)rb3B.IsChecked;
            Properties.Settings.Default.rb3V = (bool)rb3V.IsChecked;
            Properties.Settings.Default.rb3G = (bool)rb3G.IsChecked;

            Properties.Settings.Default.rb4A = (bool)rb4A.IsChecked;
            Properties.Settings.Default.rb4B = (bool)rb4B.IsChecked;
            Properties.Settings.Default.rb4V = (bool)rb4V.IsChecked;

            Properties.Settings.Default.rb5A = (bool)rb5A.IsChecked;
            Properties.Settings.Default.rb5B = (bool)rb5B.IsChecked;
            Properties.Settings.Default.rb5V = (bool)rb5V.IsChecked;

            Properties.Settings.Default.rb6A = (bool)rb6A.IsChecked;
            Properties.Settings.Default.rb6B = (bool)rb6B.IsChecked;
            Properties.Settings.Default.rb6V = (bool)rb6V.IsChecked;

            Properties.Settings.Default.rb7A = (bool)rb7A.IsChecked;
            Properties.Settings.Default.rb7B = (bool)rb7B.IsChecked;
            Properties.Settings.Default.rb7V = (bool)rb7V.IsChecked;

            Properties.Settings.Default.rb8A = (bool)rb8A.IsChecked;
            Properties.Settings.Default.rb8B = (bool)rb8B.IsChecked;
            Properties.Settings.Default.rb8V = (bool)rb8V.IsChecked;
            Properties.Settings.Default.rb8G = (bool)rb8G.IsChecked;

            Properties.Settings.Default.rb91 = (bool)rb91.IsChecked;
            Properties.Settings.Default.rb92 = (bool)rb92.IsChecked;
            Properties.Settings.Default.rb93 = (bool)rb93.IsChecked;
            Properties.Settings.Default.rb94 = (bool)rb94.IsChecked;
            Properties.Settings.Default.rb95 = (bool)rb95.IsChecked;

            Properties.Settings.Default.rb101 = (bool)rb101.IsChecked;
            Properties.Settings.Default.rb102 = (bool)rb102.IsChecked;
            Properties.Settings.Default.rb103 = (bool)rb103.IsChecked;
            Properties.Settings.Default.rb104 = (bool)rb104.IsChecked;
            Properties.Settings.Default.rb105 = (bool)rb105.IsChecked;
            Properties.Settings.Default.rb106 = (bool)rb106.IsChecked;

            Properties.Settings.Default.cb111 = (bool)cb111.IsChecked;
            Properties.Settings.Default.cb112 = (bool)cb112.IsChecked;
            Properties.Settings.Default.cb113 = (bool)cb113.IsChecked;
            Properties.Settings.Default.cb114 = (bool)cb114.IsChecked;
            Properties.Settings.Default.cb115 = (bool)cb115.IsChecked;
            Properties.Settings.Default.cb116 = (bool)cb116.IsChecked;

            Properties.Settings.Default.cb121 = (bool)cb121.IsChecked;
            Properties.Settings.Default.cb122 = (bool)cb122.IsChecked;
            Properties.Settings.Default.cb123 = (bool)cb123.IsChecked;
            Properties.Settings.Default.cb124 = (bool)cb124.IsChecked;
            Properties.Settings.Default.cb125 = (bool)cb125.IsChecked;

            Properties.Settings.Default.cb131 = (bool)cb131.IsChecked;
            Properties.Settings.Default.cb132 = (bool)cb132.IsChecked;
            Properties.Settings.Default.cb133 = (bool)cb133.IsChecked;
            Properties.Settings.Default.cb134 = (bool)cb134.IsChecked;
            Properties.Settings.Default.cb135 = (bool)cb135.IsChecked;

            Properties.Settings.Default.cb141 = (bool)cb141.IsChecked;
            Properties.Settings.Default.cb142 = (bool)cb142.IsChecked;
            Properties.Settings.Default.cb143 = (bool)cb143.IsChecked;
            Properties.Settings.Default.cb144 = (bool)cb144.IsChecked;
            Properties.Settings.Default.cb145 = (bool)cb145.IsChecked;

            Properties.Settings.Default.cb151 = (bool)cb151.IsChecked;
            Properties.Settings.Default.cb152 = (bool)cb152.IsChecked;
            Properties.Settings.Default.cb153 = (bool)cb153.IsChecked;
            Properties.Settings.Default.cb154 = (bool)cb154.IsChecked;
            Properties.Settings.Default.cb155 = (bool)cb155.IsChecked;

            Properties.Settings.Default.cb161 = (bool)cb161.IsChecked;
            Properties.Settings.Default.cb162 = (bool)cb162.IsChecked;
            Properties.Settings.Default.cb163 = (bool)cb163.IsChecked;
            Properties.Settings.Default.cb164 = (bool)cb164.IsChecked;
            Properties.Settings.Default.cb165 = (bool)cb165.IsChecked;
            Properties.Settings.Default.cb166 = (bool)cb165.IsChecked;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            GlobalClass.res -= GlobalClass.lres1; //вычитаем из итогового результата промежуточный
            GlobalClass.lres1 -= GlobalClass.lres1; //обнуляем промежуточный результат

            //подсчитываем быллы (max = 16)
            if (rb1A.IsChecked == true) GlobalClass.lres1++;
            if (rb2V.IsChecked == true) GlobalClass.lres1++;
            if (rb3A.IsChecked == true) GlobalClass.lres1++;
            if (rb4V.IsChecked == true) GlobalClass.lres1++;
            if (rb5V.IsChecked == true) GlobalClass.lres1++;
            if (rb6B.IsChecked == true) GlobalClass.lres1++;
            if (rb7B.IsChecked == true) GlobalClass.lres1++;
            if (rb8V.IsChecked == true) GlobalClass.lres1++;
            if (rb93.IsChecked == true) GlobalClass.lres1++;
            if (rb106.IsChecked == true) GlobalClass.lres1++;

            if (cb111.IsChecked == true) GlobalClass.lres1--;
            if (cb112.IsChecked == true) GlobalClass.lres1++;
            if (cb113.IsChecked == true) GlobalClass.lres1++;
            if (cb114.IsChecked == true) GlobalClass.lres1++;
            if (cb115.IsChecked == true) GlobalClass.lres1--;
            if (cb116.IsChecked == true) GlobalClass.lres1--;


            if (cb121.IsChecked == true) GlobalClass.lres1--;
            if (cb122.IsChecked == true) GlobalClass.lres1++;
            if (cb123.IsChecked == true) GlobalClass.lres1++;
            if (cb124.IsChecked == true) GlobalClass.lres1++;
            if (cb125.IsChecked == true) GlobalClass.lres1++;

            if (cb131.IsChecked == true) GlobalClass.lres1++;
            if (cb132.IsChecked == true) GlobalClass.lres1--;
            if (cb133.IsChecked == true) GlobalClass.lres1--;
            if (cb134.IsChecked == true) GlobalClass.lres1--;
            if (cb135.IsChecked == true) GlobalClass.lres1++;

            if (cb141.IsChecked == true) GlobalClass.lres1++;
            if (cb142.IsChecked == true) GlobalClass.lres1--;
            if (cb143.IsChecked == true) GlobalClass.lres1--;
            if (cb144.IsChecked == true) GlobalClass.lres1++;
            if (cb145.IsChecked == true) GlobalClass.lres1--;

            if (cb151.IsChecked == true) GlobalClass.lres1--;
            if (cb152.IsChecked == true) GlobalClass.lres1--;
            if (cb153.IsChecked == true) GlobalClass.lres1++;
            if (cb154.IsChecked == true) GlobalClass.lres1++;
            if (cb155.IsChecked == true) GlobalClass.lres1++;

            if (cb161.IsChecked == true) GlobalClass.lres1++;
            if (cb162.IsChecked == true) GlobalClass.lres1--;
            if (cb163.IsChecked == true) GlobalClass.lres1--;
            if (cb164.IsChecked == true) GlobalClass.lres1++;
            if (cb165.IsChecked == true) GlobalClass.lres1++;
            if (cb166.IsChecked == true) GlobalClass.lres1--;

            AnswerSet(); //запоминаем ответы
            GlobalClass.res += GlobalClass.lres1;
            FrameClass.MainFrame.Navigate(new PracticPage2());
        }

    }
}
