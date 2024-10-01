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
        {   Console.Write("Введите радиус круга: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double circumference = 2 * Math.PI * radius;
            double area = Math.PI * Math.Pow(radius, 2);  

            Console.WriteLine($"Длина окружности: {circumference}");
            Console.WriteLine($"Площадь круга: {area}");

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
