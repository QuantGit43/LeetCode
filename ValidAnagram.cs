public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var count = new Dictionary<char, int>();

        foreach (char c in s)
        {
            count[c] = count.GetValueOrDefault(c) + 1;
        }

        foreach (char c in t)
        {
            if (!count.ContainsKey(c)) return false;

            count[c]--;

            if (count[c] < 0) return false;
        }

        return true;
    }
}
