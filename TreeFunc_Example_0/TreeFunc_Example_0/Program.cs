using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeFunc_Example_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree t = new Tree();

            t.root = t.Add(9);
            t.root.left = t.Add(8);
            t.root.right = t.Add(30);
            t.root.left.left = t.Add(4);
            t.root.left.right = t.Add(15);
            t.root.right.left = t.Add(16);
            t.root.right.right = t.Add(47);
            t.root.left.left.left = t.Add(2);
            t.root.left.right.left = t.Add(10);
            t.root.left.right.right = t.Add(20);
            t.root.right.right.right = t.Add(90);

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            /*
                                 9
                               /   \
                              8     30
                             / \   / \
                            4  15 16  47
                           /   / \     \
                          2   10 20    90
             */

            Console.Write("PreOrder Is : ");
            t.PrintPre(t.root);

            Console.Write("\nInOrder Is : ");
            t.PrintIn(t.root);

            Console.Write("\nPostOrder Is : ");
            t.PrintPost(t.root);

            //Console.Write("\nSum All Element Is : ");
            //int sa = t.SumAll(t.root);
            //Console.Write(sa);

            //Console.Write("\nSum Of One Child Elements Is : ");
            //int s = t.SumOneChildNodes(t.root);
            //Console.Write(s);

            //t.DelLeaves(t.root);
            //Console.Write("\nAfter Delete Leaves...\nPreOrder Is : ");
            //t.PrintPre(t.root);

            //t.DelOneChildNode(t.root);
            //Console.Write("\nAfter Delete One Child Element...\nPreOrder Is : ");
            //t.PrintPre(t.root);

            //t.DelMaxInBst(t.root);
            //Console.Write("\nAfter Delete Largest Element...\nPreOrder Is : ");
            //t.PrintPre(t.root);

            //bool b = t.IsComplete(t.root);
            //if (b == true)
            //    Console.WriteLine("\n<< Complete Tree >>");
            //else
            //    Console.WriteLine("\n<< UnComplete Tree >>");

            //Console.Write("\nThe Count Of Leaf Is : ");
            //int c = t.CountLeaves(t.root);
            //Console.Write(c);

            //Console.Write("\nThe Height Of Tree Is : ");
            //int h = t.Height(t.root);
            //Console.Write(h);

            Console.ReadKey();
        }
    }
}
