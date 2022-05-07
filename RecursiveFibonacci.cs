using System;

namespace Fibonnacci
{
    class RecursiveFibonacci

    {
        static long Fib(int n)
        {
            if(n <= 2)
            {
                return 1;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            long fibonacci = Fib(n);
            Console.WriteLine("The Fibonacci series at " + n + " is " + fibonacci);
           
        }
    }
}
