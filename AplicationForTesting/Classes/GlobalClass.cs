using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationForTesting.Classes
{
    public static class GlobalClass
    {
        public static int id; //роль пользователя в системе
        public static int idUser; //Код пользователя
        public static int res; //итоговое количество баллов
        public static string nameTest; //название теста

        public static int lres1;
        public static int lres2;
        public static int lres3;
        //тут надо создать актуальные переменные для каждого задания и вычитать их при новом заходе на страницу, а потом просто прибавлять снова

    }
}
