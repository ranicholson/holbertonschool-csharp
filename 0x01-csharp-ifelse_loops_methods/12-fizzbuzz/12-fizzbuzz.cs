using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int count = 1; count <= 100; count++)
            {
                if (count % 3 == 0 && count % 5 == 0)
                {
                        Console.Write("FizzBuzz "); 
                }
                else if (count % 5 == 0)
                {
                    if (count == 100)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.Write("Buzz ");
                    }
                }
                else if (count % 3 == 0)
                {
                    Console.Write("Fizz " );
                }
                else
                {
                    Console.Write("{0} ", count);
                }
            }
        }
    }
}
