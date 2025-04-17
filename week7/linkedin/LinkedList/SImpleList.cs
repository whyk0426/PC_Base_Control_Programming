using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }

    public Node(int data, SimpleList slist) // 만들면서 뒤로 붙임
    {
        Data = data;
        Next = null;
        slist.Append(this);  //<-- this가 반드시 필요한 사례
    }
}
    class SimpleList
    {
        private Node head = null;

        //-----------------------------
        public void Prepend(Node node)
        {
            if (head == null)
            {
                node.Next = null;   // 혹시나
                head = node;
            }
            else
            {
                node.Next = head;
                head = node;
            }
        }

        //-----------------------------
        public void Append(Node node)
        {
            if (head == null)
            {
                node.Next = null;
                head = node;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.Next = node;
                node.Next = null;
            }
        }

        private Node GetLastNode()
        {
            if (head == null)
                return null;
            else
            {
                Node node = head;
                while (node.Next != null)
                {
                    node = node.Next;
                }
                return node;
            }
        }

        //-----------------------------
        public Node FindNodeOfData(int data)
        {
            if (head == null) return null;

            for (Node n = head; n != null; n = n.Next)
            {
                if (n.Data == data) return n;
            }
            return null;
        }

        //-----------------------------
        public void Remove(Node node)
        {
            if (head == null) return;   // 이상 상황
            for (Node n = head; n != null; n = n.Next)
            {
                if (n == node)
                {
                    if (n == head) head = head.Next;
                    else
                    {
                        Node prev = head;
                        while (prev.Next != n) prev = prev.Next;
                        prev.Next = n.Next;
                    }
                    break;
                }
            }
        }

        //-----------------------------
        public void Clear()
        {
            head = null;
        }

        //-----------------------------
        public SimpleList Reverse()
        {
            SimpleList reverselist = new SimpleList();
            if (head == null) return reverselist;

            while (head != null)
            {
                Node n = head;
                this.Remove(n);
                reverselist.Prepend(n);
            }

            return reverselist;
        }

        //-----------------------------
        public string Print()
        {
            if (head == null) return "--- Empty --- \r\n";

            string st = "";
            for (Node n = head; n != null; n = n.Next)
            {
                st += n.Data.ToString() + "\r\n";
            }
            st += "--- END --- \r\n";
            return st;
        }
    }
}
