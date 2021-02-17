using System.Security.Cryptography;
using System.Reflection.Metadata;
using System.Collections.Generic;
using System;

namespace lib.Hash
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/hash-table/183/combination-with-other-algorithms/1112/
    /// </summary>
    public class ContainsDuplicates
    {
         public bool ContainsDuplicate(int[] nums)
         {
             var hash = new HashSet<int>();

             for (int i = 0; i < nums.Length; i++)
             {
                 if (hash.Contains(nums[i]))
                    return true;

                hash.Add(nums[i]);
             }
             return false;
         }
    }
}