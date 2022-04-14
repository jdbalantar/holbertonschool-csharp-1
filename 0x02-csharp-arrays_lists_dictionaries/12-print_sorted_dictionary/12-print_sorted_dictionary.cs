
using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> MyList = new List<string>();
        foreach (KeyValuePair<string, string> pair in myDict)
            MyList.Add(pair.Key.ToString() + ": " + pair.Value.ToString());
        MyList.Sort();
        foreach (string valueDic in MyList)
            System.Console.WriteLine(valueDic);
    }
}