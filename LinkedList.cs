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

        /// <summary>
        /// Pushes the Node at the back of LinkedList.
        /// </summary>
        /// <param name="data">The data.</param>
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

        /// <summary>
        /// Pushes the Node at the front of LinkedList.
        /// </summary>
        /// <param name="data">The data.</param>
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
        /// Pushes Node at given index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="data">The data.</param>
        public void PushAtIndex(int index, T data)
        {
            if (this.head == null)
            {
                this.head = new Node<T>(data);
                this.tail = this.head;
                return;
            }

            Node<T> node = this.head;
            for (int i = 0; i < index - 1; i++)
            {
                node = node.next;
            }

            Node<T> temp = new Node<T>(data);
            temp.next = node.next;
            node.next = temp;
        }

        /// <summary>
        /// Deletes the front Node.
        /// </summary>
        public void PopFront()
        {
            if (this.head == null)
            {
                return;
            }

            this.head = this.head.next;
        }

        /// <summary>
        /// Counts number of Nodes.
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            int count = 0;
            Node<T> node = head;
            while (node != null)
            {
                node = node.next;
                count++;
            }
            return count;
        }

        /// <summary>
        /// Delete the Node at end.
        /// </summary>
        public void PopBack()
        {
            if (this.head == null)
            {
                return;
            }

            Node<T> node = head;
            int length = Count();
            if (length <= 1)
            {
                this.head = null;
                this.tail = this.head;
                return;
            }
            for (int i = 1; i < length - 1; i++)
            {
                node = node.next;
            }
            node.next = null;
            tail = node;
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

        /// <summary>
        /// Searches the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public int Search(T data)
        {
            Node<T> temp = this.head;
            int index = 0;
            while (temp != null)
            {
                if (temp.data.Equals(data))
                {
                    return index;
                }
                temp = temp.next;
                index++;
            }
            return -1;
        }
    }
}
