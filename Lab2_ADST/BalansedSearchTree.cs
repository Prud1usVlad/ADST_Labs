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

        public bool Search(T item)
        {
            return Search_rec(item, root);
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

        public void MakeEmpty()
        {
            root = null;
        }

        public int Size()
        {
            return Size_rec(root);
        }

        public int CheckHeight(BSTNode<T> n)
        {
            if (n == null)
                return 0;
            else
                return Math.Max(CheckHeight(n.leftSubTree), CheckHeight(n.rightSubTree)) + 1;
        }

        public void Preorder()
        {
            Console.WriteLine("Preorder:");
            Console.Write("| ");
            Preorder_rec(root);
            Console.WriteLine("");
        }

        public void Inorder()
        {
            Console.WriteLine("Inorder:");
            Console.Write("| ");
            Inorder_rec(root);
            Console.WriteLine("");
        }

        private BSTNode<T> AddItem_rec(T item, BSTNode<T> n)
        {
            if (n == null)
                n = new BSTNode<T>(item);
            else if (item.CompareTo(n.data) < 0)
                n.leftSubTree = AddItem_rec(item, n.leftSubTree);
            else
                n.rightSubTree = AddItem_rec(item, n.rightSubTree);


            int balance = CheckHeight(n.leftSubTree) - CheckHeight(n.rightSubTree);


            BSTNode<T> temp = Balance(n, item);

            if (temp != null) n = temp;

            return n;
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

            BSTNode<T> temp = null;
            if (n != null) temp = Balance(n, item);

            if (temp != null) n = temp;

            return n;
        }

        private int Size_rec(BSTNode<T> n)
        {
            if (n == null)
                return 0;
            else
                return Size_rec(n.leftSubTree) + Size_rec(n.rightSubTree) + 1;
        }

        private BSTNode<T> Balance(BSTNode<T> n, T item)
        {
            int balance = CheckHeight(n.leftSubTree) - CheckHeight(n.rightSubTree);

            BSTNode<T> res = null;

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

        private BSTNode<T> RightRotate(BSTNode<T> node)
        {
            var nodeLeft = node.leftSubTree;
            var temp = nodeLeft.rightSubTree;

            nodeLeft.rightSubTree = node;
            node.leftSubTree = temp;

            return nodeLeft;
        }

        private BSTNode<T> LeftRotate(BSTNode<T> node)
        {
            var nodeRight = node.rightSubTree;
            var temp = nodeRight.leftSubTree;

            nodeRight.leftSubTree = node;
            node.rightSubTree = temp;

            return nodeRight;
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

        // ADDITIONAL

        public static BSTNode<int> DeleteEven(BalansedSearchTree<int> tree, BSTNode<int> n) 
        {
            if (n == null)
                return null;
            else
            {
                while (n.data % 2 == 0)
                    n = tree.DeleteItem_rec(n.data, n);

                n.leftSubTree = DeleteEven(tree, n.leftSubTree);
                n.rightSubTree = DeleteEven(tree, n.rightSubTree);

                return n;
            }
        }

        
    }
}
