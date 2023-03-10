using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическа7
{
    internal class Ex10
    {
        public void TF()
        {
            string[] strings = { "Действия говорят громче, чем слова", "Привет!", "Python.", "PHP.", "random" };
            foreach (string str in strings)
            {
                bool endsWithPeriod = str.EndsWith(".");
                Console.WriteLine("'" + str + "' заканчивается в период: " + endsWithPeriod);
            }
        }
    }
}
