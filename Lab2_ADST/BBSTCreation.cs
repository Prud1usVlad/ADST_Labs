using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_ADST
{
    partial class BBST<T> where T : IComparable 
    {
        public void AddItem(T item)
        {
            root = AddItem_rec(item, root);
        }

        public T FindMin(BBSTNode<T> n)
        {
            if (n.leftSubTree == null)
                return n.data;
            else
                return FindMin(n.leftSubTree);
        }

        public void DeleteItem(T item)
        {
            if (Search(item))
                root = DeleteItem_rec(item, root);
            else
                Console.WriteLine("Item not found");
        }

        public void MakeEmpty()
        {
            root = null;
        }

        public int CheckHeight(BBSTNode<T> n)
        {
            if (n == null)
                return 0;
            else
                return Math.Max(CheckHeight(n.leftSubTree), CheckHeight(n.rightSubTree)) + 1;
        }

        private BBSTNode<T> AddItem_rec(T item, BBSTNode<T> n)
        {
            if (n == null)
                n = new BBSTNode<T>(item);
            else if (item.CompareTo(n.data) < 0)
                n.leftSubTree = AddItem_rec(item, n.leftSubTree);
            else
                n.rightSubTree = AddItem_rec(item, n.rightSubTree);

            int balance = CheckHeight(n.leftSubTree) - CheckHeight(n.rightSubTree);
            BBSTNode<T> temp = null;

            if (Math.Abs(balance) > 1)
                temp = Balance(n, item);

            if (temp != null) n = temp;

            return n;
        }

        private BBSTNode<T> DeleteItem_rec(T item, BBSTNode<T> n)
        {
            if (n == null)
                return n;
            else if (item.CompareTo(n.data) < 0)
                n.leftSubTree = DeleteItem_rec(item, n.leftSubTree);
            else if (item.CompareTo(n.data) > 0)
                n.rightSubTree = DeleteItem_rec(item, n.rightSubTree);
            // if node we need to delete has two child nodes, we need to
            // replase it with the smallest node ftom it's right subtree
            else if (n.rightSubTree != null && n.leftSubTree != null)
            {
                n.data = FindMin(n.rightSubTree);
                n.rightSubTree = DeleteItem_rec(n.data, n.rightSubTree);
            }
            // if if node we need to delete has only one child node, we need 
            // to link its child node to its root
            else if (n.rightSubTree != null)
                n = n.rightSubTree;
            else if (n.leftSubTree != null)
                n = n.leftSubTree;
            else
                n = null;

            BBSTNode<T> temp = null;
            if (n != null) temp = Balance(n, item);

            if (temp != null) n = temp;

            return n;
        }

        private BBSTNode<T> Balance(BBSTNode<T> n, T item)
        {
            int balance = CheckHeight(n.leftSubTree) - CheckHeight(n.rightSubTree);

            BBSTNode<T> res = null;

            if (balance > 1 && item.CompareTo(n.leftSubTree.data) < 0)
                res = RightRotate(n);
            else if (balance > 1 && item.CompareTo(n.leftSubTree.data) > 0)
            {
                n.leftSubTree = LeftRotate(n.leftSubTree);
                res = RightRotate(n);
            }
            else if (balance < -1 && item.CompareTo(n.rightSubTree.data) > 0)
                res = LeftRotate(n);
            else if (balance < -1 && item.CompareTo(n.rightSubTree.data) < 0)
            {
                n.rightSubTree = RightRotate(n.rightSubTree);
                res = LeftRotate(n);
            }

            return res;
        }

        private BBSTNode<T> RightRotate(BBSTNode<T> node)
        {
            var nodeLeft = node.leftSubTree;
            var temp = nodeLeft.rightSubTree;

            nodeLeft.rightSubTree = node;
            node.leftSubTree = temp;

            return nodeLeft;
        }

        private BBSTNode<T> LeftRotate(BBSTNode<T> node)
        {
            var nodeRight = node.rightSubTree;
            var temp = nodeRight.leftSubTree;

            nodeRight.leftSubTree = node;
            node.rightSubTree = temp;

            return nodeRight;
        }
    }
}
