
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    internal class mainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1 for Linked List");
            Console.WriteLine("2 for Stack");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    dataStructure.linkedList run = new dataStructure.linkedList();
                    linkedList list = new linkedList();
                    Console.WriteLine("1 to create simple linked list");
                    Console.WriteLine("2 to swap position");
                    Console.WriteLine("3 to Perform Append");
                    Console.WriteLine("4 to Insert Value");
                    Console.WriteLine("5 to Remove First Value");
                    Console.WriteLine("6 to Remove Last Value");
                    int select = Convert.ToInt32(Console.ReadLine());
                    switch (select)
                    {
                        case 1:
                            list.add(56);
                            list.add(30);
                            list.add(70);
                            list.display();
                            break;
                        case 2:
                            list.swapValues(56);
                            list.swapValues(30);
                            list.swapValues(70);
                            list.display();
                            break;
                        case 3:
                            list.add(56);
                            list.add(30);
                            list.add(70);
                            list.display();
                            break;
                        case 4:
                            list.add(56);
                            list.add(70);
                            Console.WriteLine("Before insert");
                            list.display();
                            Console.WriteLine("After insert");
                            list.insertNodeInbetween(2, 30);
                            list.display();
                            break;
                        case 5:
                            list.add(56);
                            list.add(30);
                            list.add(70);
                            Console.WriteLine("--------------------");
                            Console.WriteLine("Values Present in List");
                            list.display();
                            list.removeFirst();
                            Console.WriteLine("After Remove First Value");
                            list.display();
                            break;
                        case 6:
                            list.add(56);
                            list.add(30);
                            list.add(70);
                            Console.WriteLine("--------------------");
                            Console.WriteLine("Values Present in List");
                            list.display();
                            list.removeLastValue();
                            Console.WriteLine("After Remove Last Value");
                            list.display();
                            break;
                    }
                    break;
                case 2:
                    linkedListStack linkListstack = new linkedListStack();
                    linkedListQueue linkListqueue = new linkedListQueue();
                    Console.WriteLine("1 to Create Simple Stack and Find Peak");
                    Console.WriteLine("2 to Create Simple Stack and Perform Peak and Pop");
                    Console.WriteLine("3 to Create Simple Queue");
                    Console.WriteLine("4 to Create Simple Queue and Dequeue");
                    int selectStack = Convert.ToInt32(Console.ReadLine());
                    switch (selectStack)
                    {
                        case 1:
                            linkListstack.addStack(70);
                            linkListstack.addStack(30);
                            linkListstack.addStack(56);
                            linkListstack.display();
                            linkListstack.peak();
                            break;
                        case 2:
                            linkListstack.addStack(70);
                            linkListstack.addStack(30);
                            linkListstack.addStack(56);
                            linkListstack.display();
                            Console.WriteLine("--------------------");
                            linkListstack.peak();
                            Console.WriteLine("--------------------");
                            linkListstack.pop();
                            Console.WriteLine("--------------------");
                            linkListstack.display();
                            break;
                        case 3:
                            linkListqueue.queue(56);
                            linkListqueue.queue(30);
                            linkListqueue.queue(70);
                            linkListqueue.display();
                            break;
                        case 4:
                            linkListqueue.queue(56);
                            linkListqueue.queue(30);
                            linkListqueue.queue(70);
                            linkListqueue.display();
                            linkListqueue.deQueue();
                            linkListqueue.display();
                            break;
                          
                    }
                    break;
                    
            
            
            }                       
        }
    }
}
