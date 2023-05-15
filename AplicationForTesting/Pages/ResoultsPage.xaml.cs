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
        public int Result;
        public ResoultsPage()
        {
            InitializeComponent();
            //Users users;
            //idUs = users.UserId;
            //GlobalClass gl = new GlobalClass();
            //Score += gl.res;
        }

        public ResoultsPage(Users users) // конструктор для студента
        {
            InitializeComponent();

            //GlobalClass gl = new GlobalClass();
            //Score += gl.res;
            //idUs = gl.id;
        }

        /// <summary>
        /// Метод для записи результатов тестирования в базу данных
        /// </summary>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //GlobalClass gl = new GlobalClass();
            //

            //try
            //{
            //    StudentsResulst studentsResulst = new StudentsResulst();
            //    {
            //        UserId = idUs,
            //        Scores = Convert.ToInt32(Score),
            //        Result = Convert.ToInt32(Result)
            //    };

            //    BaseClass.EM.StudentsResulst.Add(studentsResulst);
            //    BaseClass.EM.SaveChanges();
            //    MessageBox.Show("Данные усепшно добавлены");
            //}
            //catch
            //{
            //    MessageBox.Show("Возникла ошибка");
            //}

        }

        private void tblScore_Loaded(object sender, RoutedEventArgs e)
        {
            TextBlock tb = (TextBlock)sender;
            //int index = Convert.ToInt32(tb.Uid);

            if (65 <= Score && Score <= 71) //вычисляем оценку
            {
                Result = 5;
            }
            else if (55 <= Score && Score <= 64)
            {
                Result = 4;
            }
            if (46 <= Score && Score <= 54)
            {
                Result = 3;
            }
            else if (Score <= 45)
            {
                Result = 2;
            }

            tb.Text = "Ваша оценка: " + Result;
        }
    }
}
