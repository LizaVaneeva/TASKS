using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число:");
            int number;
            if (!int.TryParse(Console.ReadLine(), out number) || number < 1)
            {
                Console.WriteLine("Ошибка ввода, введите натуральное число");
                Console.ReadKey();
                return;
            }

            int smallestDivisor = -1; 
            for (int a = 2; a <= number; a++) 
            {
                if (number % a == 0)
                {
                    smallestDivisor = a; 
                    break; 
                }
            }

            if (smallestDivisor != -1)
            {
                Console.WriteLine($"Наименьший делитель числа {number}, кроме 1: {smallestDivisor}");
            }
            else
            {
                Console.WriteLine("Делителей не найдено.");
            }

            Console.ReadKey();
        }
    }
}
