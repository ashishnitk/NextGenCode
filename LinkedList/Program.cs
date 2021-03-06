﻿using LinkedListProg.Areas;
using System;


namespace LinkedListProg
{
        
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedlist = new LinkedList();
            linkedlist.Add("15");
            linkedlist.Add("85");
            linkedlist.Add("85");
            linkedlist.Add("12");
            linkedlist.Add("41");
            linkedlist.Add("41");
            linkedlist.Add("41");
            linkedlist.Add("41");
            linkedlist.Add("41");
            linkedlist.Add("41");
            linkedlist.Add("41");
            linkedlist.Add("69");

            linkedlist.Add("31");
            linkedlist.Add("53");
            linkedlist.Add("69");
            linkedlist.Add("44");
            linkedlist.Add("75");
            linkedlist.Add("41");
            linkedlist.Add("69");
            linkedlist.Add("11");

            // Print all nodes of linked list
            linkedlist.PrintAllNodes();

            // Remove all duplicates from a linked list
            linkedlist.RemoveDuplicates();

            // Print all nodes of the linkedlist
            linkedlist.PrintAllNodes();

            // Delete a perticular node
            Console.WriteLine("\n\rDelete 4th Node in the list\n\r");
            linkedlist.Delete(4);

            linkedlist.PrintAllNodes();

            // reverse a linkedlist
            Console.WriteLine("Reverse of linked list in group of 3\n\r");
            linkedlist.PrintReverseList(3);
            linkedlist.PrintAllNodes();
            Console.ReadLine();

        }
    }
}
