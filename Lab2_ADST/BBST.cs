using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_ADST
{
    partial class BBST<T> where T: IComparable
    {
        public BBSTNode<T> root;

        public bool Search(T item)
        {
            return Search_rec(item, root);
        }

        public int Size()
        {
            return Size_rec(root);
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

        public void Postorder()
        {
            Console.WriteLine("Postorder");
            Console.Write("| ");
            Postorder_rec(root);
            Console.WriteLine("");
        }

        private bool Search_rec(T item, BBSTNode<T> n)
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

        private int Size_rec(BBSTNode<T> n)
        {
            if (n == null)
                return 0;
            else
                return Size_rec(n.leftSubTree) + Size_rec(n.rightSubTree) + 1;
        }

        private void Preorder_rec(BBSTNode<T> n)
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

        private void Inorder_rec(BBSTNode<T> n)
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

        private void Postorder_rec(BBSTNode<T> n)
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

        public void DeleteEven()
        {
            int data;

            if (!int.TryParse(root.data.ToString(), out data))
            {
                Console.WriteLine("Invalid data type of tree");
                return;
            }
            else
                DeleteEven_rec(root);
        }

        private BBSTNode<T> DeleteEven_rec(BBSTNode<T> n) 
        {
            if (n == null)
                return null;
            else
            {
                int data = int.Parse(n.data.ToString());

                while (data % 2 == 0)
                {
                    n = DeleteItem_rec(n.data, n);
                    data = int.Parse(n.data.ToString());
                }
                    

                n.leftSubTree = DeleteEven_rec(n.leftSubTree);
                n.rightSubTree = DeleteEven_rec(n.rightSubTree);

                return n;
            }
        }
    }
}
