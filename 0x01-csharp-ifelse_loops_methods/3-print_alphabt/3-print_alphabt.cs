using System;

class Program
{
    static void Main(string[] args)
    {
        char abc;
        for (abc = 'a'; abc <= 'z'; abc++)
            if (abc != 'e' && abc != 'q')
                Console.Write(abc);
    }
}