namespace ds1_solution;

internal static class Solution
{
    private static int EvaluateExpression(string expression)
    {
        var stack = new Stack<int>();

        foreach (char c in expression)
        {
            if (char.IsDigit(c))
            {
                // If the character is a digit, convert it to an integer and push onto the stack
                stack.Push(c - '0');
            }
            else
            {
                // If the character is an operator, pop two operands from the stack, perform the operation, and push the result back
                int operand2 = stack.Pop();
                int operand1 = stack.Pop();

                switch (c)
                {
                    case '+':
                        stack.Push(operand1 + operand2);
                        break;
                    case '-':
                        stack.Push(operand1 - operand2);
                        break;
                    case '*':
                        stack.Push(operand1 * operand2);
                        break;
                    case '/':
                        stack.Push(operand1 / operand2);
                        break;
                    default:
                        throw new ArgumentException("Invalid character in expression");
                }
            }
        }

        // The result should be the only element left on the stack
        return stack.Pop();
    }

    private static void Main()
    {
        const string expression1 = "23*5+";
        const string expression2 = "68+42/*";

        Console.WriteLine($"Result of '{expression1}' is {EvaluateExpression(expression1)}");
        Console.WriteLine($"Result of '{expression2}' is {EvaluateExpression(expression2)}");
    }
}