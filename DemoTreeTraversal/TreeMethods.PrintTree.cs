using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTreeTraversal
{
    public partial class TreeMethods
    {
        static char boxLeftLowerCorner = '└'; 
        public static void PrintTree(TreeNode node, string indent = "")
        {
            Console.WriteLine(indent + node.Value);
            foreach (var child in node.Children)
            {
                PrintTree(child, indent.Replace(boxLeftLowerCorner,' ') + boxLeftLowerCorner + " " );
            }
        }
    }
}
