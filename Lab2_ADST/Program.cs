using System;

namespace Lab2_ADST
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new BBST<int>();

            a.AddItem(15);
            a.AddItem(10);
            a.AddItem(7);
            a.AddItem(50);
            a.AddItem(12);
            a.AddItem(11);
            a.AddItem(45);
            a.AddItem(13);
            a.AddItem(55);
            a.AddItem(14);
            a.Inorder();
            a.Preorder();
            a.Postorder();

            Console.WriteLine($"Size: {a.Size()}");
            a.DeleteItem(11);
            a.Preorder();
            Console.WriteLine($"Size: {a.Size()}");
            Console.WriteLine($"Includes 11: {a.Search(11)}");
            Console.WriteLine($"Includes 7: {a.Search(7)}");
            a.MakeEmpty();
            Console.WriteLine($"Size: {a.Size()}");
            a.Preorder();
        }
    }
}
