using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            



            

            MyLinkedList<string> lst = new MyLinkedList<string>();
            
            lst.AddFirst("1");
            lst.AddFirst("2");
            lst.AddFirst("3");
            lst.AddFirst("4");
            lst.AddFirst("5");
            lst.AddToEnd("e1");
            lst.AddToEnd("e2");
            //lst.RemoveLast

            for (int i = 0; i < 5; i++)
            {

            
                string data;
                bool ElemAt = lst.ElementAt(2,out data);
                if(ElemAt)
                {
                    Console.WriteLine("value of researched item is {0}",data);
                }
                bool isRemoveLast = lst.RemoveLast( out data);
                if (isRemoveLast)
                {
                    Console.WriteLine("value of remove last item is {0}", data);
                }
                bool isRemoveFirst = lst.RemoveFirst(out data);
                if (isRemoveFirst)
                {
                    Console.WriteLine("value of remouve first item is {0}", data);
                }
           

                Console.WriteLine(lst.PrintAll());

                //foreach (string item in lst)
                //{
                //    string baba = item;
                //    Console.WriteLine(   baba = "hey " + baba);

                //}
            }








        }
    }
}
