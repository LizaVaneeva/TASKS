using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;

            if (!TryInputNumber("Введите число a (a < b):", out a) || !TryInputNumber("Введите число b (b > a):", out b))
            {
                Console.ReadKey();
                return;
            }

            if (a >= b)
            {
                Console.WriteLine("Ошибка: a должно быть меньше b.");
                Console.ReadKey();
                return;
            }

            int maxSum = 0;
            int numberWithMaxSum = 0;

            for (int number = a; number <= b; number++)
            {
                int sumOfDivisors = GetSumOfProperDivisors(number);

                if (sumOfDivisors > maxSum)
                {
                    maxSum = sumOfDivisors;
                    numberWithMaxSum = number;
                }
            }

            if (maxSum > 0)
            {
                Console.WriteLine($"Число с наибольшей суммой собственных делителей: {numberWithMaxSum}, сумма: {maxSum}");
            }
            else
            {
                Console.WriteLine("В указанном интервале нет чисел с собственными делителями.");
            }

            Console.ReadKey();
        }

        static int GetSumOfProperDivisors(int number)
        {
            int sum = 0;
            for (int i = 2; i <= number / 2; i++) 
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        static bool TryInputNumber(string message, out int number)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }
            return true;
        }
    }
}
 
