using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzer = new FizzBuzzer();
            for (int i = 1; i <= 300; i++)
            {
               Console.WriteLine(fizzBuzzer.FizzBuzz(i));
            }
        }
    }
}
