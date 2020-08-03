using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    class FizzBuzz
    {
        public string GetOutput(int a)
        {
            var resultData = "";

            if (a % 3 == 0)
            {
                if (a % 5 == 0)
                    resultData = "FIZZBUZZ";
                else
                    resultData = "FIZZ";
            }
            else if (a % 5 == 0)
            {
                resultData = "BUZZ";
            }
            else
                resultData = $"{ a}";
            return resultData;
        }
    }
}
