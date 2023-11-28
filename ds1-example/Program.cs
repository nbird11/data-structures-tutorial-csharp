namespace ds1_example;

internal static class StackExample
{
    private static void Main()
    {
        // Create a stack of plates
        var plateStack = new Stack<string>();

        // Push plates onto the stack
        plateStack.Push("Plate 1");
        plateStack.Push("Plate 2");
        plateStack.Push("Plate 3");

        Console.WriteLine("Top plate: " + plateStack.Peek());
        Console.WriteLine("Stack size: " + plateStack.Count);

        // Pop a plate off the stack
        string removedPlate = plateStack.Pop();
        Console.WriteLine("Removed plate: " + removedPlate);
        Console.WriteLine("Stack size after pop: " + plateStack.Count);
    }
}