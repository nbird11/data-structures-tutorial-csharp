namespace ds2_solution;

internal static class LinkedListSolution
{
    private static LinkedList<T> ReverseLinkedList<T>(LinkedList<T> forwardList)
    {
        // Create a new linked list to store the reversed elements
        var reversedList = new LinkedList<T>();

        // Traverse the original list and add elements to the new list at the beginning
        foreach (var item in forwardList)
        {
            reversedList.AddFirst(item);
        }

        return reversedList;
    }
    
    private static void Main()
    {
        var originalList = new LinkedList<int>(new[] { 1, 2, 3, 4, 5 });
        Console.WriteLine("Original List: " + string.Join(" -> ", originalList));
        var reversedList = ReverseLinkedList(originalList);
        Console.WriteLine("Reversed List: " + string.Join(" -> ", reversedList));

        originalList = new LinkedList<int>(new[] { 4, 53, 26, 18, 7 });
        Console.WriteLine("Original List: " + string.Join(" -> ", originalList));
        reversedList = ReverseLinkedList(originalList);
        Console.WriteLine("Reversed List: " + string.Join(" -> ", reversedList));
    }
}