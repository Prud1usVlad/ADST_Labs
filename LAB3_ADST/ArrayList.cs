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
    }
}
