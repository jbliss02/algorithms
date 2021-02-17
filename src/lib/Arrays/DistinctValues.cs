using System;
using System.Collections.Generic;

namespace src.lib.Arrays
{
    /// <summary>
    /// https://app.codility.com/c/run/trainingKWG3ZR-MFV/
    /// </summary>
    public class DistinctValues
    {
        public int solution(int[] A)
        {
            return new System.Collections.Generic.HashSet<int>(A).Count;
        }
    }
}