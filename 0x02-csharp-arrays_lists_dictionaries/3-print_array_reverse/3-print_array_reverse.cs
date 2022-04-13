using System;

class Array
{
    public static void Reverse(int[] array)
    {
        int i;
        if (array.Length == 0 || array == null)
        {
            Console.Write("\n");
        }
        for (i = array.Length -1; i >=0; i--)    
        {
            Console.Write(array[i]);
            if (i > 0)
                Console.Write(" ");
        }
        Console.WriteLine("\n");
    }
}