using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimeBrokerageTest
{
    class LinkedList
    {
        private Node _first;
        private Node _last;

        internal int Count
        {
            get { return CountNodes(_first); }
        }

        int CountNodes(Node node)
        {
             int result = 0;

           if(node == null)
           { return 0; }

    
           result += 1;

            return result += CountNodes(node._next);
        }



        internal string PrintLinkedList()
        {
            return PrintLL(_first);
        }


        internal string PrintLinkedList_RandomNode()
        {
            return PrintLL(_first);
        }

        private string PrintLL(Node node)
        {
            if (node == null)
                return "";

            return node._id + " " + PrintLL(node._next);
        }

        internal void AddLast(int id)
        {
            if(_first == null)
            {
                _first = new Node(id);
                _last = _first;
                _last._prev = _first;
                _first._next = _last;
            }
            else
            {
                _last._next = new Node(id);
                _last._next._prev = _last;
                _last = _last._next; 
            }
        }

        //internal void AddFirst(int id)
        //{
        //    //var temp = _first;

        //    //_first = new Node(id) {_next = temp};
        //}  
    }

    class Node
    {
        internal int _id;

        internal Node _prev; 
        internal Node _next; 

        internal Node(int id)
        {
            _id = id;
        }
    }
}
