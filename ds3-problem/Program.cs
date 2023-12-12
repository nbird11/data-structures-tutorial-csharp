using ds3_implementation;

namespace ds3_problem;

internal static class TreeProblem
{
    private static bool IsBalanced(BinarySearchTree bst)
    {
        // TODO Return true if root is null or each node is balanced
        return false;
    }
    
    private static bool IsBalanced(Node? node)
    {
        // TODO Return true if the node is null
        
        // TODO Get the height of the left branch
        
        // TODO Get the height of the right branch

        // TODO Return true if the distance between the left and right heights is less than 2 and both child nodes are balanced
        return false;

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