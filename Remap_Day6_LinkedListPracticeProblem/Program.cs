using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day6_LinkedListPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose any program.");
            Console.WriteLine("1. Create custom linked list.\n" +
                "2. Create custom stack.\n" +
                "3. Create custom queue.\n" +
                "4. built-in LinkedList datasructure CRUD operations.\n" +
                "5. built-in Stack datasructure CRUD operations.\n" +
                "6. built-in queue datasructure CRUD operations.");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    CustomLinkedList customLinkedList = new CustomLinkedList();
                    customLinkedList.AddLast(50);
                    customLinkedList.AddLast(40);
                    customLinkedList.AddLast(30);
                    customLinkedList.AddFirst(10);
                    customLinkedList.Display();
                    customLinkedList.RemoveLast();
                    customLinkedList.Display();
                    break;
                case 2:
                    CustomStack customStack = new CustomStack();
                    customStack.CustomStackDataStructure(40);
                    customStack.CustomStackDataStructure(20);
                    customStack.CustomStackDataStructure(80);
                    customStack.Display();
                    customStack.MakeEmptyStack();
                    customStack.Display();
                    break;
                case 3:
                    CustomQueue customQueue = new CustomQueue();
                    customQueue.CustomQueueDataStructure(50);
                    customQueue.CustomQueueDataStructure(40);
                    customQueue.CustomQueueDataStructure(30);
                    customQueue.Display();
                    customQueue.Dequeue();
                    //customQueue.Display();
                    break;
                case 4:
                    BuitInLinkedList_CRUD buitInLinkedList_CRUD = new BuitInLinkedList_CRUD();
                    buitInLinkedList_CRUD.BuitInLinkedList_CRUD_Operation();
                    break;
                case 5:
                    BuitInStack_CRUD buitInStack_CRUD = new BuitInStack_CRUD();
                    buitInStack_CRUD.BuitInStack_CRUD_Operation();
                    break;
                case 6:
                    BuitInQueue_CRUD buitInQueue_CRUD = new BuitInQueue_CRUD();
                    buitInQueue_CRUD.BuitInQueue_CRUD_OPerartion();
                    break;
                case 7:
                    SortedLinkedList sortedLinkedList = new SortedLinkedList();
                    sortedLinkedList.SortedLinkedListDecendingOerder(13);
                    sortedLinkedList.SortedLinkedListDecendingOerder(24);
                    sortedLinkedList.SortedLinkedListDecendingOerder(10);
                    sortedLinkedList.SortedLinkedListDecendingOerder(29);
                    sortedLinkedList.Display();
                    break;
            }
           
            Console.ReadLine();
        }
    }
}
