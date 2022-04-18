using System;
using System.Linq;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        KeyValuePair<string, int> Bscore;
        
        if (myList.Count == 0 || myList == null)
            return ("None");

        Bscore = myList.First();
        foreach (KeyValuePair<string, int> element in myList)
        {
            if (element.Value > Bscore.Value)
            {
                Bscore = element;
            }
        }

        return (Bscore.Key);
    }
}