using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // RemoveDupliactesSolution _RemoveDupliactesSolution=new RemoveDupliactesSolution();
            // int reuslt = _RemoveDupliactesSolution.RemoveDupliactes(new int[3] {1,1,2});

            Solution88 _solution88 = new Solution88();
            // _solution88.Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);
            // _solution88.Merge(new int[] { 2, 0 }, 1, new int[] { 1 }, 1);
            _solution88.Merge(new int[] { 4,5,6,0,0,0 }, 3, new int[] { 1,2,3 }, 3);
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
