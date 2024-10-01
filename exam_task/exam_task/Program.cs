using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст на русском языке:");
            var input = Console.ReadLine();
            if (ValidateInput(input))
            {
                CountVowels(input);
            }
        }

        static bool ValidateInput(string text)
        {
            foreach (var element in text)
            {
                if (char.IsLetter(element) && (element >= 'a' && element <= 'z' || element >= 'A' && element <= 'Z'))
                {
                    Console.WriteLine("Используйте только русский алфавит");
                    return false;
                }
            }
            return true;
        }

        static void CountVowels(string text)
        {
            var vowels = new[] { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };
            var vowelCount = new int[vowels.Length];
            var totalVowels = 0;

            for (int i = 0; i < vowelCount.Length; i++)
            {
                vowelCount[i] = 0;
            }

            for (int i = 0; i < text.Length; i++)
            {
                char element = char.ToLower(text[i]);
                bool foundVowel = false;

                for (int j = 0; j < vowels.Length; j++)
                {
                    if (element == vowels[j])
                    {
                        vowelCount[j]++;
                        totalVowels++;
                        foundVowel = true; 
                    }
                }
            }
            Console.WriteLine("Количество гласных:");
            for (int i = 0; i < vowels.Length; i++)
            {
                Console.WriteLine($"{vowels[i]}: {vowelCount[i]}");
            }
            Console.WriteLine($"Всего гласных: {totalVowels}");
        }
    }
}
