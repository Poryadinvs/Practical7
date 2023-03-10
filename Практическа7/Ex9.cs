using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическа7
{
    internal class Ex9
    {
        public void StringDefinition()
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            Console.WriteLine("Введите искомую строку: ");
            string substr = Console.ReadLine();

            bool contains = str.Contains(substr);
            if (contains)
            {
                int index = str.IndexOf(substr);
                Console.WriteLine("\"" + substr + "\" в строке \"" + str + "\": правда");
                Console.WriteLine(substr + " начинаются с позиции персонажа " + index);
            }
            else
            {
                Console.WriteLine("\"" + substr + "\" в строке \"" + str + "\": ложь");
            }
        }
    }
}
