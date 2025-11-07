public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var count = 0;
        var writeIndex = 0;

        for (var readIndex = 0; readIndex < nums.Length; readIndex++)
        {
            if (nums[readIndex] == val)
            {
                count++;
            }
            else
            {
                if (readIndex != writeIndex)
                {
                    nums[writeIndex] = nums[readIndex];
                }
                writeIndex++;
            }
        }


        return nums.Length - count;
    }
}