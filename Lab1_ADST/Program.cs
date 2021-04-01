using System;

namespace Lab1_ADST
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new List<int>();

            a.AddItem(14);
            a.AddItem(0);
            a.AddItem(-45);
            a.Print();
            Console.WriteLine(a.Search(-45));
            Console.WriteLine(a.Search(-4));
            a.DeleteItem(0);
            Console.WriteLine(a.Retrieve(15));
            Console.WriteLine(a.Retrieve(-45));
            a.Print();
            a.MakeEmpty();
            a.Print();
            Console.WriteLine(a.ListSize());
            
        }
    }
}
