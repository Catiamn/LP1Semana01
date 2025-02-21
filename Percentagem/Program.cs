using System;
using System.Globalization;
using System.Runtime.ExceptionServices;
namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            ///Small Script to make sure only dots show up and not commas
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;  
            ///Ask use for the 3 codes that are gonna be used          
            Console.WriteLine("Please write 4 numbers between 0 and 1 (Remember to only use dots when referring to the decimal):");
            ///Change number given to float type and to percentage followed by two decimals
            string one = Console.ReadLine(); 
            float realone = float.Parse( one );
            string numberone = $"{realone:p2}";
            Console.WriteLine();
            ///Repeat the process of the first number to the other three numbers necessary
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
            ///Give the user the 4 numbers at the start but in percentage and with two decimals
            Console.WriteLine($"{numberone} \n{numbertwo} \n{numberthree} \n{numberfour}");
        }
    }
}
