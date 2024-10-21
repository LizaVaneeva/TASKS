using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "вертикаль";
            var word1 = s
                .Remove(5, 4)
                .Remove(0, 3) +
                 ReverseString(s.Remove(3, 6).Remove(0, 2));
          

            Console.WriteLine(word1);

            var word2 = s.Remove(7,2).Remove(4,1).Remove(2,1);

            Console.WriteLine(word2);



            Console.ReadKey();
        
        
 
        }
        static string ReverseString(string s) 
        {
            return new string (s.Reverse().ToArray());
        }
    }
}
