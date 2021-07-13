using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int first = 0; first < 10; first++)
            {
                for (int second = first + 1; second < 10; second++)
                {
                    if (first == 8 && second == 9)
                    {
                        Console.WriteLine("89");
                        break;
                    }
                    Console.Write("{0}{1}, ", first, second);
                }
            }
        }
    }
}
