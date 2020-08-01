using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    class FizzBuzz
    {
        public FizzBuzz(int a)
        {
            if (a % 3 == 0)
            {
                if (a % 5 == 0)
                    Console.WriteLine("FIZZBUZZ");
                else
                    Console.WriteLine("FIZZ");
            }
            else if (a % 5 == 0)
            {
                Console.WriteLine("BUZZ");
            }
            else
                Console.WriteLine(a);
        }
    }
}
