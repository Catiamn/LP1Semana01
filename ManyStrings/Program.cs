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
        }
    }
}
