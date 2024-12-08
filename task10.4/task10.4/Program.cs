using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите натуральное число n (все цифры должны быть различными):");
            if (!int.TryParse(Console.ReadLine(), out n) || n < 1)
            {
                Console.WriteLine("Ошибка, введите корректное натуральное число.");
                Console.ReadKey();
                return;
            }

            var digits = new bool[10]; 
            var temp = n;
            int position = 0;
            int maxDigit = -1;
            int minDigit = 10;
            int maxPosition = -1;
            int minPosition = -1;

            int originalNumber = n;

            while (temp > 0)
            {
                position++;
                var digit = temp % 10;

                if (digits[digit])
                {
                    Console.WriteLine("Все цифры должны быть различными.");
                    Console.ReadKey();
                    return;
                }

                digits[digit] = true;
              
                if (digit > maxDigit)
                {
                    maxDigit = digit;
                    maxPosition = position;
                }

                if (digit < minDigit)
                {
                    minDigit = digit;
                    minPosition = position;
                }

                temp /= 10; 
            }
            int digitCount = originalNumber.ToString().Length;
            minPosition = digitCount - minPosition + 1;
            maxPosition = digitCount - maxPosition + 1;

            Console.WriteLine($"Наименьшая цифра: {minDigit}, её порядковый номер: {minPosition}");
            Console.WriteLine($"Наибольшая цифра: {maxDigit}, её порядковый номер: {maxPosition}");
            Console.ReadKey();
        }
    }
}