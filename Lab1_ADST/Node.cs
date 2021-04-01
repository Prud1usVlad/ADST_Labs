using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_ADST
{
    class Node<T>
    {
        public T data;
        public Node<T> next;

        public Node(T d, Node<T> link = null)
        {
            data = d;
            next = link;
        }
    }
}
