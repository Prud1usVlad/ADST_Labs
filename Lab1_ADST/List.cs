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

        public bool IsEmpty()
        {
            return (first == null) ? true : false;
        } // IsEmpty

        public void AddItem(T item) // keeps list sorted
        {

            if (IsEmpty()) // insert very first item 
            {
                first = new Node<T>(item);
                _count++;
            }
            else
            {
                Node<T> current = first;
                Node<T> previous = null;

                while (current != null && item.CompareTo(current.data) > 0)
                {
                    previous = current;
                    current = current.next;
                }

                if (current == first && item.CompareTo(current.data) <= 0) // insertt to the first position
                    if (current == first && item.CompareTo(current.data) <= 0) // insrrt to the first position
                        first = new Node<T>(item, current);
                    else  // insert to the last and middle position
                        previous.next = new Node<T>(item, current);

                _count++;
            }
        } // AddItem



        public void Print()
        {
            Node<T> n = first;
            Console.WriteLine("List content: ");
            if (IsEmpty())
                Console.WriteLine("List is empty.");
            else
            {
                while (n != null)
                {
                    Console.Write($"| {n.data} ");
                    n = n.next;
                }

                Console.WriteLine("|");
            }

            Console.WriteLine("___________________________________________");
        } // Print

        public bool Search(T item)
        {
            Node<T> n = first;

            while (n != null)
            {
                if (n.data.Equals(item))
                    return true;

                n = n.next;
            }

            return false;
        } // Search

        public T Retrieve(T item) // finds and returns item
        {
            Node<T> n = first;


            while (n != null)
            {
                if (n.data.Equals(item))
                    return n.data;

                n = n.next;
            }

            return default(T);
        } // Retrieve

    } // List

}
