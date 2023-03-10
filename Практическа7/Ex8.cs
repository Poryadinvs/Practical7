using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическа7
{
    internal class Ex8
    {
        public void StringConcatenation()
        {
            string[] words = { "привет", "добро", "пожаловать", "в", "C#", "Sharp", "для", "создания", "клиентских", "приложений", "Windows" };
            string result = String.Join(" ", words);

            Console.WriteLine(result);
        }
    }
}
