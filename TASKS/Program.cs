using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        ConsoleColor originalColor = Console.ForegroundColor;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Виноград");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Не стану я жалеть о розах,");
        Console.WriteLine("Увядших с легкою весной;");
        Console.WriteLine("Мне мил и виноград на лозах,");
        Console.WriteLine("В кистях созревший под горой,");
        Console.WriteLine("Краса моей долины злачной,");
        Console.WriteLine("Отрада осени златой");
        Console.WriteLine("Продолговатый и прозрачный,");
        Console.WriteLine("Как персты девы молодой.");
        Console.ForegroundColor = originalColor;
        Console.WriteLine("Цвет текста возвращен в исходное состояние.");
        Console.ReadKey();
    }
}