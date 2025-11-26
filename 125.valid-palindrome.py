#
# @lc app=leetcode id=125 lang=python3
#
# [125] Valid Palindrome
#
# https://leetcode.com/problems/valid-palindrome/description/
#
# algorithms
# Easy (52.07%)
# Likes:    11051
# Dislikes: 8603
# Total Accepted:    4.9M
# Total Submissions: 9.3M
# Testcase Example:  '"A man, a plan, a canal: Panama"'
#
# A phrase is a palindrome if, after converting all uppercase letters into
# lowercase letters and removing all non-alphanumeric characters, it reads the
# same forward and backward. Alphanumeric characters include letters and
# numbers.
# 
# Given a string s, return true if it is a palindrome, or false otherwise.
# 
# 
# Example 1:
# 
# 
# Input: s = "A man, a plan, a canal: Panama"
# Output: true
# Explanation: "amanaplanacanalpanama" is a palindrome.
# 
# 
# Example 2:
# 
# 
# Input: s = "race a car"
# Output: false
# Explanation: "raceacar" is not a palindrome.
# 
# 
# Example 3:
# 
# 
# Input: s = " "
# Output: true
# Explanation: s is an empty string "" after removing non-alphanumeric
# characters.
# Since an empty string reads the same forward and backward, it is a
# palindrome.
# 
# 
# 
# Constraints:
# 
# 
# 1 <= s.length <= 2 * 10^5
# s consists only of printable ASCII characters.
# 
# 
#

# @lc code=start
class Solution:
    def isPalindrome(self, s: str) -> bool:
        processedString = ""
        for c in s:
            if c.isnumeric():
                processedString += c
            elif c.isalpha():
                processedString += c.lower()
        forwardIndex = 0
        backIndex = len(processedString) - 1
        while forwardIndex < backIndex:
            if processedString[forwardIndex] != processedString[backIndex]:
                return False
            backIndex -= 1
            forwardIndex += 1
        return True
        
# @lc code=end
test = Solution()
print(test.isPalindrome("A man, a plan, a canal: Panama"))
print(test.isPalindrome("race a car"))
print(test.isPalindrome(" "))