using System.Collections;

namespace ds3_implementation;

public class Node
{
    public int Data { get; set; }
    public Node? Right { get; set; }
    public Node? Left { get; set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value < Data)
        {
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        if (Data == value)
        {
            return true;
        }

        return (Left?.Contains(value) ?? false) || (Right?.Contains(value) ?? false);
    }

    public int GetHeight()
    {
        int heightLeft = Left?.GetHeight() ?? 0;
        int heightRight = Right?.GetHeight() ?? 0;

        return 1 + Math.Max(heightLeft, heightRight);
    }
}

public class BinarySearchTree : IEnumerable<int>
{
    public Node? Root;

    public void Insert(int value)
    {
        var newNode = new Node(value);
        if (Root is null)
            Root = newNode;
        else
            Root.Insert(value);
    }

    public bool Contains(int value)
    {
        return Root != null && Root.Contains(value);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<int> GetEnumerator()
    {
        var numbers = new List<int>();
        TraverseForward(Root, numbers);
        foreach (var number in numbers)
        {
            yield return number;
        }
    }

    private void TraverseForward(Node? node, List<int> values)
    {
        if (node is not null)
        {
            TraverseForward(node.Left, values);
            values.Add(node.Data);
            TraverseForward(node.Right, values);
        }
    }

    public IEnumerable Reverse()
    {
        var numbers = new List<int>();
        TraverseBackward(Root, numbers);
        foreach (var number in numbers)
        {
            yield return number;
        }
    }

    private void TraverseBackward(Node? node, List<int> values)
    {
        if (node is null) return;
        TraverseBackward(node.Right, values);
        values.Add(node.Data);
        TraverseBackward(node.Left, values);
    }

    public int GetHeight()
    {
        if (Root is null)
            return 0;
        return Root.GetHeight();
    }

    public override string ToString()
    {
        return "<Bst>{" + string.Join(", ", this) + "}";
    }
}