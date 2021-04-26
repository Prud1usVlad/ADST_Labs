using System;
using System.Collections.Generic;
using System.Text;

namespace LAB3_ADST
{
    class ArrayList<T>
    {
        private int length;

        private int last;

        private T[] array;
       
        
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


    }
}
