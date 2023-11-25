namespace ds1_solution;

class MatchingParentheses {
    public static bool CheckBalance(string line) {
        var stack = new Stack<char>();
        foreach (var item in line) {
            if (item is '(') {
                stack.Push(item);
            }
            else if (item is ')') {
                if (stack.Count == 0 || stack.Pop() != '(')
                    return false;
            }
        }
        return stack.Count == 0;
    }
}