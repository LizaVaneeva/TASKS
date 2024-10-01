using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число:");
            var number = int.Parse(Console.ReadLine());

            if (number >= 100 && number <= 999)
            {
                var units = number % 10;        
                var tenths = (number / 10) % 10; 
                var hundreds = number / 100;      

                var reversedNumber = units * 100 + tenths * 10 + hundreds;

                Console.WriteLine($"Число с измененным порядком цифр: {reversedNumber}");
            }
            else
            {
                Console.WriteLine("Ошибка: Введите корректное трехзначное число.");
            }

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
