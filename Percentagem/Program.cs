using System;
using System.Globalization;
using System.Runtime.ExceptionServices;
namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;            
            Console.WriteLine("Please write 4 numbers between 0 and 1 (Remember to only use dots when referring to the decimal):");
            string one = Console.ReadLine();
            float realone = float.Parse( one );
            string numberone = $"{realone:p2}";
            Console.WriteLine();
            string two = Console.ReadLine();
            float realtwo = float.Parse( two );
            string numbertwo = $"{realtwo:p2}";
            Console.WriteLine();
            string three = Console.ReadLine();
            float realthree = float.Parse( three );
            string numberthree = $"{realthree:p2}";
            Console.WriteLine();
            string four = Console.ReadLine();
            float realfour = float.Parse( four );
            string numberfour = $"{realfour:p2}";
            Console.WriteLine($"{numberone} \n{numbertwo} \n{numberthree} \n{numberfour}");
        }
    }
}
