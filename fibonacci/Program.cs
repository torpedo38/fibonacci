using System;

class Program
{
    static void Main()
    {
        long[] fibonacciNumbers = GenerateFibonacciNumbers(90);
        long fib = 1000000;
        long tracker = 0;
        long[] array = new long[fibonacciNumbers.Length];
        int test = 0;

        for (int i = 0; i < 90; i++)
        {
            if (tracker + fibonacciNumbers[i] > fib)
            {
                tracker = tracker + fibonacciNumbers[i - 1];
                array[test] = fibonacciNumbers[i - 1];
                test++;
                i = 0;
            }
            else if (tracker + fibonacciNumbers[i] == fib)
            {
                array[test] = fibonacciNumbers[i];
                for (int j = 0; j < array.Length; j++)
                {
                    i = 100;
                    if (array[j] != 0)
                    {
                        Console.WriteLine(array[j]);
                    }
                }
            }
        }
    }

    static long[] GenerateFibonacciNumbers(int count)
    {
        long[] fibonacciNumbers = new long[count];

        if (count >= 1)
            fibonacciNumbers[0] = 0;

        if (count >= 2)
            fibonacciNumbers[1] = 1;

        for (int i = 2; i < count; i++)
        {
            fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
        }

        return fibonacciNumbers;
    }


}
