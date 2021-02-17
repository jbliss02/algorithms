using System.Security.Cryptography;
using System;
using System.Collections.Generic;

namespace lib.Hash
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/hash-table/183/combination-with-other-algorithms/1176/
    /// </summary>
    public class SingleNumbers
    {
        public int SingleNumber(int[] nums) 
        {
            int res = 0;
            
            for (int i = 0; i< nums.Length ; i++)
            {
                res ^= nums[i];   
            }
            return res;
    }

        public int SingleNumber_MultipleHasSets(int[] nums) 
        {
            var hash1 = new HashSet<int>();
            var hash2 = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (hash1.Contains(nums[i]) == false)
                    hash1.Add(nums[i]);
                else 
                    hash2.Add(nums[i]);
            }

            foreach (var item in hash1)
            {
                if (hash2.Contains(item) == false)
                    return item;
            }

            throw new Exception();
        }
    }
}