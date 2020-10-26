// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Node.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Aryav Tiwari"/>
//

namespace LinkedListImplementation
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Public Class Linked List
    /// </summary>
    public class LinkedList
    {
        /// <summary>
        /// The head
        /// </summary>
        public Node<T> head;

        /// <summary>
        /// The tail
        /// </summary>
        public Node<T> tail;
        public LinkedList()
        {
            this.head = null;
            this.tail = this.head;
        }

        public void PushBack(T data)
        {
            if (this.head == null)
            {
                this.head = new Node<T>(data);
                this.tail = this.head;
                return;
            }

            Node<T> temp = new Node<T>(data);
            this.tail.next = temp;
            this.tail = temp;
        }

        public void PushFront(T data)
        {
            if (this.head == null)
            {
                this.head = new Node<T>(data);
                this.tail = this.head;
                return;
            }

            Node<T> temp = new Node<T>(data);
            temp.next = this.head;
            this.head = temp;
        }

        /// <summary>
        /// Traverses this instance.
        /// </summary>
        public void Traverse()
        {
            Node<T> temp = this.head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }

            Console.WriteLine();
        }
    }
}
