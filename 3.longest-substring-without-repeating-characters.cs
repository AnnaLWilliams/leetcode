/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 */

// @lc code=start
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int searchIndex;
        int substringIndex;
        int substringCount;
        int substringMax = 0;
        
        string substring;

        //for each character in the string
        for (searchIndex = 0; searchIndex < s.Length; searchIndex++)
        {
            substringCount = 0;
            substring = "";

            for (substringIndex = searchIndex; substringIndex < s.Length; substringIndex++)
            {
                if (substring.Contains(s[substringIndex]))
                {
                    break;
                }
                else
                {
                    substring += s[substringIndex];
                    substringCount++;
                }
            }

            if (substringCount > substringMax)
            {
                substringMax = substringCount;
            }

            if (substringMax > s.Length - searchIndex)
            {
                break;
            }
        }


        return substringMax;
    }
}
// @lc code=end

