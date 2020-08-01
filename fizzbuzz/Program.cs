using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Podaj liczbę:");
                var userNumber = int.Parse(Console.ReadLine());

                if (userNumber % 3 == 0)
                {
                    if (userNumber % 5 == 0)
                        Console.WriteLine("FIZZBUZZ");
                    else
                        Console.WriteLine("FIZZ");
                }
                else if (userNumber % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                else
                    Console.WriteLine(userNumber);
            }
        }
    }
}
