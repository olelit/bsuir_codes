using System;

namespace SPP2Console
{
    class Program
    {
        //Вывод все информации из таблицы users
        public static void show_info()
        {
            //Создание нового объекта базы данных
            using (SPPLR2Entities context = new SPPLR2Entities())
            {
                var users = context.Users;
                //вывод всех строчек из таблицы в консоль
                foreach ( var line in users)
                {
                    Console.WriteLine(String.Format("ID: {0} | {1} {2} {3}", line.ID,line.Email,line.Username,line.password));
                }
            }
        }
        
        //добавление информации
        public static void add_info(string email, string username , string password)
        {
            using (SPPLR2Entities context = new SPPLR2Entities())
            {
                //создание объекта юзера
                Users user = new Users
                {
                    Email = email,
                    Username = username,
                    password = password,
                };

                //Добавление юзера
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("User table:");
            show_info();

            Console.WriteLine("Данные:");

            Console.WriteLine("Имя:");
            string Username = Console.ReadLine();

            Console.WriteLine("Пароль:");
            string Password = Console.ReadLine();

            Console.WriteLine("Почта:");
            string email = Console.ReadLine();

            add_info(email, Username, Password);

            Console.WriteLine("User table:");
            show_info();

            Console.ReadKey();
        }
    }
}
