using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_ADST
{
    class List<T> where T: IComparable<T>
    {
        public Node<T> first;
        private int _Count { get; set; }

        public List()
        {
            first = null;
            _Count = 0;
        } // constructor 
    }
}
