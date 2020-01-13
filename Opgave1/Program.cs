using System;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Indtast et tal, og se alle tal der er mindre:");
                string numberInput = Console.ReadLine();
                int.TryParse(numberInput, out int number);
                int numberRow = 0;
                while(numberRow <= number)
                {
                    Console.WriteLine(numberRow);
                    numberRow++;
                }
                Console.ReadLine();
            }
        }
    }
}
