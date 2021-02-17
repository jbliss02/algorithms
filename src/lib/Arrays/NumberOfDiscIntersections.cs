using System.Collections.Generic;
using System;

namespace src.lib.Arrays
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/6-sorting/
    /// </summary>
    public class NumberOfDiscIntersections
    {
        internal class xy
        {
            internal int left { get; set; }
            internal int right { get; set; }
            internal int ind { get; set; }
        }

        public int solution(int[] A) 
        {
            var positions = new xy[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                positions[i] =  new xy() { ind = i, left = i - A[i], right = i + A[i] };
            }

            throw new NotImplementedException();
        }
    }
}