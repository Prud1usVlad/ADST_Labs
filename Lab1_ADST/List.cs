using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_ADST
{
    class List<T> where T: IComparable<T>
    {
        public Node<T> first;
        private int _count;

        public List()
        {
            first = null;
            _count = 0;
        } // constructor 

        public int ListSize() { return _count; }
    }
}
