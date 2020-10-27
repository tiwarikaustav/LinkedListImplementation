// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Node.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Aryav Tiwari"/>
//

namespace LinkedListImplementation
{
    using System;
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.PushBack(10);
            linkedList.Traverse();
            linkedList.PushBack(30);
            linkedList.Traverse();
            linkedList.PushFront(20);
            linkedList.Traverse();
            linkedList.PopBack();
            linkedList.Traverse();
            linkedList.PushAtIndex(0, 50);
            linkedList.Traverse();
            linkedList.PushFront(60);
            linkedList.Traverse();
            linkedList.PopFront();
            linkedList.Traverse();
            Console.WriteLine("Index of 20 : " + linkedList.Search(20));
            Console.WriteLine("Index of 50 : " + linkedList.Search(50));
            Console.WriteLine("Index of 70 : " + linkedList.Search(70));
        }
    }
}
