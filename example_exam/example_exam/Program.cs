using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое значение (true или false):");
            bool firstValue = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе значение (true или false):");
            bool secondValue = bool.Parse(Console.ReadLine());

            bool andResult = firstValue && secondValue;
            bool orResult = firstValue || secondValue;

            Console.WriteLine($"Результат логического И (AND): {andResult}");
            Console.WriteLine($"Результат логического ИЛИ (OR): {orResult}");
          
        }
    }
}
