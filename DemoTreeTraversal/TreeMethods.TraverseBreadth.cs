using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTreeTraversal
{
    public partial class TreeMethods
    {
        public static void TraverseBreadth(TreeNode node, Action<TreeNode> action)
        {
            if (node == null || action == null)
                return;           
            foreach (var child in node.Children)
            {
                TraverseBreadth(child, action);
            }
            action(node);
        }
    }
}
