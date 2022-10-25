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
            stackUsingLinkList.push(70);
            stackUsingLinkList.push(30);
            stackUsingLinkList.push(56);
            stackUsingLinkList.Display();
        }
    }
}
