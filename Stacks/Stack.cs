using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    internal class Stack : Node
    {
        private Node top;
        private int length;

        public Stack()
        {
            this.top = null;
            this.length = 0;
        }

        public int Length { get { return this.length; } }

        /// <summary>
        /// Inserts an element at the top of the stack.
        /// O(1)
        /// </summary>
        /// <param>
        /// <c>value</c> is an integer to be inserted.
        /// </param>
        public void Push(int? value)
        {
            if (this.length == 0)
            {
                this.top = new Node(value);
            }
            else
            {
                Node tmp = this.top;
                this.top = new Node(value);
                this.top.Next = tmp;
            }
            this.length++;
        }

        /// <summary>
        /// Deletes the topmost element of the stack.
        /// O(1)
        /// </summary>
        public void Pop()
        {
            if (this.length == 0) return;
            if (this.length == 1)
            {
                Console.WriteLine("Pop " + this.top.Value);
                this.top = null;
            }
            else
            {
                Console.WriteLine("Pop " + this.top.Value);
                this.top = this.top.Next;
            }
            this.length--;
        }

        /// <summary>
        /// Returns a reference to the topmost element of the stack.
        /// O(1)
        /// </summary>
        /// <returns>
        /// The int? topmost element.
        /// </returns>
        public int? Peek()
        {
            if (this.length == 0) return -1;
            return this.top.Value;

        }
    }
}
