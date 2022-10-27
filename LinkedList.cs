using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackAndQueue
{
    internal class LinkedList
    {
        public Node top;

        //Parameterized constructor to Initializes a new instance of the class
        public LinkedList()
        {
            this.top = null;
        }
        //Pushes the specified value into stack
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine(value);
        }
        // Peak methode return the top element in stack
        internal void Peak()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty");
            }
            Console.WriteLine("\n is in the top of stack = " + this.top.data);
        }
        // Pop methode remove and return the top element
        internal void POP()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty \n deletion is not possible");
            }
            Console.WriteLine("\n POP out elememnt is = " + this.top.data);
            this.top = this.top.next;
        }
        // Determines whether this stack is empty or not
        internal void IsEmpty()
        {
            while (this.top != null)
            {
                Peak();
                POP();
            }
            Console.WriteLine("Stack is empty");
        }
        // Displays this instance
        internal void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine("elements in stack = " + temp.data);
                temp = temp.next;
            }
        }
    }
}
