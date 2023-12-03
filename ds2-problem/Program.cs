namespace ds2_problem;

internal static class LinkedListProblem
{
    private static LinkedList<T>? ReverseLinkedList<T>(LinkedList<T> forwardList)
    {
        // TODO Create a new linked list to store the reversed elements
        
        
        // TODO Come up with a way to reverse the elements in the list
        foreach (var item in forwardList)
        {
            
        }

        // TODO Return the reversed list   
        return null;
    }
    
    private static void Main()
    {
        var originalList = new LinkedList<int>(new[] { 1, 2, 3, 4, 5 });
        Console.WriteLine("Original List: " + string.Join(" -> ", originalList));
        var reversedList = ReverseLinkedList(originalList);
        Console.WriteLine("Reversed List: " + string.Join(" -> ", reversedList!));

        originalList = new LinkedList<int>(new[] { 4, 53, 26, 18, 7 });
        Console.WriteLine("Original List: " + string.Join(" -> ", originalList));
        reversedList = ReverseLinkedList(originalList);
        Console.WriteLine("Reversed List: " + string.Join(" -> ", reversedList!));
    }
}