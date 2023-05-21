using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeFunc_Example_0
{
    class Tree
    {
        public Node root;

        public Node Add(int d)
        {
            Node nn = new Node();
            nn.data = d;
            nn.left = nn.right = null;
            return nn;
        }

        public void PrintPre(Node r)
        {
            if (r == null)
                return;
            Console.Write(r.data + " . ");
            PrintPre(r.left);
            PrintPre(r.right);
        }

        public void PrintIn(Node r)
        {
            if (r == null)
                return;
            PrintIn(r.left);
            Console.Write(r.data + " . ");
            PrintIn(r.right);
        }

        public void PrintPost(Node r)
        {
            if (r == null)
                return;
            PrintPost(r.left);
            PrintPost(r.right);
            Console.Write(r.data + " . ");
        }

        public int SumAll(Node r)
        {
            if (r == null)
            {
                return 0;
            }
            return (r.data + SumAll(r.left) + SumAll(r.right));
        }

        public int s = 0;
        public int SumOneChildNodes(Node r)
        {
            if (r == null)
            {
                return 0;
            }
            else
            {
                if (r.left != null && r.right == null || r.right != null && r.left == null)
                {
                    s += r.data;
                }
                else
                {
                    SumOneChildNodes(r.left);
                    SumOneChildNodes(r.right);
                }
                return s;
            }
        }

        public Node DelLeaves(Node r)
        {
            if (r == null)
            {
                return null;
            }
            else
            {
                if (r.left == null && r.right == null)
                {
                    return null;
                }
                else
                {
                    r.left = DelLeaves(r.left);
                    r.right = DelLeaves(r.right);
                }
                return r;
            }
        }//

        public Node DelOneChildNode(Node r)
        {
            if (r == null)
            {
                return null;
            }
            else
            {
                if (r.left != null && r.right == null || r.right != null && r.left == null)
                {
                    return null;
                }
                else
                {
                    r.left = DelOneChildNode(r.left);
                    r.right = DelOneChildNode(r.right);
                }
                return r;
            }
        }//

        public bool DelMaxInBst(Node r)
        {
            if (r == null)
            {
                return false;
            }
            Node R = r, t = null;
            while (R.right != null)
            {
                t = R;
                R = R.right;
            }
            if (t == null)
            {
                r = r.left;
            }
            else
            {
                t.right = null;
            }
            return true;
        }//

        public bool IsComplete(Node r)
        {
            if (r == null)
            {
                return true;
            }
            else
            {
                if (r.left == null && r.right == null)
                {
                    return true;
                }
                if (r.left != null && r.right != null)
                {
                    return (IsComplete(r.left) && IsComplete(r.right));
                }
                return false;
            }
        }//

        public int CountLeaves(Node r)
        {
            if (r == null)
            {
                return 0;
            }
            if (r.left == null && r.right == null)
            {
                return (1 + CountLeaves(r.left) + CountLeaves(r.right));
            }
            else
            {
                return CountLeaves(r.left) + CountLeaves(r.right);
            }
        }///

        public int CountRightOrLeftChildNodes(Node r)
        {
            if (r == null)
            {
                return 0;
            }
            if (r.left != null && r.right == null)//Farzan Chap Dar Ha
            {
                return (1 + CountRightOrLeftChildNodes(r.left) + CountRightOrLeftChildNodes(r.right));
            }
            //if (r.left != null && r.right == null)//Farzan Rast Dar Ha
            //{
            //    return (1 + CountRightOrLeftChildNodes(r.left) + CountRightOrLeftChildNodes(r.right));
            //}
            else
            {
                return CountLeaves(r.left) + CountLeaves(r.right);
            }
        }///

        public int CountOneChilOrTwoChildNodes(Node r)
        {
            if (r == null)
            {
                return 0;
            }
            if (r.left != null && r.right == null || r.left != null && r.right == null)//Tak Farzandi Ha
            {
                return (1 + CountRightOrLeftChildNodes(r.left) + CountRightOrLeftChildNodes(r.right));
            }
            //if(r.left != null && r.right != null || r.left != null && r.right != null)//Do Farzandi Ha
            //{
            //    return (1 + CountRightOrLeftChildNodes(r.left) + CountRightOrLeftChildNodes(r.right));
            //}
            else
            {
                return CountLeaves(r.left) + CountLeaves(r.right);
            }
        }///

        public int Height(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            return 1 + Math.Max(Height(root.left), Height(root.right));
        }///

    }
}
