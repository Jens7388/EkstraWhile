using System;

namespace Opgave4
{
    class Program
    {
        private static void ShowTable(int number)
        {
            int table = 0;
            while(table < number * 10)
            {
                table += number;
                Console.Write($"{table}" + " ");
            }
            Console.WriteLine(" ");
        }
        private static void Main()
        {
            Console.WriteLine("Alle tabeller fra 1-9: ");
            ShowTable(1);
            ShowTable(2);
            ShowTable(3);
            ShowTable(4);
            ShowTable(5);
            ShowTable(6);
            ShowTable(7);
            ShowTable(8);
            ShowTable(9);
            Console.ReadLine();
        }
    }
}
