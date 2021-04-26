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

        public bool isFull()
        {
            return length > last;
        }

        public bool isEmpty()
        {
            return last == -1;
        }

        public int getLength()
        {
            return length;
        }




    }
}
