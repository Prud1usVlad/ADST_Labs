using System;

namespace Lab1_ADST
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new List<int>();
            var b = new List<int>();
            var c = new List<int>();
            Console.Write("List empty: ");
            Console.WriteLine(a.IsEmpty());
            a.AddItem(1);
            a.AddItem(2);
            a.AddItem(6);
            a.AddItem(5);
            a.AddItem(9);
            a.AddItem(4);
            a.AddItem(7);
            a.AddItem(9);
            a.Print();
            b.AddItem(1);
            b.AddItem(2);
            b.AddItem(-2);
            b.AddItem(5);
            b.AddItem(8);
            b.AddItem(25);
            b.AddItem(7);
            b.AddItem(9);
            b.Print();
            c.AddItem(1);
            c.AddItem(2);
            c.AddItem(6);
            c.AddItem(5);
            c.AddItem(8);
            c.AddItem(25);
            c.AddItem(7);
            c.AddItem(9);
            c.Print();
            c.FindSeqences(a, b, c);
            

            

        }
    }
}
