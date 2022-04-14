using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int amount = 0;

        foreach(KeyValuePair<string, string> mykeys in  myDict)
        {
            amount++;
        }
        return amount;
    }
}
