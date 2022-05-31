﻿
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
                    //dataStructure.linkedListStack runStack = new linkedListStack();
                    linkedListStack linkListstack = new linkedListStack();
                    linkListstack.addStack(70);
                    linkListstack.addStack(30);
                    linkListstack.addStack(56);
                    linkListstack.display();
                    
                    break;
            
                    


            }
           
            
        }
    }
}
