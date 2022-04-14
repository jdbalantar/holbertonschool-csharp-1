
using System;
using System.Collections.Generic;
using System.Linq;
class List
{
    public static int Sum(List<int> myList)
    {
        int suma;

        suma = 0;

        HashSet<int> hashset = new HashSet<int>(myList);

        foreach(int element in hashset)
            suma += element;
        return suma;
    }
}