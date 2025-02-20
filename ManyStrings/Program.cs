using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
           double xx = 1.23456;
           int ii = 19;
           string xx1 = $"xx={xx:f2}";
           string xx2 = $"xx={xx:p1}";
           string ii1 = $"ii={ii:X}";
           string ii2 = $"ii={ii:C}";
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
           Console.WriteLine($"{xx1} \n{xx2} \n{ii1} \n{ii2}");
        }
    }
}
