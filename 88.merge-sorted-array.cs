public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {

        var index1 = m - 1;
        var index2 = n - 1;
        var writeIndex = n + m - 1;

        while (writeIndex >= 0)
        {
            var testVal1 = index1 < 0 ? -2147483648 : nums1[index1];
            var testVal2 = index2 < 0 ? -2147483648 : nums2[index2];
            if (testVal1 > testVal2)
            {
                nums1[writeIndex] = nums1[index1];
                index1--;
            }
            else
            {
                nums1[writeIndex] = nums2[index2];
                index2--;
            }
            writeIndex--;
        }
    }
}