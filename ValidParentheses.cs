public class Solution
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();

        var matching = new Dictionary<char, char>
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        foreach (char c in s)
        {
            if (!matching.ContainsKey(c))
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0 || stack.Pop() != matching[c])
                    return false;
            }
        }

        return stack.Count == 0;
    }
}
