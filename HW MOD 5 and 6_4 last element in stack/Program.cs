using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_MOD_5_and_6_4_last_element_in_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack myStack = new MyStack();
            myStack.Push(20);
            myStack.Push("Bacon");
            myStack.Push(5);
            myStack.Push("Eggs");
            myStack.Push("Smile");
            myStack.Push("Need Sleep");
            myStack.LastElement();
        }
    }

    public class MyStack: Stack
    {
        /// <summary>
        /// Displays the last element in MyStack.
        /// </summary>        
        public void LastElement()
        {
            Console.WriteLine($"The last element in the Stack is: {Peek()}.");
        }
    }
}
