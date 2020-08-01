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
            try
            {
            Console.WriteLine("Podaj liczbę:");
            var userNumber = GetData();
            
            var FizzBuzz = new FizzBuzz(userNumber);
            FizzBuzz.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static int GetData()
        {
            if (!int.TryParse(Console.ReadLine(), out int data))
            {
                throw new Exception("Podana wartość jest nieprawidłowa.");
            }
            return data;
        }
    }
}
