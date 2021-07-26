using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> quotientList = new List<int>();

        for (int x = 0; x < listLength; x++)
        {
            try
            {
                quotientList.Add(list1[x] / list2[x]);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                quotientList.Add(0);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
        }
        return (quotientList);
    }
}
