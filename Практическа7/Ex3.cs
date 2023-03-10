using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическа7
{
    internal class Ex3
    {
        string Name;
        string pass;
        string Name2;
        string pass2;

        public void CheckUser()
        {
            Console.WriteLine("Регистрация");
            Console.WriteLine("Введите имя пользователя: ");
            Name = Console.ReadLine();
            Console.WriteLine("Введите пароль: ");
            pass = Console.ReadLine();

            do
            {
                Console.WriteLine("Вход");
                Console.WriteLine("Введите имя: ");
                Name2 = Console.ReadLine();
                Console.WriteLine("Введите пароль: ");
                pass2 = Console.ReadLine();

                if (Name == Name2 && pass == pass2)
                    Console.WriteLine("Вход выполнен");
                else
                    Console.WriteLine("Не прависльно выполнен вход: ");
            } while (Name != Name2 || pass != pass2);
        }
    }
}
