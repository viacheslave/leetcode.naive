﻿using System.Collections.Generic;

namespace LeetCode.Naive.Problems
{
  /// <summary>
  ///    Problem: https://leetcode.com/problems/number-of-submatrices-that-sum-to-target/
  ///    Submission: https://leetcode.com/submissions/detail/427499570/
  /// </summary>
  internal class P1074
  {
    public class Solution
    {
      public int NumSubmatrixSumTarget(int[][] matrix, int target)
      {
        var ans = 0;
        var pre = new int[matrix.Length + 1, matrix[0].Length];

        // prefix sums for cols
        for (var i = 0; i < matrix.Length; i++)
          for (var j = 0; j < matrix[0].Length; j++)
            pre[i + 1, j] = pre[i, j] + matrix[i][j];

        // subarray sums equal to target
        // where array equals to prefix sums
        for (var r1 = 0; r1 < matrix.Length; r1++)
        {
          for (var r2 = r1; r2 < matrix.Length; r2++)
          {
            var curr = 0;
            var dict = new Dictionary<int, int>();

            for (var j = 0; j < matrix[0].Length; j++)
            {
              var el = pre[r2 + 1, j] - pre[r1, j];
              curr += el;

              if (curr == target)
                ans++;

              if (dict.ContainsKey(curr - target))
                ans += dict[curr - target];

              dict[curr] = dict.ContainsKey(curr)
                ? dict[curr] + 1
                : 1;
            }
          }
        }

        return ans;
      }
    }
  }
}
