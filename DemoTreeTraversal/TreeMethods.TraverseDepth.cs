using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTreeTraversal
{
    public partial class TreeMethods
    {
        public static void TraverseDepth(TreeNode node, Action<TreeNode> action)
        {
            if (node == null || action == null)
                return;
            action(node);
            foreach (var child in node.Children)
            {
                TraverseDepth(child, action);
            }
        }
    }
}
