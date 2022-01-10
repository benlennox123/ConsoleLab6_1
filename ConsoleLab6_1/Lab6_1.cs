using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab6_1
{
    class Lab6_1
    {
        static void Main(string[] args)
        {
            string Predlozenie = Console.ReadLine();
            string[] Massiv = Predlozenie.Split();
            int L = 0;
            string slovo = "";
            foreach (string s in Massiv)
            {
                if (s.Length>L)
                {
                    L = s.Length;
                    slovo = s;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Самое большое слово \"{0}\"\nего длина {1} букв", slovo, L);
            Console.ReadKey();
        }
    }
}
