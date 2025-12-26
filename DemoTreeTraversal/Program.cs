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
rootA.GetChild(rootA.Children.Count - 1).AddChild(new TreeNode("F"));


// Print the tree
TreeMethods.PrintTree(rootA);


Action<TreeNode> actionPrint = n => Console.Write(n.Value + ",");
// 
Console.WriteLine("\nDepth-First Traversal:");
TreeMethods.TraverseDepth(rootA, actionPrint);

Console.WriteLine("\n\nBreadth-First Traversal:");
TreeMethods.TraverseBreadth(rootA, actionPrint);


Console.WriteLine("\n\nCounting Nodes:");
int counter = 0;
Action<TreeNode> actionCount = n => counter++;


rootA = await TreeNode.GenerateAlphabetTree();

TreeMethods.TraverseDepth(rootA, actionCount);
TreeMethods.PrintTree(rootA);
Console.WriteLine($"\nTotal nodes: {counter}");

