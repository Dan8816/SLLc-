using System;
using System.Collections.Generic;

namespace sll
{
    public class LinkedList
    {
        public LinkedListNode Head {get;set;}
        public LinkedListNode Last {get;set;}

        public void AddToList(object _value)
        {
            LinkedListNode node = new LinkedListNode();
            node.Value = _value;

            if (Head == null)
            {
                Head = node;
                Last = node;
            }
            else
            {
                Last.Next = node;
                Last = node;
                Last.Prev = Head;
                if (Last.Prev != Head)
                {
                    LinkedListNode Runner = Head;
                    while (Runner != null)
                    {
                        if (Runner.Next == Last)
                        {
                            Last.Prev = Runner;
                        }
                    }
                }
            }
        }

        public void RemovefromList()
        {
            LinkedListNode Runner = Head;
            while (Runner != null)
            {
                Runner = Runner.Next;
                {
                    if (Runner.Next == Last)
                    {
                        Runner.Next = null;
                        Runner = Last;
                        return;
                    }       
                }
            }
        }
        public void DisplayList()
        {
            LinkedListNode current = Head;
            while (current != null)
            {
                System.Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
    }
}