using System;

namespace Factorial
{
    class RecursiveFactorial
    {
        static long Factorial(int n)
        {
            if(n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            long factorial = Factorial(n); // function call
            Console.WriteLine("{0}! = {1}", n, factorial);
           
        }
    }
}
