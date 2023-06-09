﻿using AplicationForTesting.Classes;
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
    /// Логика взаимодействия для PracticPage3.xaml
    /// </summary>
    public partial class PracticPage3 : Page
    {
        public PracticPage3()
        {
            InitializeComponent();
            AnswerGet();
        }

        /// <summary>
        /// Метод для отображения сохраненных пользовательский ответов
        /// </summary>
        void AnswerGet()
        {
            cb3A.SelectedIndex = Properties.Settings.Default.cb3A;
            cb3B.SelectedIndex = Properties.Settings.Default.cb3B;
            cb3V.SelectedIndex = Properties.Settings.Default.cb3V;
            cb3G.SelectedIndex = Properties.Settings.Default.cb3G;
            cb3D.SelectedIndex = Properties.Settings.Default.cb3D;
            cb3E.SelectedIndex = Properties.Settings.Default.cb3E;
        }

        /// <summary>
        /// Метод для сохранения ответов пользователя
        /// </summary>
        void AnswerSet()
        {
            Properties.Settings.Default.cb3A = cb3A.SelectedIndex;
            Properties.Settings.Default.cb3B = cb3B.SelectedIndex;
            Properties.Settings.Default.cb3V = cb3V.SelectedIndex;
            Properties.Settings.Default.cb3G = cb3G.SelectedIndex;
            Properties.Settings.Default.cb3D = cb3D.SelectedIndex;
            Properties.Settings.Default.cb3E = cb3E.SelectedIndex;
        }

            private void btnEndTest_Click(object sender, RoutedEventArgs e)
        {
            GlobalClass.res -= GlobalClass.lres3; //вычитаем из итогового результата промежуточный
            GlobalClass.lres3 -= GlobalClass.lres3; //обнуляем промежуточный результат

            //gодсчет баллов (max = 6)
            if (cb3A.SelectedIndex == 3) GlobalClass.lres3++;
            if (cb3B.SelectedIndex == 2) GlobalClass.lres3++;
            if (cb3V.SelectedIndex == 1) GlobalClass.lres3++;
            if (cb3G.SelectedIndex == 0) GlobalClass.lres3++;
            if (cb3D.SelectedIndex == 6) GlobalClass.lres3++;
            if (cb3E.SelectedIndex == 8) GlobalClass.lres3++;

            AnswerSet(); //запоминаем ответы пользователя
            GlobalClass.res += GlobalClass.lres3;
            FrameClass.MainFrame.Navigate(new ResoultsPage());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            AnswerSet(); //запоминаем ответы пользователя
            GlobalClass.lres3 -= GlobalClass.lres3; //обнуляем промежуточный результат
            FrameClass.MainFrame.Navigate(new PracticPage2());
        }

    }
}
