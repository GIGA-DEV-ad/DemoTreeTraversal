using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTreeTraversal
{
    public class TreeNode
    {
        public string Value { get; set; }
        public List<TreeNode> Children { get; set; }
        public TreeNode(string value)
        {
            Value = value;
            Children = new List<TreeNode>();
        }
        public TreeNode(char value)
        {
            Value = value.ToString();
            Children = new List<TreeNode>();
        }

        public void AddChild(TreeNode child)
        {
            Children.Add(child);
        }

        public void RemoveChild(TreeNode child)
        {
            Children.Remove(child);
        }

        public TreeNode GetChild(int index)
        {
            if(index < 0 || index >= Children.Count)
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            return Children[index];
        }

        public int FindChildIndex(TreeNode child)
        {
            return Children.IndexOf(child);
        }

        public TreeNode FindNode(string value)
        {
            if (Value == value)
                return this;
            foreach (var child in Children)
            {
                var result = child.FindNode(value);
                if (result != null)
                    return result;
            }
            return null;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}


