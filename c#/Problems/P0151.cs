using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Naive.Problems
{
  /// <summary>
  ///    Problem: https://leetcode.com/problems/reverse-words-in-a-string/
  ///    Submission: https://leetcode.com/submissions/detail/230925341/
  /// </summary>
  internal class P0151
  {
    public class Solution
    {
      public string ReverseWords(string s)
      {
        var words = s.Split(new[] { ' ' }).Where(_ => _ != string.Empty).ToArray();

        Array.Reverse(words);

        return string.Join(" ", words);
      }
    }
  }
}
