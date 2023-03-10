using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическа7
{
    internal class Ex7
    {
        public void CompareNowAndOther()
        {

            Console.WriteLine("Введите первую строку: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите первую строку: ");
            string str2 = Console.ReadLine();

            int result = String.Compare(str1, str2);

            if (result == 0)
            {
                Console.WriteLine("Строки находятся в одной и той же позиции в порядке сортировки.");
            }
            else if (result < 0)
            {
                Console.WriteLine("Первая строка следует за второй в порядке сортировки.");
            }
            else
            {
                Console.WriteLine("Первая строка предшествует второй в порядке сортировки.");
            }
        }
    }
}
