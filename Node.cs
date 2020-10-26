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

    class Node
    {
        /// <summary>
        /// The data
        /// </summary>
        public T data;

        /// <summary>
        /// The next Node
        /// </summary>
        public Node<T> next;

        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public Node(T data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
