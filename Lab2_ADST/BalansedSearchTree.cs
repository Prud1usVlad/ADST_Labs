﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_ADST
{
    class BalansedSearchTree<T> where T: IComparable
    {
        BSTNode<T> root;

        public void AddItem(T item)
        {
            root = AddItem_rec(item, root);
        }

        private BSTNode<T> AddItem_rec(T item, BSTNode<T> n)
        {
            if (n == null)
            {
                n = new BSTNode<T>(item);
                n.leftSubTree = n.rightSubTree = null;
            }
            else if (item.CompareTo(n.data) < 0)
                n.leftSubTree = AddItem_rec(item, n.leftSubTree);
            else
                n.rightSubTree = AddItem_rec(item, n.rightSubTree);


            return n;
        }


    }
}
