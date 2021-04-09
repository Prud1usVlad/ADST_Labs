using System;

namespace Lab2_ADST
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new BalansedSearchTree<int>();

            a.AddItem(10);
            a.AddItem(1);
            a.AddItem(20);
            a.AddItem(8);
            a.AddItem(9);
            a.AddItem(12);
            a.Preorder();
            a.Inorder();
            a.Postorder();

            Console.WriteLine(a.Search(12));
            Console.WriteLine(a.Search(-3));

        }
    }
}
