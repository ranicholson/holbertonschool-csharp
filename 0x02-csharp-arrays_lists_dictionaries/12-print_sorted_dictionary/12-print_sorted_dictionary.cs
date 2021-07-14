using System;
using System.Collections.Generic;

    class Dictionary
    {
        public static void PrintSorted(Dictionary<string, string> myDict)
        {
            SortedList<string, string> keyOrdered = new SortedList<string, string>();
            foreach (string key in myDict.Keys)
            {
                keyOrdered.Add(key, myDict[key]);
            }
            foreach (string key in keyOrdered.Keys)
            {
                Console.WriteLine("{0}: {1}", key, keyOrdered[key]);
            }
        }
    }
