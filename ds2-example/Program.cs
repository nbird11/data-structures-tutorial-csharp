namespace ds2_example;

internal static class LinkedListExample
{
    internal static void Main()
    {
        // Create a linked list of party guests
        var guestList = new LinkedList<string>();

        // Add guests to the linked list
        guestList.AddLast("Alice");
        guestList.AddLast("Bob");
        guestList.AddLast("Charlie");

        // Print information about the current state of the linked list
        Console.WriteLine("First guest: " + guestList.First!.Value);  // Alice
        Console.WriteLine("Last guest: " + guestList.Last!.Value);    // Charlie
        Console.WriteLine("Number of guests: " + guestList.Count);   // 3

        // Insert a new guest in the middle
        var node = guestList.Find("Bob");
        guestList.AddAfter(node!, "David");

        // Print updated information
        Console.WriteLine("Guest after Bob: " + node!.Next!.Value);    // David
        Console.WriteLine("Number of guests after insert: " + guestList.Count);  // 4

        // Remove a guest
        guestList.Remove("Bob");

        // Print final state of the linked list
        Console.WriteLine("Updated last guest: " + guestList.Last.Value);  // David
        Console.WriteLine("Number of guests after removal: " + guestList.Count);  // 3
    }
}
