using System;

namespace Fizz_Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int integer = 1; integer <= 100; integer++)  {
            
            if (integer % 3==0) {
            Console.WriteLine("Fizz"); }

            if (integer % 5==0) {
            Console.WriteLine("Buzz"); }

            if (integer % 15==0) {
            Console.WriteLine("Fizzbuzz"); }
            
            else {Console.WriteLine(integer);}

            } 
        }
    }
}
