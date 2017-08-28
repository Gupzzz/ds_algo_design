using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursions
{
    class Fibonacci
    {
        public int NthFibonacciValue(int n)
        {
            if (n <= 1)
                return n;
            return (NthFibonacciValue(n - 1) + NthFibonacciValue(n - 2));
        }
    }
}
