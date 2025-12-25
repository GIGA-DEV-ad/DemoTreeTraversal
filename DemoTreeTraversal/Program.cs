// See https://aka.ms/new-console-template for more information
using DemoTreeTraversal;

Console.WriteLine("Hello, Trees");

// Create tree structure
TreeNode rootA = new TreeNode("A");
var bNode = new TreeNode("B");
rootA.AddChild(bNode);
rootA.AddChild(new TreeNode("C"));
bNode.AddChild(new TreeNode("D"));
bNode.AddChild(new TreeNode("E"));
rootA.GetChild(rootA.Children.Count-1).AddChild(new TreeNode("F"));


// Print the tree
TreeMethods.PrintTree(rootA);