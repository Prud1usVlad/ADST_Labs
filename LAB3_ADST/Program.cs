using System;

namespace LAB3_ADST
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new ArrayList<int>(10);
            a.Add(11);
            a.Add(7);
            a.Add(88);
            a.Add(96);
            a.Add(54);
            a.Add(31);
            a.Add(23);
            a.Add(13);
            a.Add(45);
            a.Add(69);

            a.SettleRootDesc(1, a.last);
            a.Print();
            a.MakeMinHeap(a.last);
            a.Print();
            a.HeapSortDescending(a.last);
            a.Print();
        }
    }
}
