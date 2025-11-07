public class Solution {
    public void Rotate(int[] nums, int k) {

        var step = k % nums.Length;
        //Looked up the actual algorithm
        //Flip the list
        FlipList(nums, 0, nums.Length - 1);

        //Flip the first k values of the list
        FlipList(nums, 0, step - 1);
        //Flip the rest
        FlipList(nums, step, nums.Length - 1);


    }

    //Flips these two values and all values between
    private static void FlipList(int[] nums, int start, int end)
    {
        if (start == end)
        {
            return;
        }
        for (var index = start; index < start + Math.Ceiling((end - start) / 2.0); index++)
        {
            Swap(nums, index, start + end - index);
        }
    }

    private static void Swap(int[] nums, int index1, int index2)
    {
        var hold = nums[index1];
        nums[index1] = nums[index2];
        nums[index2] = hold;
    }
}