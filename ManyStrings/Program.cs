using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
           string welcome = "Welcome to LP1!";
           string example = "Um tab\t e um copyright\u03A9";
           string symbol = "This is a heart ❤";
           Console.WriteLine($"{welcome} \n{example} \n{symbol}");
           int x = 4;
           int y = 6;
           string a_plus_x = "a" + 2;
           string abc_plus_x = "abc" + x;
           string x_plus_y = $"{x} mais {y} e’ igual a {x + y}";
           Console.WriteLine($"{a_plus_x} \n{abc_plus_x} \n{x_plus_y}");

        }
    }
}
