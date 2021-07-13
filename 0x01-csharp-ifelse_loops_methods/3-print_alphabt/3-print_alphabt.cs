using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = 'a';
            while (letter <= 'z')
            {
                if (letter == 'e' || letter == 'q')
                {
                    letter++;
                    continue;
                }
                Console.Write("{0}", letter);
                letter++;
            }

        }
    }
}
