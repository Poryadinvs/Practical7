using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическа7
{
    internal class Ex4
    {
        public void substringBeforeSub()
        {
            Console.WriteLine("Введите исходную строку: ");
            string str = Console.ReadLine();

            Console.WriteLine("Введите строку для поиска: ");
            string searchStr = Console.ReadLine();

            Console.WriteLine("Введите строку для вставки: ");
            string insertStr = Console.ReadLine();

            int index = str.IndexOf(searchStr);
            if (index == -1)
            {
                Console.WriteLine($"Строка {searchStr} не найдена");
            }
            else
            {
                string resultStr = str.Insert(index, insertStr);
                Console.WriteLine($"Измененная строка: {resultStr} ");


            }
        }
    }
}
