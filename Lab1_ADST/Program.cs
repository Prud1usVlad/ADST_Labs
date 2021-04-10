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
            a.Add(3);
            a.Add(5);
            a.Add(3);
            a.Add(5);
            a.Add(3);
            a.Add(5);
            a.Add(3);
            a.Add(5);
            a.Print();
            

            

        }
    }
}
