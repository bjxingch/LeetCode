namespace LeetCode
{
    public class Solution88
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            //数组1为空时
            if (m.Equals(0))
            {
                for (int i = 0; i < n; i++)
                {
                    nums1[i] = nums2[i];
                }
                return;
            }

            //数组2为空时
            if (n.Equals(0))
            {
                return;
            }

            int nums1Count = 0;//记录数组1，已被添加了的数据个数

            for (int i = 0; i < n; i++)//遍历数组2
            {
                for (int j = 0; j < m + nums1Count; j++)//遍历数组1
                {
                    if (nums1[j] > nums2[i])
                    {
                        for (int k = m + nums1Count; k > j; k--)
                        {
                            nums1[k] = nums1[k - 1];
                        }
                        nums1[j] = nums2[i];
                        nums1Count++;
                        break;
                    }

                    if (j.Equals(m + nums1Count - 1))
                    {
                        nums1[j + 1] = nums2[i];
                        nums1Count++;
                        break;
                    }
                }
            }

        }
    }
}
