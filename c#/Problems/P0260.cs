﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Naive.Problems.Easy
{
	/// <summary>
	///		Problem: https://leetcode.com/problems/single-number-iii/
	///		Submission: https://leetcode.com/submissions/detail/235009160/
	/// </summary>
	internal class P0260
	{
		public int[] SingleNumber(int[] nums)
		{
			var map = new Dictionary<int, int>();

			foreach (var n in nums)
			{
				if (!map.ContainsKey(n))
					map[n] = 0;

				map[n]++;
			}

			return map.Where(_ => _.Value == 1).Select(_ => _.Key).ToArray();
		}
	}
}