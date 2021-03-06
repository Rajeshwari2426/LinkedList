using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class CustomLinkedList
    {
        public Node head;
       public void AddNode(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.Write("\n {0} inserted into linked list", node.data);
        }
        public void AddInReverseOrder(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.next = temp;
            }
            Console.Write("\n {0} inserted into linked list", newNode.data);
        }
        //method to display elements
        public void Display()
        {
            Console.Write("\n Data of linked list : ");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }

            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        //method to append elements
        internal void Append(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the Append linked list", node.data);
        }
        //method to insert element 
        internal Node Insert(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                Node temp = this.head;
                while (position-- != 0) 
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    temp = temp.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            Console.WriteLine("\n{0} inserted ", data);
            return head;
            
        }
        //method to delete first element
        public int DeleteFirstNode()
        {
            if (this.head == null)
            {
                Console.WriteLine("Linked list Empty");
                return 0;
            }
            int deleteNode = this.head.data;
            this.head = this.head.next;
            Console.WriteLine("\n{0} deleted ", deleteNode);
            return deleteNode;
        }
        //method to delete last element
        public int DeleteLastNode()
        {
            Node newNode = this.head;
            if (this.head == null)
            {
                Console.WriteLine("linked list empty");
                return 0;
            }
            if (this.head.next == null)
            {
                this.head = null;
                return 0;
            }
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            int lastDeleteNode = newNode.next.data;
            newNode.next = null;
            Console.WriteLine("\n{0} deleted ", lastDeleteNode);
            return lastDeleteNode;
        }
        //method to search an element
        internal int Search(int value)
        {
            Node node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data == value)
                {
                    Console.WriteLine("\n{0} is  present", value);
                    return count;
                }
                node = node.next;
                count++; 
            }           
            Console.WriteLine("\n{0} is not present", value);
            return count;
        }
        //method to add an element at a particular position
        internal Node InsertAtParticularPosition(int position, int data)
        {
            Node newestNode = new Node(data);
            if (this.head == null)
            {
                return newestNode;
            }
            if (position == 0)
            {
                newestNode.next = this.head;
                this.head = newestNode;
                return this.head;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newestNode.next = prev.next;
            prev.next = newestNode;
            Console.WriteLine("\n{0} inserted ", data);
            return this.head;
        }
        //method to delete an element at a particular position
        internal void DeleteNodeAtParticularPosition(int position)
        {
            if (this.head == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            Node temp = this.head;
            if (position == 0)
            {
                this.head = temp.next;
                return;
            }
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;

            }
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node next = temp.next.next;
            temp.next = next;
            Console.WriteLine("\n node deleted ");
            Size();
        }
        //method to find size of linked list i.e.,no of elements present
        internal void Size()
        {
            Node temp = this.head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
                count++;
            }
            Console.WriteLine("\nLength of LinkedList is :-" + " " + count);
        }
        //method to create Ordered Linked List in ascending order of data entered
        internal void sortList()
        {
            //Node current will point to head  
            Node current = head, index = null;
            int temp;
            if (head == null)
            {
                return;
            }
            else
            {
                while (current != null)
                {
                    //Node index will point to node next to current  
                    index = current.next;

                    while (index != null)
                    {
                        //sorting 
                        if (current.data > index.data)
                        {
                            temp = current.data;
                            current.data = index.data;
                            index.data = temp;
                        }
                        index = index.next;
                    }
                    current = current.next;
                }
            }
        }
    }
}
