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
        public int Score;
        public int Results;

        public ResoultsPage()
        {
            InitializeComponent();

            Score += GlobalClass.res;         
        }

        /// <summary>
        /// Завершение работы программы и сохранение результатов в БД
        /// </summary>
        private void btnEnd_Click(object sender, RoutedEventArgs e)
        {      
            var result = MessageBox.Show("Вы хотели бы посмотреть рейтинг студентов?", "Внимание!", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    //объект для записи в БД
                    StudentsResulst studentsResulst = new StudentsResulst()
                    {
                        UserId = GlobalClass.idUser,
                        Scores = Score,
                        Result = Results,
                        DataTest = DateTime.Today,
                        TestName = GlobalClass.nameTest
                    };

                    BaseClass.EM.StudentsResulst.Add(studentsResulst);
                    BaseClass.EM.SaveChanges();
                    MessageBox.Show("Данные усепшно сохранены");

                    FrameClass.MainFrame.Navigate(new RatingPage());
                }
                catch
                {
                    MessageBox.Show("Возникла ошибка");
                }
            }
            else
            {
                try
                {
                    //объект для записи в БД
                    StudentsResulst studentsResulst = new StudentsResulst()
                    {
                        UserId = GlobalClass.idUser,
                        Scores = Score,
                        Result = Results,
                        DataTest = DateTime.Today,
                        TestName = GlobalClass.nameTest
                    };

                    BaseClass.EM.StudentsResulst.Add(studentsResulst);
                    BaseClass.EM.SaveChanges();
                    MessageBox.Show("Данные усепшно сохранены");

                    FrameClass.MainFrame.Navigate(new RatingPage());
                }
                catch
                {
                    MessageBox.Show("Возникла ошибка");
                }

                FrameClass.MainFrame.Navigate(new AutorizationPage());
            }
        }

        private void tblScore_Loaded(object sender, RoutedEventArgs e)
        {
            TextBlock tb = (TextBlock)sender;

            if (29 <= Score && Score <= 33) //вычисляем оценку
            {
                Results = 5;
            }
            else if (22 <= Score && Score <= 28)
            {
                Results = 4;
            }
            if (15 <= Score && Score <= 21)
            {
                Results = 3;
            }
            else if (Score <= 14)
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
