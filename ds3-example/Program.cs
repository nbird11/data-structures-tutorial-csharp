using ds3_implementation;

namespace ds3_example;

internal static class TreeExample
{
    // Public method to create a balanced BST from a sorted array
    private static BinarySearchTree CreateBalancedBst(int[] arr)
    {
        // Make sure arr is sorted
        Array.Sort(arr);
        
        // Create new BST
        var bst = new BinarySearchTree
        {
            // Call the private recursive method
            Root = CreateBalancedBst(arr, 0, arr.Length - 1)
        };

        // Return the now full BST
        return bst;
    }

    // Private recursive method to create a balanced BST from a sorted array
    private static Node? CreateBalancedBst(int[] arr, int start, int end)
    {
        // Base case: if the start index is greater than the end index, return null
        if (start > end)
        {
            return null;
        }

        // Find the middle index of the subarray
        int mid = (start + end) / 2;

        // Create a new node with the middle element and insert it as the root
        var node = new Node(arr[mid]);
        node.Insert(arr[mid]);

        // Recursively create the left and right subtrees with the left and right sub-arrays
        node.Left = CreateBalancedBst(arr, start, mid - 1);
        node.Right = CreateBalancedBst(arr, mid + 1, end);

        // Return the node
        return node;
    }

    internal static void Main()
    {
        var array = new[] { 1, 2, 3, 4, 5 };
        Console.WriteLine("Array: [" + string.Join(", ", array) + "]");
        var bst = CreateBalancedBst(array);
        Console.WriteLine("BST: " + bst);
        
        var array2 = new[] { 38, 57, 29, 5, 28, 4 };
        Console.WriteLine("Array: [" + string.Join(", ", array2) + "]");
        var bst2 = CreateBalancedBst(array2);
        Console.WriteLine("BST: " + bst2);
    }
}