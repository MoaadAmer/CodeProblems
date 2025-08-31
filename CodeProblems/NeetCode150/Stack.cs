namespace CodeProblems.NeetCode150
{
    public class Stack
    {
        //20. Valid Parentheses
        //Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        //Easy
        //An input string is valid if:

        //Open brackets must be closed by the same type of brackets.
        //Open brackets must be closed in the correct order.
        //Every close bracket has a corresponding open bracket of the same type.


        //Example 1:

        //Input: s = "()"

        //Output: true

        //Example 2:

        //Input: s = "()[]{}"

        //Output: true

        //Example 3:

        //Input: s = "(]"

        //Output: false

        //Example 4:

        //Input: s = "([])"

        //Output: true

        //Example 5:

        //Input: s = "([)]"

        //Output: false




        //Constraints:

        //1 <= s.length <= 104
        //s consists of parentheses only '()[]{}'.

        //Solution 
        //Runtime O(N)
        //Space O(N)

        public bool IsValid(string s)
        {
            char[] stack = new char[s.Length];
            int sIndex = -1;
            foreach (char c in s)
            {
                if (c == ')' || c == ']' || c == '}')
                {
                    if (sIndex == -1 ||
                        c == ')' && stack[sIndex] != '(' ||
                        c == ']' && stack[sIndex] != '[' ||
                        c == '}' && stack[sIndex] != '{'
                        )
                    {
                        return false;
                    }
                    else
                    {
                        sIndex--;
                    }
                }
                else
                {
                    stack[++sIndex] = c;
                }
            }
            return sIndex == -1;
        }


        //155. Min Stack
        //Medium
        //Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.
        //Implement the MinStack class:

        //MinStack() initializes the stack object.
        //void push(int val) pushes the element val onto the stack.
        //void pop() removes the element on the top of the stack.
        //int top() gets the top element of the stack.
        //int getMin() retrieves the minimum element in the stack.

        //You must implement a solution with O(1) time complexity for each function.



        //Example 1:

        //Input
        //["MinStack", "push", "push", "push", "getMin", "pop", "top", "getMin"]
        //[[], [-2], [0], [-3], [], [], [], []]

        //Output
        //[null, null, null, null, -3, null, 0, -2]

        //Explanation
        //MinStack minStack = new MinStack();
        //        minStack.push(-2);
        //minStack.push(0);
        //minStack.push(-3);
        //minStack.getMin(); // return -3
        //minStack.pop();
        //minStack.top();    // return 0
        //minStack.getMin(); // return -2


        //Constraints:

        //-231 <= val <= 231 - 1
        //Methods pop, top and getMin operations will always be called on non-empty stacks.
        //At most 3 * 104 calls will be made to push, pop, top, and getMin.

        public class MinStack
        {
            private Node current;
            public MinStack()
            {
            }

            public void Push(int val)
            {
                Node newNode = new Node();
                newNode.Value = val;
                if (current == null)
                {
                    current = newNode;
                    current.MinValue = val;
                }
                else
                {
                    if (val < current.MinValue)
                    {
                        newNode.MinValue = val;
                    }
                    else
                    {
                        newNode.MinValue = current.MinValue;
                    }
                    current.Next = newNode;
                    newNode.Prev = current;
                    current = newNode;
                }
            }

            public void Pop()
            {
                if (current != null)
                {
                    current = current.Prev;
                    if (current != null)
                    {
                        current.Next = null;
                    }
                }
            }

            public int Top()
            {
                if (current != null)
                {
                    return current.Value;
                }
                return 0;
            }

            public int GetMin()
            {
                if (current != null)
                {
                    return current.MinValue;
                }
                return 0;
            }
        }

        public class Node
        {
            public int Value;
            public int MinValue;
            public Node Next;
            public Node Prev;
        }

    }
}
