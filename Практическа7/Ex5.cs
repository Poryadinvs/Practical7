using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическа7
{
    internal class Ex5
    {
        public void CompareUppAndLow()
        {
            Console.WriteLine("Введиет первую строку: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введиет вторую строку: ");
            string str2 = Console.ReadLine();

            Console.WriteLine($"Сравнивая {str1} и {str2}:");

            bool result1 = String.Compare(str1, str2, true) == 0;
            bool result2 = str1.ToUpper() == str2.ToUpper();
            bool result3 = str1.ToLower() == str2.ToLower();

            Console.WriteLine($"Строки равны, когда они написаны заглавными буквами? {result2}");
            Console.WriteLine($"Строки равны, когда регистр игнорируется? {result3}");
            Console.WriteLine($"Метод Compare эквивалентен использованию ToUpper или ToLower? {result1}");
        }
    }
}
