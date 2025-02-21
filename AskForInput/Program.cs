using System;
using System.Globalization;
namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please write a number (Without decimals):");
            string inteiro = Console.ReadLine();
            int converte_number = int.Parse( inteiro );
            
            Console.WriteLine("Please write another number now (Remember to only use dots when referring to the decimal):");
            string real = Console.ReadLine();
            float converte_realnumber = float.Parse( real );
            float result = converte_number + converte_realnumber;
            
            Console.WriteLine($"Together they equal: {result}");
        }
    }
}
