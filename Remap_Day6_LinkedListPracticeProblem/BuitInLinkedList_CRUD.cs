using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day6_LinkedListPracticeProblem
{
    internal class BuitInLinkedList_CRUD
    {
        public void BuitInLinkedList_CRUD_Operation()
        {
            LinkedList<int> linkedList = new LinkedList<int> ();

            //Create opration
            linkedList.AddLast (10);
            linkedList.AddLast (20);
            linkedList.AddLast (30);
            linkedList.AddLast (78);

            //Read operataion
            foreach (int data in linkedList)
            {
                Console.Write(data + " ");
            }
            Console.WriteLine("read operartion completed");

            //Update operation
            linkedList.AddFirst(50);
            foreach (int data in linkedList)
            {
                Console.Write(data + " ");
            }
            Console.WriteLine("add first check successful");
           
            //Delete operation
            linkedList.RemoveFirst();
            foreach (int data in linkedList)
            {
                Console.Write(data + " ");
            }
            Console.WriteLine("remover first");
            linkedList.RemoveLast();
            foreach (int data in linkedList)
            {
                Console.Write(data + " ");
            }
           
            Console.WriteLine("remove last");
            linkedList.Remove(20);
            foreach (int data in linkedList)
            {
                Console.Write(data + " ");
            }
            Console.WriteLine("remove");
        }
    }
}
