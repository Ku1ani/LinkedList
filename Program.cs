using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyNodeList nodeLIst = new MyNodeList();
            nodeLIst.Add("Ferrari");
            nodeLIst.Add(0,"Mercedes Benz");
            nodeLIst.Add("Porshe");
            nodeLIst.Add(1,"BMW");
            nodeLIst.Add("Golf");
            nodeLIst.Add(2,"Audi");

            nodeLIst.Remove(3);
            nodeLIst.Print();
        }
    }
}
