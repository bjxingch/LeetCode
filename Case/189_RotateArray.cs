namespace LeetCode
{
    public class Solution
    {
        public void Rotate(int[] nums, int k)
        {
            //总共移动的次数应该等于数组的长度
            int moveCounts = 0;
            //数组的长度
            int arrayLength = nums.Length;
            //位置
            int index = 0;
            //临时记录被占用位置的数据
            int temp = 0;
            //变更临时存储数据的位置
            int tempIndex=0;
            //执行数据右移
            while (moveCounts < arrayLength)
            {
                temp=nums[(index+k)%arrayLength];
                nums[(index+k)%arrayLength]=nums[tempIndex];
                nums[tempIndex]=temp;
                index=(index+k)%arrayLength;
                if (index.Equals(tempIndex))
                {
                    tempIndex++;
                    index++;
                }
                moveCounts++;
            }
        }
    }
}