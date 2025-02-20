using System;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int number = 12;
            int another = 9;
            int last = 5;
            Console.WriteLine($"{number} \n{another} \n{last}");
            // char type uses 'x' 
            char diamond = '✦'; 
            char heart = '♥';
            char sun = '☀';
            Console.WriteLine($"{diamond} \n{heart} \n{sun}");
            float decimals = 3.4f;
            float decimals2 = 7.14f;
            float decimals3 = 11.7f;
            Console.WriteLine($"{decimals} \n{decimals2} \n{decimals3}");
        }
    }
}
