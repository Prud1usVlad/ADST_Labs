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
            a.Add(1);
            a.Add(2);
            a.Add(3);
            a.Add(4);
            a.Add(5);
            a.Add(6);
            a.Add(7);
            a.Add(8);
            a.Print();
            a.Delete(8);
            a.Print();
            

            

        }
    }
}
