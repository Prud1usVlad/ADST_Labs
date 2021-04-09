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

        public void DeleteItem(T item)
        {
            if (Search(item))
                root = DeleteItem_rec(item, root);
            else
                Console.WriteLine("Item not found");
        }

        private BSTNode<T> DeleteItem_rec(T item, BSTNode<T> n)
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

            return n;
        }

        public void MakeEmpty()
        {
            root = null;
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
