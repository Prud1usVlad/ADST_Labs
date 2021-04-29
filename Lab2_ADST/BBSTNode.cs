using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_ADST
{
    class BBSTNode<T> where T: IComparable
    {
        public T data;
        public BBSTNode<T> leftSubTree;
        public BBSTNode<T> rightSubTree;

        public BBSTNode(T item = default(T), BBSTNode<T> l = null, BBSTNode<T> r = null)
        {
            data = item;
            leftSubTree = l;
            rightSubTree = r;
        }

    }
}
