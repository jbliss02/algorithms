using System;
using System.Collections.Generic;

namespace lib.Arrays
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/527/searching-for-items-in-an-array/3250/
    /// </summary>
    public class DoubleCheck
    {
        public bool CheckIfExist(int[] arr) 
        {
            int n = arr.Length;
            HashSet<int> hash = new HashSet<int>();

            for(int i = 0; i < n; i++)
            {
                if(hash.Contains(arr[i]*2) || (hash.Contains(arr[i]/2) && arr[i]%2 ==0))
                {
                    return true;
                }
                else if(!hash.Contains(arr[i]))
                {
                    hash.Add(arr[i]);
                }
            }
            return false;
        }
        public bool CheckIfExist_BinarySearch(int[] arr) 
        {
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (Search(arr, 0, arr.Length, arr[i] * 2, i))
                    return true;
            }
                    
            return false;
            
        }

        private bool Search (int[] arr, int start, int end, int lookingFor, int searchingIndex)
        {
            if (end < start || start >= arr.Length)
            {
                return false;
            }

            if (end == start)
            {
                return arr[start] == lookingFor;
            }

            int mid = ((end - start) / 2) + start;

            if (arr[mid] == lookingFor && mid != searchingIndex)
            {
                return true;
            }
            else if (arr[mid] < lookingFor)
            {
                return Search(arr, mid + 1, end, lookingFor, searchingIndex);
            }
            else if (arr[mid] > lookingFor)
            {
                return Search(arr, start, mid - 1, lookingFor, searchingIndex);
            }

            return false;
        }
    }
}