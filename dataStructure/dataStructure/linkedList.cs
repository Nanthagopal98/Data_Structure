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
        public void add(int id)
        {
            node node = new node(id);
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
    }
}
