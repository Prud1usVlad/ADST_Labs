using System;
using System.Collections.Generic;
using System.Text;

namespace LAB3_ADST
{
    class ArrayList<T> where T: IComparable
    {
        private int length;

        private int last;

        public T[] array;
       
        
        public T this[int index]
        {
            get
            {
                return array[index];
            }
        }

        public ArrayList(int size)
        {
            length = size;
            last = -1;
            array = new T[size];
        }

        public bool IsFull()
        {
            return length <= last + 1;
        }

        public bool IsEmpty()
        {
            return last == -1;
        }

        public int GetLength()
        {
            return length;
        }

        public void Add(T item)
        {
            if (!IsFull())
                array[++last] = item;

            else
                Console.WriteLine("List is full");
        }

        public void Print()
        {
            Console.Write("| ");
            for (int i = 0; i <= last; i++)
                Console.Write(array[i] + " | ");

            Console.WriteLine("");
        }

        private void SettleRoot(T[] L, int root, int last)
        {
            int child, unsettled = root;
            while (2 * unsettled <= last)           // A current unsettled root is not a leaf.
            {
                if (2 * unsettled < last && L[2 * unsettled + 1].CompareTo(L[2 * unsettled]) > 0)
                    child = 2 * unsettled + 1;  // The right child has a larger key.
                else child = 2 * unsettled;     // The left child has a larger key.

                if (L[unsettled].CompareTo(L[child]) < 0)
                {
                    T z = L[unsettled];
                    L[unsettled] = L[child];
                    L[child] = z;
                    unsettled = child;
                }
                else break;
            }//while
        }//SettleRoot

        public void Heapsort(T[] L, int N)
        {
            int n = N - 1;              // n is heap size. L[0] is not used.
            for (int i = n / 2; i >= 1; i--)        // heap construction loop
                SettleRoot(L, i, n);
            for (int end = n - 1; end >= 1; end--)  // actual sorting loop
            {
                T z = L[1];
                L[1] = L[end + 1];
                L[end + 1] = z;

                SettleRoot(L, 1, end);
            }
        }//Heapsort



    }
}
