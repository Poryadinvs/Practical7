using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическа7
{
    internal class Ex6
    {
        public void compereTwoStrings()
        {
            Console.WriteLine("Введиет первую строку: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введиет вторую строку: ");
            string str2 = Console.ReadLine();

            Console.WriteLine($"Строка 1 {str1}, Строка 2 {str2}");

            int res = String.CompareOrdinal(str1, str2);

            if (res < 0)
                Console.WriteLine($"Строка {str1} мельше, чем строка {str2}");
            else if (res > 0)
                Console.WriteLine($"Строка {str1} больше, чем строка {str2}");
            else
                Console.WriteLine($"Строка {str1} равна строке {str2}");

        }
    }
}
