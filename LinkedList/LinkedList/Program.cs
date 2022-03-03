using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList program");
            CustomLinkedList customLinkedList = new CustomLinkedList();
            customLinkedList.AddNode(56);
            customLinkedList.AddNode(30);
            customLinkedList.AddNode(70);
            //  customLinkedList.InsertAtParticularPosition(2, 30);
            // customLinkedList.DeleteFirstNode();
            // customLinkedList.DeleteLastNode();
            // customLinkedList.Search(70);
            int position = customLinkedList.Search(30);
            position++;
            customLinkedList.InsertAtParticularPosition(position, 40);
            //int position1 = customLinkedList.Search(40);
            //customLinkedList.DeleteNodeAtParticularPosition(position1);
            Console.WriteLine("created a sorted linked list in acsending order");           
            Console.WriteLine("Before Sorting ");
            customLinkedList.Display();
            Console.WriteLine("\nAfter Sorting");
            customLinkedList.sortList();
            customLinkedList.Display();
            Console.ReadLine();
        }
    }
}
