using System;

namespace LAB3_ADST
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new ArrayList<int>(4);
            Console.WriteLine(a.GetLength());

            a.Add(4);
            a.Add(9);
            a.Add(0);
            a.Add(13);
            a.Add(12);
        }
    }
}
