# Tree

## Introduction

Think of your family tree where the root is your ancestor and the children are their descendants. In computer science,
this kind of structure is useful for representing a hierarchical data, such as in your computer's file system. Computer
scientists call it a 'tree' because it resembles an inverted tree, with 'nodes' representing a piece of information,
and the connections between nodes (or 'edges') representing the relationships. Trees find applications in various
fields, so let's take a look at its structure a bit more in depth.

## Structure

### Node

At the core of a tree is the `node`. Think of a node as a person in the family tree analogy. Nodes are points in the
tree which hold some information. Each node may have zero or more 'children,' forming 'branches.'

- #### Left Child
     A reference to the child node on the left branch, if it exists.

- #### Right Child
    A reference to the child node on the right branch, if it exists.

### Root

The `root` is the topmost node of the tree, serving as the starting point for traversing the structure. Think of the
ancestor in the family tree analogy. Being at the uppermost part of the tree, the `root` has no parent nodes.

## Importance of Balancing

Balancing a tree means adjusting the structure of a tree so that the height is minimized. The height of a tree is the
length of the longest path from the root to any node that doesn't have any children nodes. A balanced tree can improve
the efficiency of operations because it reduces the number of nodes that need to be visited or compared. This ensures
that the structure remains efficient.

## Operations

### Insertion

Adding a new node to the tree.

Note: What type of tree we are working with and the value of the node can determine where a new node is added. For
example, in a binary search tree, a node with a smaller value than its parent node is inserted as the left child, and a
node with a larger value than its parent node is inserted as the right child.

### Deletion

Removing a node from the tree. To delete a node, we need to unlink it from its parent node, and then rearrange its
child nodes if any.

Note: The way of rearranging the child nodes depends on the type of the tree and the value of the node.

### Search

Locating a specific node with a given value in the tree. To search for a node, we need to compare the value of the node
with the value of the root node, and then recursively search in the left or right subtree depending on the result of
the comparison.

For example, in a binary search tree, if the value of the node is equal to the value of the root node, we have found
the node. If the value of the node is smaller than the value of the root node, we search in the left subtree. If the
value of the node is larger than the value of the root node, we search in the right subtree.

## Efficiency of Common Operations

The efficiency of common operations on a tree depends on the height of the tree. The height of a tree determines the
maximum number of nodes that need to be visited or compared in the worst case. The lower the height, the higher the
efficiency, thus the importance of balancing. The height of a tree can vary from O(log n) to O(n), where n is the
number of nodes in the tree. A balanced tree has a height of O(log n), which means that the common operations can be
performed in O(log n) time. An unbalanced tree can have a height of O(n), which means that the common operations can
take O(n) time.

## Benefits/Uses

- **Hierarchical Representation:** Trees are excellent for representing hierarchical structures, such as file systems
or organization charts. Once again, think of how we represent families; because families are hierarchical, the tree was
naturally the best solution for how to represent it.
  
- **Efficient Searching:** Balanced trees enable efficient searching, making them suitable for applications like
databases and symbol tables.


---

## Example

Consider a scenario where you want to represent a family tree:

```text
           Grandpa
         /         \
      Dad           Aunt
    /     \       /      \
  You  Sibling  Cousin  Niece
```

In this tree:
- Grandpa is the root.
- Dad and Aunt are children of Grandpa.
- You and Sibling are children of Dad.
- Cousin and Niece are children of Aunt.

## Problem to Solve

Given a tree with some nodes, write a function in C# to check whether the tree is balanced or not. A balanced tree ensures that the depth of the left and right subtrees of every node differ by no more than one.

For example:
- Balanced Tree:
  ```text
      A
     / \
    B   C
   / \
  D   E
  ```

- Unbalanced Tree:
  ```text
      A
     / \
    B   C
         \
          D
           \
            E
  ```

Test your code by creating different trees and checking if they are balanced.

You can check your code with the solution here: [Solution](./ds3-solution/Program.cs)

{[Previous - Linked List](./2-linkedList.md)}

[Back to Welcome Page](./0-welcome.md)