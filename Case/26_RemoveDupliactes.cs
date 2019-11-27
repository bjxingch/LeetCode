namespace LeetCode
{
    public class RemoveDupliactesSolution
    {
        public int RemoveDupliactes(int[] nums)
        {
            //防止数组为空
            if (nums == null)
            {
                return 0;
            }

            //数组长度为0
            if (nums.Length.Equals(0))
            {
                return 0;
            }

            //数组长度不为0
            int _index = 0;

            //数据不相等的时候进行位移
            for (int i = 1; i < nums.Length; i++)
            {
                if (!nums[_index].Equals(nums[i]))
                {
                    _index++;
                    nums[_index] = nums[i];
                }
            }

            return _index + 1;
        }
    }
}