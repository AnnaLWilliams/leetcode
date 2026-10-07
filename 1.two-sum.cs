/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
using System.Globalization;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int index1;
        int index2;

        for (index1 = 0; index1 < nums.Length - 1; index1++)
        {
            for(index2 = index1 + 1; index2 < nums.Length; index2++)
            {
                if(nums[index1] + nums[index2] == target)
                {
                    return [index1, index2];
                }
            }
        }

        return [0];
    }
}
// @lc code=end

