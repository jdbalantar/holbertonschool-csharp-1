using System;

class _12_fizzbuzz
{
    static void Main(string[] args)
    {
        int number;

        for (number = 1; number <= 100; number ++)
        {
            if (number % 3 == 0 && number % 5 == 0)
                Console.Write("FizzBuzz");
            else if (number % 3 == 0)
                Console.Write("Fizz");
            else if (number % 5 == 0)
                Console.Write("Buzz");
            else
                Console.Write("{0}", number);
            if (number <= 99)
                Console.Write(" ");
            else
                Console.Write("\n");
        }
    }
}

