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
            Console.WriteLine("Please write a number between 0 and 1 (Remember to only use dots when referring to the decimal):");
            string one = Console.ReadLine();
            float realone = float.Parse( one );
            Console.WriteLine("Please write another number between 0 and 1 (Remember to only use dots when referring to the decimal):");
            string two = Console.ReadLine();
            float realrtwo = float.Parse( two );
            Console.WriteLine("Please write another number between 0 and 1 (Remember to only use dots when referring to the decimal):");
            string three = Console.ReadLine();
            float realthree = float.Parse( three );
            Console.WriteLine("Please write another number between 0 and 1 (Remember to only use dots when referring to the decimal):");
            string four = Console.ReadLine();
            float realfour = float.Parse( four );
            Console.WriteLine("Here's all the numbers you picked: \n{realone} \n{realtwo} \n{realthree} \n{realfour}");
        }
    }
}
