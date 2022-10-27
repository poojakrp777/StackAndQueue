using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stacks and Queues Programs");

            LinkedList stackUsingLinkList = new LinkedList();
            stackUsingLinkList.Push(70);
            stackUsingLinkList.Push(30);
            stackUsingLinkList.Push(56);
            stackUsingLinkList.Display();

            stackUsingLinkList.Peak();
            stackUsingLinkList.Display();
            stackUsingLinkList.POP();
            stackUsingLinkList.Display();
            stackUsingLinkList.IsEmpty();
            stackUsingLinkList.Display();

            QueueLinkedList queueUsingLinkList = new QueueLinkedList();
            queueUsingLinkList.Enqueue(56);
            queueUsingLinkList.Enqueue(30);
            queueUsingLinkList.Enqueue(70);
            queueUsingLinkList.Display();
        }
    }
}
