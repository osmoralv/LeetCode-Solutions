﻿using System;
using System.Collections.Generic;

int[] numbers = { 2, 3, 8, 2 };
int targert = 4;

Solution solution = new Solution();

int[] result = solution.TwoSum(numbers, targert);

Console.WriteLine("End");


public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }
            map[nums[i]] = i;
        }
        throw new ArgumentException("No two sum solution");
    }
}