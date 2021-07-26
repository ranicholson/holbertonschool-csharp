using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int numToPrint = 0;
        int numPrinted = 0;
        try
        {
            numToPrint = myList[n];
            numToPrint = n - 1;
        }
        catch (Exception)
        {
            numToPrint = myList.Count - 1;
        }
        finally
        {
            for (; numPrinted <= numToPrint; numPrinted++)
            {
                Console.WriteLine(myList[numPrinted]);
            }
        }
        return (numPrinted);
    }
}
