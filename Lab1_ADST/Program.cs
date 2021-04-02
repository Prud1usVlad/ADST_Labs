using System;

namespace Lab1_ADST
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new List<int>();
            Console.Write("List empty: ");
            Console.WriteLine(a.IsEmpty());
            a.AddItem(14);
            a.AddItem(2);
            a.AddItem(5);
            a.AddItem(45);
            a.AddItem(-5);
            a.AddItem(-4);
            a.AddItem(-45);
            a.AddItem(4);
            a.Print();
            Console.Write("List empty: ");
            Console.WriteLine(a.IsEmpty());
            Console.Write("List size: ");
            Console.WriteLine(a.ListSize());
            Console.Write("Retrieve elemet -5 (if 0 then no such element): ");
            Console.WriteLine(a.Retrieve(-5));
            Console.Write("Retrieve elemet 15 (if 0 then no such element): ");
            Console.WriteLine(a.Retrieve(15));
            Console.Write("Search elemet -5: ");
            Console.WriteLine(a.Search(-5));
            Console.Write("Search elemet 15: ");
            Console.WriteLine(a.Search(15));
            Console.WriteLine("Deleting elements -4 and 2");
            a.DeleteItem(-4);
            a.DeleteItem(2);
            a.Print();

        }
    }
}
