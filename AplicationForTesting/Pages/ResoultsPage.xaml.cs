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
    /// Логика взаимодействия для ResoultsPage.xaml
    /// </summary>
    public partial class ResoultsPage : Page
    {
        public int idUs;
        public int Score;
        public int Results;

        public ResoultsPage()
        {
            InitializeComponent();

            Score += GlobalClass.res;
            idUs = GlobalClass.id;
        }

        /// <summary>
        /// Метод для записи результатов тестирования в базу данных
        /// </summary>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                //объект для записи в БД
                StudentsResulst studentsResulst = new StudentsResulst()
                {
                    UserId = idUs,
                    Scores = Score,
                    Result = Results
                };

                Role role = new Role();
                { 
                    
                }

                BaseClass.EM.StudentsResulst.Add(studentsResulst);
                BaseClass.EM.SaveChanges();
                MessageBox.Show("Данные усепшно добавлены");
            }
            catch
            {
                MessageBox.Show("Возникла ошибка");
            }

        }

        private void tblScore_Loaded(object sender, RoutedEventArgs e)
        {
            TextBlock tb = (TextBlock)sender;

            if (65 <= Score && Score <= 71) //вычисляем оценку
            {
                Results = 5;
            }
            else if (55 <= Score && Score <= 64)
            {
                Results = 4;
            }
            if (46 <= Score && Score <= 54)
            {
                Results = 3;
            }
            else if (Score <= 45)
            {
                Results = 2;
            }

            tb.Text = "Ваша оценка: " + Results;
        }

        private void tblScoreCount_Loaded(object sender, RoutedEventArgs e)
        {
            TextBlock tb = (TextBlock)sender;
            tb.Text = "Количество набранных баллов: " + Score;
        }
    }
}
