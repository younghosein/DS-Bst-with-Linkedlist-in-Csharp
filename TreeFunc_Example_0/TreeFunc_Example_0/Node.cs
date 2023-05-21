using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeFunc_Example_0
{
    class Node
    {
        public int data;
        public Node right, left;

        public Node(int d)
        {
            data = d;
            right = left = null;
        }

        public Node() { }
    }
}
