using System;

namespace lib.Arrays
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/526/deleting-items-from-an-array/3248/
    /// </summary>
    public class RemoveDuplicates
    {
        public int Go(int[] nums)
        {
            int removed = 0;

            for (int i = nums.Length - 1 - removed; i > 0; i--)
            {
                if (nums[i] == nums[i - 1])
                {
                    for (int j = i; j < nums.Length - removed - 1; j++)
                    {
                        nums[j] = nums[j + 1];
                    }
                    removed++;
                }
            }

            return nums.Length - removed;
        }
    }
}