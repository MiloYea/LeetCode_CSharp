using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 13;

        int[] result = TwoSum(nums, target);

        Console.WriteLine($"[{result[0]}, {result[1]}]");
    }

    static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            if (!map.ContainsKey(nums[i]))
            {
                map.Add(nums[i], i);
            }
        }

        throw new ArgumentException("No two sum solution");
    }
}
