using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] twodarray = new int[5,5];
            twodarray [2,2] = 1;
            for (int firstdimension = 0; firstdimension < 5; firstdimension++)
            {
                for (int seconddimension = 0; seconddimension < 5; seconddimension++)
                {
                    if (seconddimension == 4)
                    {
                        Console.WriteLine("0");
                        break;
                    }
                    Console.Write("{0} ", twodarray[firstdimension,seconddimension]);
                }
            }
        }
    }
}
