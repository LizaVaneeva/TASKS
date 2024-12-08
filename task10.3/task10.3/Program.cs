using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sum = 0.0;
            var count = 0;
            int number = -1; 

            Console.WriteLine("Для завершения ввода и вычисления среднего арифметического введите 0");

            do
            {
                Console.WriteLine("Введите член последовательности (число должно быть целым и оканчиваться на 0):");

                if (!TryInputNumber(out number))
                {
                    Console.ReadKey();
                    return;
                }

                if (number != 0)
                {
                    sum += number;
                    count++;
                }

            } while (number != 0);

            if (count > 0)
            {
                double average = sum / count;
                Console.WriteLine($"Среднее арифметическое чисел последовательности равно {average}");
            }
            else
            {
                Console.WriteLine("Не было введено ни одного числа.");
            }

            Console.ReadKey();
        }

        static bool TryInputNumber(out int number)
        {
            number = 0;
            if (!int.TryParse(Console.ReadLine(), out int n) || n % 10 != 0) 
            {
                Console.WriteLine("Введено неверное число, число должно быть целым и оканчиваться нулем.");
                return false;
            }
            number = n;
            return true;
        }
    }
}

