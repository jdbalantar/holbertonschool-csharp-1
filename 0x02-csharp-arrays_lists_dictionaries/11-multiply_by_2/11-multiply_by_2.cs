using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> MynewDict = new Dictionary<string, int>();

        if (myDict != null)
        {
            foreach (KeyValuePair<string, int> elelemts in myDict)
            {
                MynewDict.Add(elelemts.Key, elelemts.Value * 2);
            }
        }
        return MynewDict;

    }
}