public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var writeIndex = 0;
        
        if (nums.Length == 1)
        {
            return 1;
        }

        for (var readIndex = 1; readIndex < nums.Length; readIndex++)
        {
            if(nums[readIndex] != nums[writeIndex])
            {
                writeIndex++;
                nums[writeIndex] = nums[readIndex];
            }
        }

        return writeIndex + 1;
    }
}