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
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {
        public int r;
        public AutorizationPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод для проверки введенных пользователем данных и переправляющий пользователей в зависимости от их ролей
        /// </summary>
        private void btnAutorization_Click(object sender, RoutedEventArgs e)
        {
            
            

            if (tbLogin.Text == "" || tbLogin.Text == " " && tbPassword.Text == "" || tbPassword.Text == " ") //проверка на нулевое значение
            {
                MessageBox.Show("Ошибка ввода");
            }

            Users users = BaseClass.EM.Users.FirstOrDefault(x => x.UserLogin == tbLogin.Text && x.UserPassword == tbPassword.Text);

            if (users == null) // эта штука работает, если даже пустые значения ввести
            { 
                MessageBox.Show("Проверьте введенные данные", "Пользователь не найден!", MessageBoxButton.OK); 
            }

            if (users != null)
            {

                switch (users.RoleId) //проверка на роль, если пользоваетль найден
                {
                    case 1: //Студент
                        MessageBox.Show("Добро пожаловать!");
                        r = 1;
                        FrameClass.MainFrame.Navigate(new PracticPage1(users));
                        break;
                    case 2: //Преподаватель
                        MessageBox.Show("Добро пожаловать!");
                        r = 2;
                        FrameClass.MainFrame.Navigate(new RatingPage(users));
                        break;
                }

                GlobalClass gl = new GlobalClass();
                gl.id = r;
            }
        }

        private void btnRegistration_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.MainFrame.Navigate(new RegistrationPage());
        }

        /// <summary>
        /// Очистка полей при нажатии на них
        /// </summary>
        private void TexBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbLogin.Text == "Логин" || tbPassword.Text == "Пароль")
            {
                TextBox tb = (TextBox)sender;
                tb.Text = string.Empty;
                tb.GotFocus -= TexBox_GotFocus;
            }
        }
    }
}
