namespace FibonacciSequence.Console;
using System;
using System.Collections.Generic;

static class Program
{
    static void Main(string[] args)
    {
        foreach (var number in FibonacciSequence())
        {
            Console.WriteLine(number);

            if(number > 100)
                break;
        }
    }

    static IEnumerable<int> FibonacciSequence()
    {
        int previous = 0;
        int current = 1;

        yield return previous;
        yield return current;

        while(true)
        {
            int next = previous + current;
            yield return next;

            previous = current;
            current = next;
        }
    }
}
