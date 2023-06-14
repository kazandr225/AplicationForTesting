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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод для регистрации пользователей и проверки введенных данных
        /// </summary>
        private void btnRegistranion_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                //Проверка на логин. Если введенный логин будет соответствовать уже существующему, то выведется соответстввующее сообщение
                var regUser = BaseClass.EM.Users.FirstOrDefault(x => x.UserLogin == tbLogin.Text);
                if (regUser != null)
                {
                    MessageBox.Show("Пожалуйста, придумайте другой логин", "Этот логин занят!");
                }
                else
                {
                    //объект для записей в БД
                    Users usersTable = new Users()
                    {
                        UserSurname = tbSurname.Text,
                        UserName = tbName.Text,
                        UserPatronymic = tbPatronymic.Text,

                        UserLogin = tbLogin.Text,
                        UserPassword = tbPassword.Text,

                        RoleId = 1
                    };
                    BaseClass.EM.Users.Add(usersTable);
                    BaseClass.EM.SaveChanges();
                    MessageBox.Show("Вы зарегистрировались!", "Регистрация прошла успешно");
                    FrameClass.MainFrame.Navigate(new AutorizationPage());
                }   
            }

            catch
            {
                MessageBox.Show("Что-то пошло не так!", "Проверьте правильность введенных данных", MessageBoxButton.OK, MessageBoxImage.Warning);            
            }

        }

        /// <summary>
        /// Назад на начальную страницу
        /// </summary>
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.MainFrame.Navigate(new AutorizationPage());
        }

        /// <summary>
        /// Очистка полей при нажатии на них
        /// </summary>
        private void TexBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbSurname.Text == "Фамилия" || tbName.Text == "Имя" || tbPatronymic.Text == "Отчество" || tbLogin.Text == "Логин" || tbPassword.Text == "Пароль")
            {
                TextBox tb = (TextBox)sender;
                tb.Text = string.Empty;
                tb.GotFocus -= TexBox_GotFocus;
            }

        }
    }
}
