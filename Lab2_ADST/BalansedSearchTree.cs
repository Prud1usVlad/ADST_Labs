using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_ADST
{
    class BalansedSearchTree<T> where T: IComparable
    {
        public BSTNode<T> root;

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

        public bool Search(T item)
        {
            return Search_rec(item, root);
        }

        private bool Search_rec(T item, BSTNode<T> n)
        {
            if (n == null)
                return false;
            else if (item.Equals(n.data))
                return true;
            else if (item.CompareTo(n.data) < 0)
                return Search_rec(item, n.leftSubTree);
            else
                return Search_rec(item, n.rightSubTree);
        }

        public T FindMin(BSTNode<T> n)
        {
            if (n.leftSubTree == null)
                return n.data;
            else
                return FindMin(n.leftSubTree);
        }

        public void Preorder()
        {
            Console.WriteLine("Preorder:");
            Console.Write("| ");
            Preorder_rec(root);
            Console.WriteLine("");
        }

        private void Preorder_rec(BSTNode<T> n)
        {
            if (n == null)
                return;
            else
            {
                Console.Write(n.data + " | ");
                Preorder_rec(n.leftSubTree);
                Preorder_rec(n.rightSubTree);
            }
        }

        public void Inorder()
        {
            Console.WriteLine("Inorder:");
            Console.Write("| ");
            Inorder_rec(root);
            Console.WriteLine("");
        }

        private void Inorder_rec(BSTNode<T> n)
        {
            if (n == null)
                return;
            else
            {
                Inorder_rec(n.leftSubTree);
                Console.Write(n.data + " | ");
                Inorder_rec(n.rightSubTree);
            }
        }

        public void Postorder()
        {
            Console.WriteLine("Postorder");
            Console.Write("| ");
            Postorder_rec(root);
            Console.WriteLine("");
        }

        private void Postorder_rec(BSTNode<T> n)
        {
            if (n == null)
                return;
            else
            {
                Postorder_rec(n.leftSubTree);
                Postorder_rec(n.rightSubTree);
                Console.Write(n.data + " | ");
            }
        }
    }
}
