public class Solution1
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] reuslt = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (target.Equals(nums[i] + nums[j]))
                {
                    reuslt[0] = i;
                    reuslt[1] = j;
                }
            }
        }
        return reuslt;
    }
}