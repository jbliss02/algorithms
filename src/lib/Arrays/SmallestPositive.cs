using System.Security.Cryptography;
using System;
using System.Collections.Generic;

namespace src.lib.Arrays
{
    /// <summary>
    /// https://app.codility.com/c/run/trainingP9BGJZ-3WF/
    /// </summary>
    public class SmallestPositive
    {
        public int solution(int[] A) 
        {
            var hash = new HashSet<int>(A);

            for (int i = 1; i < 100000; i++)
            {
                if (!hash.Contains(i))
                    return i;
            }

            //not sure what to return, the spec does not specify
            return 0;
        }
    }
}