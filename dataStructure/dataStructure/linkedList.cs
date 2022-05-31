using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dataStructure
{
    internal class linkedList
    {
        internal node head;
        public void add(int data)
        {
            node node = new node(data);
            if(this.head == null)
            {
                this.head = node;
            }
            else
            {
                node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} is inserted in to linked list",node.id);
        }
        public void swapValues(int data)
        {
            node node = new node(data);
            if (head == null)
            {
                this.head = node;
            }
            else
            {
                node.next = head;
                head = node;
            }
            Console.WriteLine(node.id + "Added");
        }
        public void display()
        {
            node currentNode = this.head;
            if (currentNode == null)
            {
                Console.WriteLine("Linked List Is Empty");
            }
            else
            {

                while (currentNode != null)
                {
                    Console.WriteLine(currentNode.id);
                    currentNode = currentNode.next;
                }
            }
        }
    }
}
