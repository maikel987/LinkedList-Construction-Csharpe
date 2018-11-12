using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    class Program
    {
        static void Main(string[] args)
        {            
            int size = 1000000;
            int[] a = new int[size];
            Random r = new Random();

            for (int i = 0; i < size; i++)
            {
                a[i] = r.Next(size * 3);
                //Console.Write("{0} ", a[i]);
            }
            DateTime st = DateTime.Now;
            Sorts.MergeSort(a);
            DateTime et = DateTime.Now;
            Console.WriteLine();
            //for (int i = 0; i < size; i++)
            //{                
            //    Console.Write("{0} ", a[i]);
            //}
            Console.WriteLine("\n{0}", et.Subtract(st).TotalMilliseconds);
        }


    }
}
