using System.Threading;
using System;
namespace lib.Arrays
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/527/searching-for-items-in-an-array/3251/
    /// </summary>
    public class MountainCheck
    {
        public bool ValidMountainArray(int[] arr) 
        {
            if (arr.Length < 3)
                return false;

            bool goingUp = true;
            bool goneUp = false;

            for (int i = 1; i < arr.Length; i++)
            {
                if (goingUp)
                {
                    if (arr[i] < arr[i -1])
                    {
                        if (!goneUp)
                            return false;

                        goingUp = false;
                    }
                    else if (arr[i] <= arr[i -1])
                    {
                        return false;
                    }

                    goneUp = true;
                }
                else 
                {
                    if (arr[i] > arr[i - 1])
                        return false;

                    if (i == arr.Length - 1)
                        return true;

                    if (arr[i] <= arr[i + 1])
                        return false;
                }

            }

            return !goingUp;
        }
    }
}