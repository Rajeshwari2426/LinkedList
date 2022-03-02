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
            customLinkedList.AddInReverseOrder(70);
            customLinkedList.AddInReverseOrder(30);
            customLinkedList.AddInReverseOrder(56);
            customLinkedList.Display();
            Console.ReadLine();
        }
    }
}
