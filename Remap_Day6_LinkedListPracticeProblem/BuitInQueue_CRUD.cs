using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day6_LinkedListPracticeProblem
{
    internal class BuitInQueue_CRUD
    {
        public void BuitInQueue_CRUD_OPerartion()
        {
            Queue<int> queue = new Queue<int>();
            //Create operation
            queue.Enqueue(13);
            queue.Enqueue(25);
            queue.Enqueue(37);
            queue.Enqueue(49);

            //Read operation 
            foreach (int data in queue)
            {
                Console.Write(data + " ");
            }
            Console.WriteLine();

            //Delete operation
            queue.Dequeue();
            foreach (int data in queue)
            {
                Console.Write(data + " ");
            }
            Console.WriteLine();
        }
    }
}
