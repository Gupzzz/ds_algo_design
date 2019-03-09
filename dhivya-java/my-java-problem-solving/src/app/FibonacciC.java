package app;

public class FibonacciC
{
    public int NthFibonacciValue(int n)
    {
        if (n <= 1)
            return n;
        return (NthFibonacciValue(n - 1) + NthFibonacciValue(n - 2));
    }
}
