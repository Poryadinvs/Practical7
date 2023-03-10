using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическа7
{
    internal class Ex2
    {
        public void Under()
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();

            Console.Write("Введите позицию для начала извлечения: ");
            int startPos = int.Parse(Console.ReadLine());

            Console.Write("Введите длину подстроки: ");
            int length = int.Parse(Console.ReadLine());

            string substr = "";

            for (int i = startPos; i < startPos + length && i < str.Length; i++)
            {
                substr += str[i];
            }

            Console.WriteLine("Подстрока, извлекаемая из строки: " + substr);
        }
    }
}
