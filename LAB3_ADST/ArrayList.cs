using System;
using System.Collections.Generic;
using System.Text;

namespace LAB3_ADST
{
    class ArrayList<T> where T: IComparable
    {
        private int length;

        public int last;

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
            last = 0;
            array = new T[size + 1];
            array[0] = default(T);
        }

        public bool IsFull()
        {
            return length <= last;
        }

        public bool IsEmpty()
        {
            return last == 0;
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
            for (int i = 1; i <= last; i++)
                Console.Write(array[i] + " | ");

            Console.WriteLine("");
        }
        
        public void SettleRoot(int root, int last)
        {
            int child, unsettled = root;
            // While unsettned not a leaf
            while (2 * unsettled <= last)
            {
                if (2 * unsettled < last && array[2 * unsettled + 1].CompareTo(array[2 * unsettled]) > 0)
                    child = 2 * unsettled + 1;  // The right child has a larger key.
                else child = 2 * unsettled;     // The left child has a larger key.

                if (array[unsettled].CompareTo(array[child]) < 0)
                {
                    T z = array[unsettled];
                    array[unsettled] = array[child];
                    array[child] = z;
                    unsettled = child;
                }
                else break;
            }
        }

    }
}
