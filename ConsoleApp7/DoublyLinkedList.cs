using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp7
{
    internal class DoublyLinkedList
    {
        public class Node
    { 
        public int Data;
        public Node Next;
        public Node Prev;

        public Node(int data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }

    public Node Head;
        public void Reverse()
        {
            Node prevNode = null;
            Node currNode = Head;
            Node nextNode = null;

            while (currNode != null)
            {
                nextNode = currNode.Next;
                currNode.Next = prevNode;
                currNode.Prev = nextNode;

                prevNode = currNode;
                currNode = nextNode; 
            }

            Head = prevNode;
        }
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            if (Head != null)
            {
                newNode.Next = Head;
                Head.Prev = newNode;
            }
            Head = newNode;
        }

        public void PrintList()
        {
            Node current = Head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }

}

