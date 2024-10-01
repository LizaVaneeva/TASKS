using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число n");
            int n;
            if (!TryInputNumber(out n) || n <= 0)
            {
                Console.WriteLine("n должно быть натуральным числом.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите натуральное число k");
            int k;
            if (!TryInputNumber(out k) || k < 0)
            {
                Console.WriteLine("k должно быть неотрицательным целым числом.");
                Console.ReadKey();
                return;
            }

            double sum = 1;
            for (int i = 1; i <= k; i++)
            {
                sum += 1.0 / Math.Pow(n, i);
            }

            Console.WriteLine($"Сумма выражения равна {sum}");
            Console.ReadKey();
        }

        static bool TryInputNumber(out int number)
        {
            number = 0;
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }
            number = n;
            return true;
        }
    }
}

