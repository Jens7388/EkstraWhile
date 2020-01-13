using System;

namespace Opgave3
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Indtast et tal, og se dets tabel: ");
                string input = Console.ReadLine();
                int.TryParse(input, out int number);
                int table = 0;
                while(table < number * 10)
                {
                    table += number;
                    Console.Write($"{table}" + " ");
                }
                Console.ReadLine();
                Console.Clear();
            }
            
        }
    }
}
