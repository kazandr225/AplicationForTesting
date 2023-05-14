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
        Users user;
        public ResoultsPage()
        {
            InitializeComponent();
        }

        public ResoultsPage(Users users) //конструктор для пользователей
        {
            InitializeComponent();

            if (users.RoleID == 1) //скрываем элементы в зависимости от роли пользователя
            {
                //скрыть элементы фильтрации, поиска и сортировки для студента, оставив лишь общий список
            }
            else
            {
                SortingAndFiltration();
            }
            user = users;
        }

        /// <summary>
        /// Метод для сортировки и фильтрации студентов
        /// </summary>
        public void SortingAndFiltration()
        { 
        
        }

        //не забыть про частичные свойства, они будут помечать студектов по оценке определенным цветом, потом будет формироваться диаграммы по оценкам и такому цвету?
    }
}
