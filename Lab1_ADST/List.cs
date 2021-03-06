using System;
using System.Linq;
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

                if (current == first && item.CompareTo(current.data) <= 0) // insert to the first position
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

        public T DeleteItem(T item)
        {
            if (!Search(item))
            {
                Console.WriteLine("There is no such element in the list");
                return default(T);
            }
            else if (IsEmpty())
            {
                Console.WriteLine("There is an empty list");
                return default(T);
            }


            Node<T> current = first;
            Node<T> previous = null;

            while (!item.Equals(current.data) && current.next != null) // find right element
            {
                previous = current;
                current = current.next;
            }

            if (current == first && item.Equals(current.data)) // delete from first position
            {
                first = current.next;
                _count--;
                return current.data;
            }
            else // delete from other positions
            {
                previous.next = current.next;
                _count--;
                return current.data;
            }
        } // DeleteItem

        public void MakeEmpty()
        {
            first = null;
            _count = 0;
        } // MakeEmpty

        public int SumItems(Node<int> current)
        {
            if (current == null)
                return 0;
            else
                return current.data + SumItems(current.next);
        } // SumItems

        public void FindSeqences(List<int> first, List<int> second, List<int> third)
        {
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int[] res = new int[3] { 0, 0, 0 };
            

            Node<int> n = first.first;
            int num = n.data;
            int data = n.data;
            while (n != null)
            {
                if (n.next != null && n.data == num && n.next.data == num + 1)
                {
                    if (num == data)
                        count1 = 1;
                    else
                        count1++;
                    num++;
                } else if (n.next != null)
                {
                    num = n.next.data;
                    data = n.next.data;
                    if (count1 > res[0])
                        res[0] = count1;
                }

                n = n.next;
            }

            n = second.first;
            num = n.data;
            data = n.data;
            while (n != null)
            {
                if (n.next != null && n.data == num && n.next.data == num + 1)
                {
                    if (num == data)
                        count2 = 1;
                    else
                        count2++;
                    num++;
                }
                else if (n.next != null)
                {
                    num = n.next.data;
                    data = n.next.data;
                    if (count2 > res[1])
                        res[1] = count2;
                }

                n = n.next;
            }

            n = third.first;
            num = n.data;
            data = n.data;
            while (n != null)
            {
                if (n.next != null && n.data == num && n.next.data == num + 1)
                {
                    if (num == data)
                        count3 = 1;
                    else
                        count3++;
                    num++;
                }
                else if (n.next != null)
                {
                    num = n.next.data;
                    data = n.next.data;
                    if (count3 > res[2])
                        res[2] = count3;
                }

                n = n.next;
            }



            foreach(int i in res)
            {
                Console.WriteLine(i + 1);
            }

            Console.WriteLine("Max Seqence: {0}", res.Max() + 1);
            

        }


        public void Add(T item)
        {
            if (first == null)
                first = new Node<T>(item);
            else
                Add_rec(item, first);
        }

        public void Add_rec(T item, Node<T> n)
        {
            if (n.next == null)
                n.next = new Node<T>(item);
            else
                Add_rec(item, n.next);
        }

        public void Delete(int k)
        {

            Node<T> current = first;
            Node<T> previous = null;
            for (var i = 1; i <= k; i++)
            {
                if (i == k && current == first)
                {
                    first = current.next;
                    return;
                }
                else if (i == k)
                {
                    previous.next = current.next;
                    return;
                }

                previous = current;
                current = current.next;

            }

        }


    } // List

}
