using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = CalculateX();
            Console.WriteLine("x = " + Math.Round(x, 3));
            Console.ReadKey();
        }
        static double F(double value)
        { 
            return Math.Sqrt(value);
        }
        static double CalculateX()
        {
            return ((5 + F(5)) / (7 + F(7))) * ((12 + F(12)) / (8 + F(8))) * ((31 + F(31)) / (2 + F(2)));

        }        
    }
}
