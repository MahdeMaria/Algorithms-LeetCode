using System;
using System.Collections.Generic;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> a = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int dif = target - nums[i];

            if (a.ContainsKey(dif))
            {
                return new int[] { a[dif], i };
            }

            if (!a.ContainsKey(nums[i]))
            {
                a[nums[i]] = i;
            }
        }

        throw new ArgumentException("Nenhuma solução encontrada");
    }
}

class Program
{
    static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        Solution solution = new Solution();

        int[] result = solution.TwoSum(nums, target);

        Console.WriteLine($"[{result[0]}, {result[1]}]");
    }
}
