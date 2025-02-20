using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please write a number:");
            string inteiro = Console.ReadLine();
            Console.WriteLine("Please write a real number now:");
            string real = Console.ReadLine();
            converte_number = int.Parse( inteiro );
            converte_realnumber = int.Parse( real );

        }
    }
}
