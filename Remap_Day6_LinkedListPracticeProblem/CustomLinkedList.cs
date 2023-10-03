using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day6_LinkedListPracticeProblem
{
    internal class CustomLinkedList
    {
        public Node head;
        
        public void AddLast(int data)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                head = newnode;
                Console.WriteLine("{0} is added into new node", head.data);
            }
            else
            {
                Node lastnode = GetlastNode();
                lastnode.next = newnode;
                Console.WriteLine("{0} is added into new node", data);
            }
        }
        public void AddFirst(int data)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                head = newnode;
                Console.WriteLine("{0} is added into new node", data);
            }
            else
            {
                newnode.next = head;
                head = newnode;
                Console.WriteLine("{0} is added into new node", data);
                Console.WriteLine();
            }
        }
       
        public void RemoveLast() // 5 6 7 8
        {
            if(head  == null)
            {
                Console.WriteLine("Linkedlist is already null");
            }
            Node temp = head;
            
            if(temp.next == null)
            {
                head = null;
            }
            while (temp.next.next != null)
            {
                temp =temp.next;
            }
            temp.next = null;
        }
        private Node GetlastNode()
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        public void Display()
        {
            Node temp = head;
            if (head == null)
            {
                Console.Write("no data present in linked list");
            }

            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
            // Console.WriteLine(temp.data + " ");
        }
    }
}
