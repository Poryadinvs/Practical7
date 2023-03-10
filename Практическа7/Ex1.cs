using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическа7
{
    internal class Ex1
    {
        static void Swap(ref string a, ref string b)
        {
            var tmp = a;
            a = b;
            b = tmp;
        }

        public void BubleSort()
        {
            Console.WriteLine("Введите количество строк: ");

            int size = int.Parse(Console.ReadLine());

            string[] Str = new string[size];

            for (int i = 0; i < Str.Length; i++)
                Str[i] = Console.ReadLine();


            for(int i =0; i < Str.Length; i++)
            {
                for (int j =0; j < Str.Length -i-1; j++)
                {
                    if (string.Compare(Str[j], Str[j+1])>0)
                        Swap(ref Str[j], ref Str[j + 1]);
                }
            }
            foreach (string t in Str)
                Console.WriteLine(t);
        }
    }
}
