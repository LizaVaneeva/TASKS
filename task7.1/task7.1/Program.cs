using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = GetNumber("n");

            if (IsStatementTrue(n))
                Console.WriteLine("Число кратно 2 или 3");
            else
                Console.WriteLine("Число не кратно ни 2, ни 3");

            Console.ReadKey();
        }

        static bool IsStatementTrue(int n)
        {
            return n % 2 == 0 || n % 3 == 0;
        }

        static int GetNumber(string numberName)
        {
            Console.WriteLine($"Введите число {numberName}");
            return int.Parse(Console.ReadLine());
        }
    }
}
