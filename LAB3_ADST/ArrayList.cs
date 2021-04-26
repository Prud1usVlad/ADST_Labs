using System;
using System.Collections.Generic;
using System.Text;

namespace LAB3_ADST
{
    class ArrayList<T>
    {
        private T[] array;
        
        public T this[int index]
        {
            get
            {
                return array[index];
            }
        }
    }
}
