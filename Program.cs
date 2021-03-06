﻿// --------------------------------------------------------------------------------------------------------------------
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
            linkedList.Traverse();
            linkedList.AddNode(56);
            linkedList.Traverse();
            linkedList.AddNode(30);
            linkedList.Traverse();
            linkedList.AddNode(70);
            linkedList.Traverse();
        }
    }
}
