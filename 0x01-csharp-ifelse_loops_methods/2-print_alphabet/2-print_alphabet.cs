using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = 'a';
            while (letter <= 'z')
            {
                Console.Write("{0}", letter);
                letter++;
            }

        }
    }
}
