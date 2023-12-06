# Linked List

## Introduction

A linked list is a way of organizing information in a sequence, kind of like a chain of connected items. Each 'item' in
this chain contains some data and a connection to the next item. Unlike a list where everything is lined up in a fixed
order, a linked list allows you to add or remove items easily, making it more flexible.

## Structure

### Node

The `node` is the fundamental building block of a linked list. It is the 'item' when we refer to a linked list as a
'chain of connected items.' Nodes typically consist of three components:

- **Data:** The actual information stored in the node.
- **Next:** A reference to the next node in the sequence.
- **(Previous):** Only for doubly linked lists (linked lists that can be traversed backwards as well as forwards); a
reference to the previous node.

### Head

The `head` is the first 'item' (node) in the linked list. It serves as the entry point for traversing the list.

### Tail

The `tail` is the last node in the linked list. Its `next` reference is usually null, indicating the end of the list.
(In doubly linked lists, it is also the entry point for reversed traversal of the 'items' [nodes]. In these cases, the
`previous` reference of the `head` would be null to indicate the beginning of the list.)

## Operations

### Insertion

- **Insert at the Beginning:** Add a new node at the beginning of the linked list.
- **Insert at the End:** Add a new node at the end of the linked list.
- **Insert at a Specific Position:** Add a new node at a specified position in the linked list.

### Deletion

- **Delete from the Beginning:** Remove the first node from the linked list.
- **Delete from the End:** Remove the last node from the linked list.
- **Delete from a Specific Position:** Remove a node from a specified position in the linked list.

### Traversal

Traverse the linked list to access and manipulate its elements.

## Efficiency of Common Operations

- **Insertion/Deletion:** O(1) for operations at the _beginning_ or _end_ of the list, O(n) for operations at a
specific position.
- **Traversal:** O(n), where n is the number of elements in the linked list.

## Benefits

- **Smart Memory Use:** Imagine a bag that expands or shrinks based on the amount of items you put inside. Linked lists
are like that. They use computer memory efficiently, so you don't waste any space.
- **Easy Adding and Removing:** It's really easy and efficient to add items to the beginning or the end of a linked
list. It's kind of like a train where you can easily add or remove a car to the front or the back, but it gets a
little bit more tricky to add a car to the middle.

## Uses

- **Shopping List:** You can easily add items as you think of them and cross them off as you get them. The order can
change, and it's easy to manage.
- **Playlist:** You can add songs to the beginning or end, remove them, or even shuffle the order to keep things
interesting.
- **To-Do List:** You can add new tasks, mark them as done, and rearrange their order based on priorities.

## Example

Let's explore a simple example using a singly linked list in C#:

```csharp
private static void Main()
{
    // Create a linked list of party guests
    var guestList = new LinkedList<string>();

    // Add guests to the linked list
    guestList.AddLast("Alice");
    guestList.AddLast("Bob");
    guestList.AddLast("Charlie");

    // Print information about the current state of the linked list
    Console.WriteLine("First guest: " + guestList.First.Value);  // Alice
    Console.WriteLine("Last guest: " + guestList.Last.Value);    // Charlie
    Console.WriteLine("Number of guests: " + guestList.Count);   // 3

    // Insert a new guest in the middle
    var node = guestList.Find("Bob");
    guestList.AddAfter(node, "David");

    // Print updated information
    Console.WriteLine("Guest after Bob: " + node.Next.Value);    // David
    Console.WriteLine("Number of guests after insert: " + guestList.Count);  // 4

    // Remove a guest
    guestList.Remove("Bob");

    // Print final state of the linked list
    Console.WriteLine("Updated last guest: " + guestList.Last.Value);  // David
    Console.WriteLine("Number of guests after removal: " + guestList.Count);  // 3
}
```

## Problem to Solve: Reverse a Linked List

Write a C# function to reverse a given singly linked list.

Example: 
- Input:  1 -> 2 -> 3 -> 4 -> 5
- Output: 5 -> 4 -> 3 -> 2 -> 1
- 
- Input: 4 -> 53 -> 26 -> 18 -> 7
- Output 7 -> 18 -> 26 -> 53 -> 4

Test your code by creating a linked list, displaying it, and then reversing it. Verify that the reversed linked list is correctly displayed.

You can check your code with the solution here: [Solution](ds2-solution/Program.cs)

[Back to Welcome Page](0-welcome.md)