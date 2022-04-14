using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {	int[][] jdarray = 
        {
            new int[] { 0, 1, 2, 3 },
            new int[] { 0, 1, 2, 3, 4, 5, 6 },
            new int[] { 0, 1 }
        };
                
		for (int i = 0; i < jdarray.Length; i++)
		{
			for (int j = 0; j < jdarray[i].Length; j++)
			{
				Console.Write("{0}{1}", jdarray[i][j], j == (jdarray[i].Length - 1) ? "" : " ");
                
			}
			Console.WriteLine();
		}
        }
    }
}
