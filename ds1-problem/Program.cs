namespace ds1_problem;

internal static class Problem
{
    internal static int? EvaluateExpression(string expression)
    {
        // TODO Initialize the stack for the operands
        

        foreach (char c in expression)
        {
            if (char.IsDigit(c))
            {
                // TODO If the character is a digit, convert it to an integer and push onto the stack
                
            }
            else
            {
                // TODO If the character is an operator, pop the last two operands from the stack
                

                // TODO Perform the operation between the two operands
                // TODO For each operation, push the result back onto the stack
                switch (c)
                {
                    case '+':
                        // TODO Input your code here
                        
                        break;
                    case '-':
                        // TODO Input your code here

                        break;
                    case '*':
                        // TODO Input your code here

                        break;
                    case '/':
                        // TODO Input your code here

                        break;
                    default:
                        throw new ArgumentException("Invalid character in expression");
                }
            }
        }

        // TODO The result should be the only element left on the stack, so return it
        
        return null;
    }
}

internal static class Tester
{
    private static void Main()
    {
        const string expression1 = "23*5+";
        const string expression2 = "68+42/*";

        Console.WriteLine($"Result of '{expression1}' is {Problem.EvaluateExpression(expression1)}");
        Console.WriteLine($"Result of '{expression2}' is {Problem.EvaluateExpression(expression2)}");
    }
}