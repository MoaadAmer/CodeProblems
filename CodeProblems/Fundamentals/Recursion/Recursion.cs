using CodeProblems.Fundamentals.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProblems.Fundamentals.Recursion
{
    public class Recursion
    {
        //Runtime: O(n)
        //Space: O(n)
        public int Factorial(int num)
        {
            if (num == 0) return 1;
            else if (num == 1) return 1;
            return num * Factorial(num - 1);
        }
        //Runtime: O(2^n)
        //Space: O(n)
        public int Fibonacci(int num)
        {
            if (num == 0) return 0;
            else if (num == 1) return 1;
            else
            {
                return Fibonacci(num - 1) + Fibonacci(num - 2);
            }
        }

        public void PrintInReverseOrder<T>(SingleNode<T> head)
        {
            if (head == null) return;
            PrintInReverseOrder(head.Next);
            Console.WriteLine(head.Value);
        }
    }
}
