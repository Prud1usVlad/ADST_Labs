using System;
using System.Collections.Generic;
using System.Text;

namespace LAB3_ADST
{
    class ArrayList<T>
    {
        private int length;

        private int count;

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
            count = 0;
            array = new T[size];
        }

        public bool isFull()
        {
            return length > count;
        }

        public int getLength()
        {
            return length;
        }




    }
}
