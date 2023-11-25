# Stack

## Introduction

In computer science, a stack is a fundamental data structure that follows the Last In, First Out (LIFO) principle.
This means that the last element added to the stack is the first one to be removed. Imagine a stack of plates where you
always add a new plate to the top and remove the topmost plate when you need one – that's the essence of a stack.

## Operations

### Push

The `push` operation is used to add an element to the top of the stack. This is analogous to placing a new plate on top
of the stack of plates.

### Pop

The `pop` operation is used to remove the top element from the stack. It's similar to lifting the top plate off the
stack of plates.

### Peek

The `peek` operation allows you to view the top element without removing it. It's like checking the top plate without
actually taking it off the stack.

## Efficiency of Common Operations

Stacks are efficient for certain operations:

- **Push, Pop, and Peek:** All three operations have a time complexity of O(1), meaning their execution time is
constant and does not depend on the size of the stack.

## Benefits/Uses

One of the key benefits of a stack is in tracking actions or changes in a way that facilitates easy reversal or
retrieval. Some examples of easy reversal that would benefit from the use of a stack might include:

- The undo button for a text document
- Forward and backward buttons for a webpage

## Example

Let's take a look at an example of a usage for a stack in C#, checking if a given expression has balanced parentheses.

- Input: `((a + b) * (c - d))`
  Output: Balanced

- Input: `((a + b) * (c - d)`
  Output: Not Balanced

```csharp
public static class MatchingParentheses {
    public static bool CheckBalance(string line) {
        var stack = new Stack<char>();
        foreach (var item in line) {
            if (item is '(') {
                stack.Push(item);
            }
            else if (item is ')') {
                if (stack.Count == 0 || stack.Pop() != '(') {
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}
```

In this example, we could tell if the parentheses in the expression were balanced by adding the opening and closing
parentheses to the stack and checking that each open parenthesis had a matching close parenthesis.

## Problem to Solve: Postfix Expressions

Write a C# program to evaluate a given postfix expression.

A postfix expression is an expression in which each operator follows its operands.
For example, the infix expression "3 + 4" is written as "3 4 +" in postfix notation. The expression is evaluated from
left to right.

Implement a function EvaluatePostfixExpression that takes a string representing a postfix expression as input and
returns the result of the expression.

Example:

Input: "23*5+"
Output: 11 (Explanation: 2 * 3 + 5 => 6 + 5 = 11)

Input: "68+42/*"
Output: 28 (Explanation: (6 + 8) * (4 / 2) => 14 * 2 = 28)

You can check your code with the solution here: [Solution](ds1-solution/Program.cs)

[Back to Welcome Page](0-welcome.md)