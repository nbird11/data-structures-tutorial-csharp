using ds3_implementation;

namespace ds3_solution;

internal static class TreeSolution
{
    private static bool IsBalanced(BinarySearchTree bst)
    {
        // BST is balanced if root is null or each node is balanced
        return bst.Root is null || IsBalanced(bst.Root);
    }
    
    private static bool IsBalanced(Node? node)
    {
        if (node is null) return true;
        
        // Get heights of left and right branches
        int heightLeft = node.Left?.GetHeight() ?? 0;
        int heightRight = node.Right?.GetHeight() ?? 0;

        // Node is balanced if distance between the branch heights is less than 2 and both child nodes are balanced
        return Math.Abs(heightLeft - heightRight) < 2 && IsBalanced(node.Left) && IsBalanced(node.Right);

    }

    internal static void Main()
    {
        /* Balanced tree
         *     2
         *    / \
         *   1   3
         */
        var balancedTree = new BinarySearchTree();
        balancedTree.Insert(2);
        balancedTree.Insert(1);
        balancedTree.Insert(3);
        Console.WriteLine("Is Balanced: " + IsBalanced(balancedTree)); // Output: True

        /* Unbalanced tree
         *     2
         *    / \
         *   1   3
         *        \
         *         4
         *          \
         *           5
         */
        var unbalancedTree = new BinarySearchTree();
        unbalancedTree.Insert(2);
        unbalancedTree.Insert(1);
        unbalancedTree.Insert(3);
        unbalancedTree.Insert(4);
        unbalancedTree.Insert(5);
        Console.WriteLine("Is Balanced: " + IsBalanced(unbalancedTree)); // Output: False
    }
}