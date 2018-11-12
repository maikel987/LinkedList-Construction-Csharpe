using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject
{
    class MyLinkedList<Mytype> : IEnumerable<Mytype>
    {
        Node start; //null by default
        Node end;   //null by default
        public int count { get; internal set; }

        public bool RemoveLast(out Mytype saveData)
        {
            saveData = default(Mytype);

            if (end == null)
                return false;
            saveData = end.data;
            end = end.previous;
            if (end == null) start = null;
            else end.next = null; 
            count--;
            return true;
        }

        public bool ElementAt(int i, out Mytype value) //0 based
        {
            int count = 0;
            Node tmp = start;
            while (tmp != null)
            {                
                if (count == i)
                {
                    value = tmp.data;
                    return true;
                }
                count++;
                tmp = tmp.next;
            }
            value = default(Mytype);
            return false;
        }

        public void AddFirst(Mytype newItem)
        {
            
            Node tmp = new Node(newItem);
            tmp.next = start;
            if (start == null)
                end = tmp;            
            start = tmp;
            tmp.previous = null; // ou start?
            if (tmp.next != null) tmp.next.previous = tmp;
            count++;      
        }
        
        public string PrintAll()
        {
            StringBuilder strg = new StringBuilder();
            Node tmp = start;
            while(tmp != null)
            {
                strg.AppendLine(tmp.data.ToString());
                tmp = tmp.next;
            }
            return strg.ToString();
        }


        public bool RemoveFirst(out Mytype saveData)
        {
            saveData = default(Mytype);

            if (start == null)
                return false;
            saveData = start.data;
            start = start.next;
            if (start == null) end = null;
            else start.previous = null; 
            count--;
            return true;
        }

        public void AddToEnd(Mytype newItem)
        {
            if (start == null)
            {
                AddFirst(newItem);
                return;//ends the function without returning value
            }
            //explicit else
            Node tmp = new Node(newItem);
            tmp.previous = end;
            end.next = tmp;
            end = tmp;
            
            count++;
        }



        public IEnumerator<Mytype> GetEnumerator()
        {
            //return new MyLinkedListEnumerator(start);
            Node tmp = start;
            while (tmp!= null)
            {
                yield return tmp.data;
                tmp = tmp.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        
        class Node
        {
            public Mytype data;
            public Node next; //null by default
            public Node previous;

            public Node(Mytype data)
            {
                this.data = data;
            }
        }
    }
}
