using System;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Indtast et vilkårligt tal. Indtast 0 hvis du vil stoppe med at indtaste og lægge alle indtastede tal sammen: ");
                string input = Console.ReadLine();
                int.TryParse(input, out int numbers);
                int sum = 0;
                while(input != "0")
                {
                    Console.Write("Indtast et nyt tal: ");
                    input = Console.ReadLine();
                    int.TryParse(input, out numbers);
                    sum += numbers;
                }
                Console.WriteLine($"Tallenes sum er: {sum}");
                Console.ReadLine();
                Console.Clear();
            }            
        }
    }
}
