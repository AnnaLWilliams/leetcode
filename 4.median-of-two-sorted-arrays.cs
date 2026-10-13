/*
 * @lc app=leetcode id=4 lang=csharp
 *
 * [4] Median of Two Sorted Arrays
 */

// @lc code=start
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
       //Calculate the mid point of the two arrays
       int midPoint;
       bool isSplitMedian;

       //If the length of the two combined arrays is an odd number round up
       midPoint =(int) Math.Ceiling((nums1.Length + nums2.Length) / 2.0);
       //If the length of the two combined arrays is even set the isSplitMedian flag to true
       isSplitMedian = (nums1.Length + nums2.Length) % 2 == 0 ? true : false;

       //Search for the value that is at the mid point of the combined arrays
       int mergeIndex;
        int index1 = 0;
        int index2 = 0;
        int currentNum = 0;
        int lastNum = 0;

        //For each value up to the mid point of the two arrays
       for (mergeIndex = 0; mergeIndex <= midPoint && mergeIndex < nums1.Length + nums2.Length; mergeIndex++)
        {
            //Store the last number found in lastNum
            lastNum = currentNum;

            //Check if an array is finished
            if(index1 >= nums1.Length)
            {
                currentNum = nums2[index2];
                index2++;
            }
            else if (index2 >= nums2.Length)
            {
                currentNum = nums1[index1];
                index1++;
            }
            else
            {
                //Get the lower of the two
                //Set current num as the the lowest of the two values
                if(nums1[index1] < nums2[index2])
                {
                    currentNum = nums1[index1];
                    index1++;
                }
                else
                {
                    currentNum = nums2[index2];
                    index2++;
                }
            }
        }

        
        if(isSplitMedian)
        {
            //For an even length array the median is between two positions on the array
            return (currentNum + lastNum) / 2.0;
        }
        else
        {
            if (nums1.Length + nums2.Length == 1)
            {
                return currentNum;
            }
            else
            {
                return lastNum;
            }
        }
       
    }
}
// @lc code=end

