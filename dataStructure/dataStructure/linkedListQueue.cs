using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    internal class linkedListQueue
    {
        public node first;
        public linkedListQueue()
        {
            this.first = null;
        }
        public void queue(int data)
        {
            node node = new node(data);
            if (this.first == null)
            {
                this.first = node;
            }
            else
            {
                node temp = this.first;
                while(temp.next != null)
                { 
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(node.data + " Added");
        }
        public void display()
        {
            if(this.first == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                node temp = this.first; 
                while(temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
