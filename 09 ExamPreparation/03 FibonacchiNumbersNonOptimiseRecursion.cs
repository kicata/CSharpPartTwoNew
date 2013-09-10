using System;
class RecursiveFibonacci
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        long result = Fib(n);
        Console.WriteLine("fib({0}) = {1}", n, result);
    }
    static long Fib(int n)
    {
        if (n <= 2)
        {
            return 1;
        }
        return Fib(n - 1) + Fib(n - 2);
    }
}