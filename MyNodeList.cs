using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class MyNodeList
    {
        private Node headNode;
        private int count;

        public MyNodeList()
        {
            this.headNode = null;
            this.count = 0;
        }

        public bool Empty 
        {
            get { return this.count == 0 ; }
        }

        public int Count 
        {
            get { return this.count; } 
        }

       public object Add(int index, object o)
       {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index: " + index);

            if (index > count)
                index = Count;

            Node current = this.headNode;

            if (this.Empty || index == 0)
            {
                this.headNode = new Node(o, this.headNode);
            }
            else
            {
                for (int i = 0; i < index - 1; i++)                
                    current = current.Next;

                current.Next = new Node(o, current.Next);
            }

            count++;

            return o;
       }

        public object Add(object o)
        {
            return this.Add(Count, o);
        }

        public object Remove(int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index: " + index);

            if (this.Empty)
                return null;

            if (index > this.count)
                index = count - 1;

            Node current = this.headNode;
            object result = null;

            if (index == 0)
            {
                result = current.Data;
                this.headNode = current.Next;
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                    current = current.Next;

                result = current.Next.Data;

                current.Next = current.Next.Next;
            }
            count--;

            return result;
                
        }

        public void Print()
        {
            if (headNode != null)
            {
                headNode.Print();
            }
        }
    }
}
