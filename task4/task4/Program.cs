using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x");
            var x = double.Parse(Console.ReadLine());

            var y = MyFunction(x);
            Console.WriteLine("f(x) = " + y);

            Console.ReadKey();
        }

        static double MyFunction(double x)
        {
            //throw new NotImplementedException();
            return (x + ((2 + Math.Cos(x)) / (x * x))) / (x + (1 / Math.Sqrt(x * x + 10)));
        }
    }
}
