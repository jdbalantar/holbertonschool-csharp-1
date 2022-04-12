using System;

class Program
{
    static void Main(string[] args)
    {
        int cont;
        for (cont = 0; cont < 99; cont++)
        {
            Console.WriteLine("{0} = 0x{0:x}", cont);
        }
    }
}

