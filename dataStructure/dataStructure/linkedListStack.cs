using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    internal class linkedListStack
    {
        public node top;
        public linkedListStack()
        {
            this.top = null;
        }
        public void addStack(int data)
        {
            node node = new node(data);
            if (this.top == null)
            {
                this.top = node;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine(node.data +" Added to stack");

        }
        public void display()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                node temp = this.top;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;   
                }
            }
        }
        public void peak()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine(top.data + " is a Peak Value");
            }
        }
        public void pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                while (this.top != null)
                {
                    Console.WriteLine(top.data + " is a Removed");
                    this.top = top.next;
                }
            }
        }

    }
}
