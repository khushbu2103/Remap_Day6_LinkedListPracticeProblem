using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day6_LinkedListPracticeProblem
{
    internal class CustomStack
    {
        public Node Top;
        public void CustomStackDataStructure(int data)
        {
            Node newnode = new Node(data);
            if(Top == null)
            {
                Top = newnode;
                Console.WriteLine("{0} is added into new node", Top.data);
            }
            else
            {
                newnode.next = Top;
                Top = newnode;
                Console.WriteLine("{0} is added into new node", Top.data);
            }
        }
        public void Display()
        {
            if (Top != null)
            {
                Node temp = Top;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
            else
            {
                Console.Write("no data present in stack");
            }
            Console.WriteLine();
        }
        public void Peek()
        {
            if (Top == null)
            {
                Console.Write("no data present in stack");
            }
            else
            {
                Console.WriteLine("\n{0} is the top most element of stack", Top.data);
            }
        }
        public void Pop()
        {
            if (Top.data != 0)
            {
                Console.WriteLine("{0} is deleted from stack", Top.data);
                Top = Top.next;
            }
            else
            {
                Console.WriteLine("stack is empty");
            }
        }
        public void MakeEmptyStack()
        {
            while(Top != null)
            {
                Peek();
                Pop();
            }
        }
    }
}
