using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел в последовательности");
            int n;
            if (!TryInputNumber(out n) || n <= 0)
            {
                Console.WriteLine("n должно быть положительным целым числом.");
                Console.ReadKey();
                return;
            }

            double result = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Введите число a{i}:");
                double number;
                if (!TryInputDouble(out number))
                {
                    Console.WriteLine("Ошибка ввода.");
                    Console.ReadKey();
                    return;
                }

                if (i % 2 == 0) 
                {
                    result -= number;
                }
                else 
                {
                    result += number;
                }
            }
            result *= (n % 2 == 0) ? 1 : -1;

            Console.WriteLine($"Результат выражения: {result}");
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

        static bool TryInputDouble(out double number)
        {
            number = 0.0;
            if (!double.TryParse(Console.ReadLine(), out double n))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }
            number = n;
            return true;
        }
    }
}