using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day6_LinkedListPracticeProblem
{
    internal class BuitInStack_CRUD
    {
        public void BuitInStack_CRUD_Operation()
        {
            Stack<int> stack = new Stack<int>();

            //Create stack
            stack.Push(10);
            stack.Push(23);
            stack.Push(31);
            stack.Push(46);
            
            //Read stack
            foreach(int data in stack)
            {
                Console.Write(data + " ");
            }
            Console.WriteLine();

            stack.Peek();
            foreach (int data in stack)
            {
                Console.Write(data + " ");
            }
            Console.WriteLine();
            
            //Delete opration
            stack.Pop();
            foreach (int data in stack)
            {
                Console.Write(data + " ");
            }
            Console.WriteLine();
        }
    }
}
