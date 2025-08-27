using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProblems.Fundamentals.Recursion
{
    public class Recursion
    {
        public int Factorial(int num)
        {
            if (num == 0) return 1;
            else if (num == 1) return 1;
            return num * Factorial(num - 1);
        }

        public int Fibonacci(int num)
        {
            if (num == 0) return 0;
            else if (num == 1) return 1;
            else
            {
                return Fibonacci(num - 1) + Fibonacci(num - 2);
            }
        }
    }
}
