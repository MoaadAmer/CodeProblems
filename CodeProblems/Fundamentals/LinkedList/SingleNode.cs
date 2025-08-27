using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProblems.Fundamentals.LinkedList
{
    public class SingleNode<T>
    {
        public T Value { get; set; }
        public SingleNode<T>? Next { get; set; }
        public SingleNode(T value, SingleNode<T>? next)
        {
            Value = value;
            Next = next;
        }
    }
}
