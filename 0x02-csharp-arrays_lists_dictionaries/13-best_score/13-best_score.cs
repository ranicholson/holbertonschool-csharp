using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        KeyValuePair<string, int> max = new KeyValuePair<string, int>();
        foreach (var kvp in myList)
        {
            if (kvp.Value > max.Value)
                max = kvp;
        }

        if (max.Value == 0)
        {
            return ("None");
        }
        return max.Key;
    }
}
