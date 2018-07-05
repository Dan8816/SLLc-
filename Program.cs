using System;
using System.Collections.Generic;

namespace sll
{
    class Program
    {
        static void Main(string[] args)
        {


            LinkedList list = new LinkedList();

            list.AddToList(4);
            list.AddToList(5);
            list.AddToList(6);
            list.RemovefromList();

            list.DisplayList();
            Console.ReadLine();
            return;
        }
    }
}
