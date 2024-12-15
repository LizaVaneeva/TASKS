using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый член геометрической прогрессии (p):");
            double numerator;
            while (!double.TryParse(Console.ReadLine(), out numerator))
            {
                Console.WriteLine("Ошибка ввода. Повторите попытку:");
            }

            Console.WriteLine("Введите знаменатель геометрической прогрессии (q):");
            double denominator;
            while (!double.TryParse(Console.ReadLine(), out denominator) || denominator == 0)
            {
                Console.WriteLine("Знаменатель не должен быть равен нулю");
            }

            double p = numerator;
            double q = denominator; 

            double[] geometricProgression = new double[20];
            for (int i = 0; i < geometricProgression.Length; i++)
            {
                geometricProgression[i] = p * Math.Pow(q, i);
            }

            PrintArray(geometricProgression);

            SquareElements(geometricProgression);
            Console.WriteLine("Массив после возведения элементов в квадрат:");
            PrintArray(geometricProgression);

            double geometricMean = CalculateGeometricMean(geometricProgression);
            Console.WriteLine($"Среднее геометрическое элементов массива: {geometricMean:F4}");

            Console.WriteLine("Введите число k для умножения элементов массива:");
            double k;
            while (!double.TryParse(Console.ReadLine(), out k))
            {
                Console.WriteLine("Ошибка ввода. Повторите попытку:");
            }

            double[] multipliedArray = MultiplyArrayByK(geometricProgression, k);
            Console.WriteLine("Результат умножения элементов массива на k:");
            PrintArray(multipliedArray);

            Console.ReadKey();
        }

        static void PrintArray(double[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }

        static void SquareElements(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= array[i]; 
            }
        }

        static double CalculateGeometricMean(double[] array)
        {
            if (array.Length == 0) return 0;

            double product = 1;
            foreach (var element in array)
            {
                product *= element;
            }

            return Math.Pow(product, 1.0 / array.Length);
        }

        static double[] MultiplyArrayByK(double[] array, double k)
        {
            double[] result = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i] * k;
            }

            return result;
        }
    }
}