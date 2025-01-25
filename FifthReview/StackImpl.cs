using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthReview
{
    public class StackImpl
    {
        public int[] stack;
        public int top;

        public StackImpl(int size)
        {
            stack = new int[size];
            top = -1;
        }

        public void Push(int val)
        {
            if(top == stack.Length - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            stack[++top] = val;
            
        }

        public int Pop()
        {
            if(top == -1)
            {
                throw new Exception("Underflow");
            }
            return stack[top--];
        }

        public int Peek()
        {
            if(top == -1)
            {
                throw new Exception("Stack Empty");
            }
            return stack[top];
        }
    }
}
