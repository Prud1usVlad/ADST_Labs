using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_ADST
{
    class BSTNode<T> where T: IComparable
    {
        public T data;
        public BSTNode<T> leftSubTree;
        public BSTNode<T> rightSubTree;

        public BSTNode(T item = default(T), BSTNode<T> l = null, BSTNode<T> r = null)
        {
            data = item;
            leftSubTree = l;
            rightSubTree = r;
        }

    }
}
