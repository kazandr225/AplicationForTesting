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
    /// Логика взаимодействия для RatingPage.xaml
    /// </summary>
    public partial class RatingPage : Page
    {
        List<StudentsResulst> studentsResulsts;
        public RatingPage()
        {
            InitializeComponent();
            SortingAndFiltration();

            if (GlobalClass.id == 1)
            {
                btnClear.Visibility = Visibility.Collapsed;
            }
        }

        /// <summary>
        /// Метод для сортировки и фильтрации студентов
        /// </summary>
        public void SortingAndFiltration()
        {
            studentsResulsts = BaseClass.EM.StudentsResulst.ToList();
            tbFirst.Text = studentsResulsts.Count.ToString();

            if (cbResoult.SelectedIndex != 0) //сортировка
            {
                switch (cbResoult.SelectedIndex)
                {
                    case 1:
                        {
                            studentsResulsts = BaseClass.EM.StudentsResulst.Where(x => x.Result == 2).ToList();
                        }
                        break;
                    case 2:
                        {
                            studentsResulsts = BaseClass.EM.StudentsResulst.Where(x => x.Result == 3).ToList();
                        }
                        break;
                    case 3:
                        {
                            studentsResulsts = BaseClass.EM.StudentsResulst.Where(x => x.Result == 4).ToList();
                        }
                        break;
                    case 4:
                        {
                            studentsResulsts = BaseClass.EM.StudentsResulst.Where(x => x.Result == 5).ToList();
                        }
                        break;
                }
            }
            else if (cbResoult.SelectedIndex != -1)
            {
                studentsResulsts = BaseClass.EM.StudentsResulst.ToList();
            }

            if (cbSort.SelectedIndex != -1) //сортировка по баллам
            {
                if (cbSort.SelectedIndex == 0)
                {
                    studentsResulsts = studentsResulsts.OrderBy(x => x.Scores).ToList();
                }
                else 
                {
                    studentsResulsts = studentsResulsts.OrderByDescending(x => x.Scores).ToList();
                }
            }

            if (!string.IsNullOrWhiteSpace(tbFindStudent.Text)) //поиск студента
            {
                studentsResulsts = studentsResulsts.Where(x => x.Users.UserSurname.ToLower().Contains(tbFindStudent.Text.ToLower())).ToList();
            }

            tbSecond.Text = studentsResulsts.Count.ToString();
            listStudents.ItemsSource = studentsResulsts;
            if (studentsResulsts.Count == 0)
            {
                MessageBox.Show("Нет данных");
            }
        }

        private void cbSort_Changed(object sender, SelectionChangedEventArgs e)
        {
            SortingAndFiltration();
        }

        private void cbResoult_Changed(object sender, SelectionChangedEventArgs e)
        {
            SortingAndFiltration();
        }
        private void tbFindStudent_TextChanged(object sender, TextChangedEventArgs e)
        {
            SortingAndFiltration();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.MainFrame.Navigate(new AutorizationPage());
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            var resaultsRemoving = listStudents.SelectedItems.Cast<StudentsResulst>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {resaultsRemoving.Count()} элементов?", "Внимание!", 
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try 
                {
                    BaseClass.EM.StudentsResulst.RemoveRange(resaultsRemoving);
                    BaseClass.EM.SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    FrameClass.MainFrame.Navigate(new RatingPage());
                }
                catch 
                {
                    MessageBox.Show("Что-то пошло не так!");
                }
            }
        }

    }
}
