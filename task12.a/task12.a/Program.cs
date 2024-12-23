using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12.a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число m от 5 до 20");
            int m;
            if (!TryInputNumber(out m))
            {
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите целое число n от 5 до 20");
            int n;
            if (!TryInputNumber(out n))
            {
                Console.ReadKey();
                return;
            }

            if (m < 5 || m > 20 || n < 5 || n > 20)
            {
                Console.WriteLine("Числа не удовлетворяют неравенству 5 <= m,n <= 20");
                Console.ReadKey();
                return;
            }

            var matrix = new int[m, n];
            var rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = rnd.Next(100);

            Console.WriteLine();
            PrintMatrix(matrix);
            Console.WriteLine();

            Console.WriteLine("Введите цифру для поиска чисел, оканчивающихся на эту цифру (от 0 до 9):");
            int digit;
            if (!TryInputNumber(out digit) || digit < 0 || digit > 9)
            {
                Console.WriteLine("Цифра должна быть от 0 до 9.");
                return;
            }

            var found = FindNumberEndingWithDigit(matrix, digit, out int rowIndex, out int colIndex);

            if (found)
                Console.WriteLine($"Найдено число, оканчивающееся на {digit} по индексам: ({rowIndex}, {colIndex})");
            else
                Console.WriteLine($"В массиве нет чисел, оканчивающихся на цифру {digit}.");

            FindMinElementsInRows(matrix);

            Console.ReadKey();
        }

        static bool TryInputNumber(out int number)
        {
            number = 0;
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }
            number = n;
            return true;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j],2} ");
                Console.WriteLine();
            }
        }

        static bool FindNumberEndingWithDigit(int[,] matrix, int digit, out int rowIndex, out int colIndex)
        {
            rowIndex = -1;
            colIndex = -1;

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] % 10 == digit) 
                    {
                        rowIndex = i;
                        colIndex = j;
                        return true;
                    }

            return false; }
        static void FindMinElementsInRows(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int minValue = matrix[i, 0];
                int minIndex = 0;

                for (int j = 1; j < matrix.GetLength(1); j++) 
                {
                    if (matrix[i, j] < minValue)
                    {
                        minValue = matrix[i, j];
                        minIndex = j;
                    }
                }
                Console.WriteLine($"Минимальный элемент в строке {i}: {minValue} (Индекс в строке: {minIndex})"); }
        }
    }
}
   


