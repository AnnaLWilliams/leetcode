public class Solution {
    public int Jump(int[] nums) {
        if (nums.Length <= 1)
        {
            return 0;
        }

        return TryJump(nums, nums.Length - 1);
    }

    private static int TryJump(int[] nums, int jumpTo)
    {
        var jumpFrom = -1;

        for(var index = jumpTo - 1; index >= 0; index--)
        {
            if(nums[index] + index >= jumpTo)
            {
                jumpFrom = index;
            }
        }



        if (jumpFrom == 0)
        {
            return 1;
        }
        else 
        {
            return TryJump(nums, jumpFrom) + 1;
        }
        
    }
}