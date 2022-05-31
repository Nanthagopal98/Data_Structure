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
            Console.WriteLine("{0} is inserted in to linked list",node.data);
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
            Console.WriteLine(node.data + "Added");
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
                    Console.WriteLine(currentNode.data);
                    currentNode = currentNode.next;
                }
            }
        }
        /*public void Append(int data)
        {
            node node = new node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                node position = head;
                while (position.next != null)
                {
                    position = position.next;
                }
                position.next = node;
            }
            Console.WriteLine("{0} inserted into LinkedList", node.id);
        }*/
        public void insertNodeInbetween(int position, int data)
        {   
            int check = 1;
            node newNode = new node(data);
            if (position == 1)
            {
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                node temp = head;
                while (position != check)
                {
                    check++;
                    if (position == check)
                    {
                        newNode.next = temp.next;
                        temp.next = newNode;
                        break;
                    }
                    
                    temp = temp.next;
                }               
            }
        }
        public void removeFirst()
        {
            this.head = this.head.next;
        }  
    }
}
