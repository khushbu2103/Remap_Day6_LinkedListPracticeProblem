using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day6_LinkedListPracticeProblem
{
    internal class CustomQueue
    {
        public Node head;
        public void CustomQueueDataStructure(int data)
        {
            Node newnode = new Node(data);
            if (head != null )
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newnode;
                Console.WriteLine("{0} is added into new node", newnode.data);
            }
            else
            {
               head = newnode;
                Console.WriteLine("{0} is added into new node", newnode.data);
            }
        }

        public void Display()
        {
            Node temp = head;
            if(temp != null )
            {
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
            else
            {
                Console.WriteLine("No data present in queue");
            }
            Console.WriteLine();
        }
        public void Dequeue()
        {
            if(head == null)
            {
                Console.WriteLine("No data present in queue");
            }
            else
            {
                Console.WriteLine("{0} is deleted from queue list", head.data);
                head = head.next;
               
            }
           
        }
        public void Empty()
        {
            while (head != null)
            {
                Console.WriteLine("{0} is deleted from queue list", head.data);
                //temp = temp.next;
                head = head.next;

            }
            Console.WriteLine("Queue is empty");
        }
    }
}
