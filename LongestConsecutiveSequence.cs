public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        var numSet = new HashSet<int>(nums);
        int longest = 0;

        foreach (int num in numSet)
        {
            if (numSet.Contains(num - 1)) continue;

            int current = num;
            int streak = 1;

            while (numSet.Contains(current + 1))
            {
                current++;
                streak++;
            }

            longest = Math.Max(longest, streak);
        }

        return longest;
    }
}
